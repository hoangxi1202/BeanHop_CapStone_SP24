using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BeanHop.Database.EF;
using BeanHop.Model.Model;
using AutoMapper;
using BeanHop.Contract.AppUser;
using BeanHop.API.Utilities;
using Microsoft.AspNetCore.Identity;


namespace BeanHop.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly JwtHelper _jwtHelper;
        private readonly BeanHopDBContext _context;
        private readonly IOptions<MailSettings> _mailSettings;
        private readonly ILogger<SendMailService> _logger;

        public AppUsersController( 
            IMapper mapper,
            UserManager<AppUser> userManager, 
            IConfiguration config,
            JwtHelper jwtHelper,
            BeanHopDBContext context,
            IOptions<MailSettings> mailSettings,
            ILogger<SendMailService> logger)
        {
            _mapper = mapper;
            _userManager = userManager;
            _configuration = config;
            _jwtHelper = jwtHelper;
            _context= context;
            _mailSettings = mailSettings;
            _logger = logger;

        }

        // GET: api/AppUsers
 
        [HttpGet]
        public async Task<ActionResult<IQueryable<UserResponse>>> Get()
        {
          if (_userManager.Users == null)
          {
              return NotFound();
          }
            var list = _mapper.ProjectTo<UserResponse>(_userManager.Users.AsQueryable());
            return  Ok(list);
        }

        [HttpGet("{id}")]   
        public async Task<ActionResult<UserResponse>> GetAppUser(int id)
        {
          if (_userManager.Users == null)
          {
              return NotFound();
          }
            var appUser =  await _userManager.Users
            .FirstOrDefaultAsync(u => u.Id == id);

            if (appUser == null)
            {
                return NotFound();
            }

            return _mapper.Map<UserResponse>(appUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UserRequest appUser)
        {            
            try
            {
                ModelState.ValidateRequest();
                var existingUser = await _userManager.Users
                    .FirstOrDefaultAsync(u => u.Id == id);
                _mapper.Map(appUser, existingUser);
                await _userManager.UpdateAsync(existingUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

            return NoContent();
        }

        //[HttpPost]
        //public async Task<ActionResult<AppUser>> Post(UserRequest appUser)
        //{
        //    //try
        //    //{
        //    //    ModelState.ValidateRequest();

        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    BadRequest(ex.ToString());
        //    //}
        //    //var newUser = _mapper.Map<AppUser>(appUser);
        //    //_context.AppUser.Add(newUser);
        //    //await _context.SaveChangesAsync();

        //    return NoContent();
        //}

   //     [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var appUser = await _userManager.Users
            .FirstOrDefaultAsync(u => u.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }
            else
            {
                var role = (await _userManager.GetRolesAsync(appUser)).SingleOrDefault();
                if (role == "Admin" || role == "Customer")
                {
                    return Unauthorized();
                }
                ChangeStatus(appUser);
                await _userManager.UpdateAsync(appUser);

            }

            return NoContent();
        }

        private void ChangeStatus(AppUser appUser) 
        {
            if (appUser.Status == true) appUser.Status = false;
            else appUser.Status = true;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                ModelState.ValidateRequest();
                //if(IsAdmin(request.Email,request.Password))
                //{
                //    return Ok(new LoginResponse { Token = _jwtHelper.CreateToken(user, request.Email, role), Role = role });
                //}
                var user = await _userManager.Users
                    .SingleOrDefaultAsync(x => x.Email == request.Email);
                if (user == null)
                {
                    throw new Exception("Username or password is incorrect. Please try again");
                }

                var result = await _userManager.CheckPasswordAsync(user, request.Password);
                if (!result)
                {
                    throw new Exception("Username or password is incorrect. Please try again");
                }
                if(user.Status == false)
                {

                    throw new Exception("Please enter token to comfirm your account!");
                }
                var role = (await _userManager.GetRolesAsync(user)).FirstOrDefault();
                return Ok(new LoginResponse { Token = _jwtHelper.CreateToken(user, request.Email, role), Role = role });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        private bool IsAdmin(string userName, string password)
        {
            bool result = false;

            string emailAD = _configuration["AdminAccount:UserName"];
            string passwordAD = _configuration["AdminAccount:Password"];


            if (emailAD.Equals(userName) && passwordAD.Equals(password))
            {
                result = true;
            }

            return result;
        }
        // Hash the password
        private string HashPassword(string password)
        {
            var hasher = new PasswordHasher<AppUser>();
            return hasher.HashPassword(null, password);
        }
        [HttpPost("register")]
        public IActionResult Register([FromBody] UserRegistration model)
        {
            // Check if the email already exists
            if (_userManager.Users.Any(u => u.Email == model.Email))
            {
                return BadRequest("Email already registered. Please log in or use a different email.");
            }
            if (_userManager.Users.Any(u => u.PhoneNumber == model.PhoneNumber))
            {
                return BadRequest("Phone number already registered. Please log in or use a different email.");
            }
            if (model.Password != model.ConfirmPassword)
            {
                return BadRequest("Passwords do not match. Please check your entries.");
            }
            // Generate a unique token
            string token = SendMailService.GenerateToken();
            DateTime registrationTime = DateTime.UtcNow;

            // Store  in the database
            _context.Users.Add(new AppUser
            {
                Email = model.Email,
                PasswordHash = HashPassword(model.Password),
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                Status = false,
                ConfirmationToken = token,
                RegistrationTime = registrationTime
            });
            _context.SaveChanges();
            var user = _context.Users
                    .SingleOrDefault(x => x.Email == model.Email);
            _context.UserRoles.Add(new IdentityUserRole<int>
            {
                UserId = user.Id,
                RoleId = 1
            });
            _context.SaveChanges();
            // Send confirmation email
            string confirmationLink = Url.Action("ConfirmEmail", "User", new { email = model.Email, token }, Request.Scheme);
            SendMailService mailService = new SendMailService(_mailSettings, _logger);
            mailService.SendConfirmationEmail(model.Email, confirmationLink);

            return Ok("Registration successful! Check your email for the confirmation link.");
        }

        [HttpGet("confirm-email")]
        public IActionResult ConfirmEmail(string email, string token)
        {
            // Find the user by email
            var user = _context.Users.FirstOrDefault(u => u.Email == email);

            // Check if the user exists and the token is valid
            int timeExpire = int.Parse(_configuration["ExpireRegisToken:TimeMinus"]);
            if (user == null || user.ConfirmationToken != token || DateTime.UtcNow.AddMinutes(-timeExpire) < user.RegistrationTime)
            {
                return BadRequest("Invalid confirmation link or link has expired.");
            }

            // Mark the email as confirmed
            user.Status = true;
            _context.SaveChanges();

            return Ok("Email confirmed successfully!");
        }
        [HttpGet("re-send-confirm")]
        public IActionResult ReConfirmEmail(string email)
        {
            string token = SendMailService.GenerateToken();
            DateTime registrationTime = DateTime.UtcNow;
            var user = _context.Users
                    .SingleOrDefault(x => x.Email == email);
            user.ConfirmationToken = token;
            user.RegistrationTime = registrationTime;

            // Send confirmation email
            string confirmationLink = Url.Action("ConfirmEmail", "User", new { email = email, token }, Request.Scheme);
            SendMailService mailService = new SendMailService(_mailSettings, _logger);
            mailService.SendConfirmationEmail(email, confirmationLink);

            return Ok("Re send successful! Check your email for the confirmation link.");
        }

    }
}
