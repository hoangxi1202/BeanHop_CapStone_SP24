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
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }
        [Column(TypeName = "ntext")]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdatetDate { get; set; }
        public bool status { get; set; }
        public int? UserID { get; set; }
        public virtual AppUser? User { get; set; }
    }
}
