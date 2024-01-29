using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Model
{
    public class Rate
    {
        [Key]
        public int RateID { get; set; }
        public int Rating { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdatetDate { get; set; }
        public bool status { get; set; }
        public int UserID { get; set; }
        public AppUser User { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
