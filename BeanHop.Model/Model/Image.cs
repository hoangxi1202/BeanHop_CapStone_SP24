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
    public class Image
    {
        [Key]
        public int ImageID { get; set; }
        [Column(TypeName = "ntext")]
        public string ImageName { get; set; }
        public byte[] ImageData { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public int? ProductID { get; set; }
        public virtual Product? Product { get; set; }
        public int? PostID { get; set; }
        public virtual Post? Post { get; set; }
        public int? UserID { get; set; }
        public virtual AppUser? User { get; set; }
    }
}
