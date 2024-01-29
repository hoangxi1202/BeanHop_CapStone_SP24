using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Model
{
    public class RoastLevel
    {
        [Key]
        public int RoastLevelID { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        
        public string RoastName { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
