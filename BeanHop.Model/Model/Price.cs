using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Model
{
    public class Price
    {
        [Key]
        public int PriceID { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string PackagingType { get; set; }
        [Required]
        public double Cost { get; set; }
        public bool status { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
