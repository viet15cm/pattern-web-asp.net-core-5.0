using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.Models
{
    public class Banner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0 không được bỏ trống")]
        [Display(Name = "Tên")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "{0} nằm trong khoảng từ {2} đến {1} kí tự ")]
        public string Name { get; set; }


        [Display(Name = "Tiêu đề")]
        [StringLength(100, ErrorMessage = "{0} tối đa {1} kí tự")]
        public string Title { get; set; }

        public string UrlImage { get; set; }

        public virtual ICollection<UserInterface> UserInterfaces { get; set; }

    }
}
