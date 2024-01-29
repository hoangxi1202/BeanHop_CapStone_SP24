using BeanHop.Model.Annotation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Model
{
    public class Product
    {
        [Key]
        public int ProductID  {get; set;}
        [Required]
        [Column(TypeName = "ntext")]
        public string ProductName { get; set;}
        [Column(TypeName = "ntext")]
        [Required]
        public string Introduction { get; set;}
        [Required]
        [Column(TypeName = "ntext")]
        public string Description { get; set;}
        [Required]
 //       [DateAfterToday]
        public DateTime ExpextDate { get; set;}
        public DateTime CreateDate { get; set; }
        public DateTime? UpdatetDate { get; set; }
        public bool status { get; set;}
        public int? RoastLevelID { get; set; }
        public virtual RoastLevel? RoastLevel { get; set; }
        public virtual ICollection<Price>? ListPrice { get; set; }
        public ICollection<BeanProduct>? BeanProducts { get; set; }
        public ICollection<FavoriteProduct>? FavoriteProducts { get; set; }
        public ICollection<Image>? Images { get; set; }
        public ICollection<Rate>? Rates { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }




    }
}
