using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Model
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdatetDate { get; set; }
        public bool status { get; set; }
        public int UserID { get; set; }
        public AppUser User { get; set; }
        public int PostID { get; set; }
        public Post Post { get; set; }
    }
}
