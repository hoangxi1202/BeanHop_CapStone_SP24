using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Contract.Product
{
    public class ProductRequest
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Introduction { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime ExpextDate { get; set; }
        [Required]
        public int? RoastLevelID { get; set; }
    }
}
