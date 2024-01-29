using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Model
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public DateTime CreateDate { get; set; }
        public string Method { get; set; }
        public double TotalPrice { get; set; }  
        public bool Status { get; set; } 
        public Transport Transport { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }

    }
}
