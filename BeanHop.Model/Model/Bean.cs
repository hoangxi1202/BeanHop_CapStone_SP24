using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Model
{
    public class Bean
    {
        [Key]
        public int BeanID { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        [StringLength(100)]
        [RegularExpression(@"^\S.*$", ErrorMessage = "Không được bắt đầu bằng khoảng trắng.")]
        public string BeanName { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        [StringLength(100)]
        [RegularExpression(@"^\S.*$", ErrorMessage = "Không được bắt đầu bằng khoảng trắng.")]
        public string Breed { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        [RegularExpression(@"^\S.*$", ErrorMessage = "Không được bắt đầu bằng khoảng trắng.")]
        public string Region { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]      
        public double Price { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdatetDate { get; set; }
        public bool status { get; set; }
        public int ImportID { get; set; }
        public virtual Import Import { get; set; }
        public ICollection<BeanProduct> BeanProducts { get; set; }

    }
}
