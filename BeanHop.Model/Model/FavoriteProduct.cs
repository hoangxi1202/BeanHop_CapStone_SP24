using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Model
{
    public class FavoriteProduct
    {
        public int FavouriteID { get; set; }
        public Favorite Favorite { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
