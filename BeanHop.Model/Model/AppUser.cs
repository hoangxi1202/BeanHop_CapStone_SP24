using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BeanHop.Model.Model
{
    public class AppUser : IdentityUser<int>
    {
        public bool Status { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string? ConfirmationToken { get; set; }
        public DateTime? RegistrationTime { get; set; }
        public virtual Favorite? Favourite { get; set; }
        public ICollection<Rate>? Rates { get; set; }
        public ICollection<Import>? Imports { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Post>? Posts { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ICollection<Image>? Images { get; set; }
        public ICollection<Notification>? Notifications { get; set; }








    }
}
