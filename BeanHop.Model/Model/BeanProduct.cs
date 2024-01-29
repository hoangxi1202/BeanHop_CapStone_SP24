using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Model
{
    public class BeanProduct
    {
        public int BeanID { get; set; }
        public  Bean Bean { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
