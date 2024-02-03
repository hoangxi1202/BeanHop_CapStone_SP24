using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Contract.Product
{
    public class ProductReponse
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Introduction { get; set; }
        public string Description { get; set; }
        public DateTime ExpextDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdatetDate { get; set; }
        public bool status { get; set; }
        public int? RoastLevelID { get; set; }
        public string RoastLevelName { get; set; }
    }
}
