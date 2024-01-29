using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeanHop.Model.Enums
{
    public enum UserRoles
    {
        [Display(Name = "Customer")]
        Customer,
        [Display(Name = "Admin")]
        Teacher,
        [Display(Name = "Staff")]
        Staff
    }
}
