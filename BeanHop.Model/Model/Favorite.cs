using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Model
{
    public class Favorite
    {
        [Key]
        public int FavoriteID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdatetDate { get; set; }
        public int CustomerID { get; set; }
        public virtual AppUser Customer { get; set; }
        public ICollection<FavoriteProduct> FavoriteProducts { get; set; }
    }
}
