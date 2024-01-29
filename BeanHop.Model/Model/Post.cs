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
    public class Post
    {
        [Key]
        public int PostID { get; set; }

        [Column(TypeName = "ntext")]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdatetDate { get; set; }
        public bool status { get; set; }
        public int? StaffID { get; set; }
        public virtual AppUser? Staff { get; set; }
        public ICollection<Comment> Comments { get; set;}
        public ICollection<Image> Images { get; set; }

    }
}
