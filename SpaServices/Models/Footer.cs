using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.Models
{
    public class Footer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Tiêu đề")]
        [StringLength(100, ErrorMessage = "{0} tối đa {1} kí tự")]
        public string Title { get; set; }

        public string Content { get; set; }

    }
}
