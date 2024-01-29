using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Model
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public double TotalProductPrice { get; set; }
        public double Discount { get; set; }
        public double TotalOrderPrice { get; set;}
        public int Status { get; set; }
        public Payment Payment { get; set; }
        public int CustomerID { get; set; }
        public AppUser Customer { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
