using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BeanHop.Database.EF;
using BeanHop.Model.Model;
using AutoMapper;
using BeanHop.Contract.AppUser;
using BeanHop.API.Utilities;

namespace BeanHop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly BeanHopDBContext _context;
        private readonly IMapper _mapper;

        public AppUsersController(BeanHopDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //
        // GET: api/AppUsers
        [HttpGet]
        public async Task<ActionResult<IQueryable<UserResponse>>> GetAppUser()
        {
          if (_context.AppUser == null)
          {
              return NotFound();
          }
            var list = _mapper.ProjectTo<UserResponse>(_context.AppUser.AsQueryable());
            return  Ok(list);
        }

        // GET: api/AppUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponse>> GetAppUser(int id)
        {
          if (_context.AppUser == null)
          {
              return NotFound();
          }
            var appUser = await _context.AppUser.FindAsync(id);

            if (appUser == null)
            {
                return NotFound();
            }

            return _mapper.Map<UserResponse>(appUser);
        }

        // PUT: api/AppUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUser(int id, UserRequest appUser)
        {            
            try
            {
                ModelState.ValidateRequest();
                var existingUser = await _context.AppUser.FindAsync(id);
                _mapper.Map(appUser, existingUser);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

            return NoContent();
        }

        // POST: api/AppUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppUser>> PostAppUser(UserRequest appUser)
        {
          if (_context.AppUser == null)
          {
              return Problem("Entity set 'BeanHopDBContext.AppUser'  is null.");
          }
            try
            {
                ModelState.ValidateRequest();

            }
            catch (Exception ex)
            {
                BadRequest(ex.ToString());
            }
            var newUser = _mapper.Map<AppUser>(appUser);
            _context.AppUser.Add(newUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/AppUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUser(int id)
        {
            if (_context.AppUser == null)
            {
                return NotFound();
            }
            var appUser = await _context.AppUser.FindAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }
            ChangeStatus(appUser);
            _context.AppUser.Update(appUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

       
        private void ChangeStatus(AppUser appUser) 
        {
            if (appUser.Status == true) appUser.Status = false;
            else appUser.Status = true;
        }
    }
}
