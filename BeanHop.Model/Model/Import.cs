using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Model
{
    public class Import
    {
        [Key]
        public int ImportID { get; set; }
        [Required]
        public double TotalWeight { get; set; }
        [Required]
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdatetDate { get; set; }
        public bool status { get; set; }
        public int StaffID { get; set; }
        public virtual AppUser Staff { get; set; }
        public virtual ICollection<Bean> Beans { get; set; }
    }
}
