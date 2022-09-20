using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.Models
{
    public class PostCategory
    {
        public int PostId { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public int Serial { get; set; }
    }
}
