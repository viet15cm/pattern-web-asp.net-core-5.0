using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.Models
{
    public class Logo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="{0 không được bỏ trống")]
        [Display(Name = "Tên")]
        [StringLength(100, MinimumLength = 3 , ErrorMessage ="{0} phải từ {2} đến {1} kí tự ")]
        public string Name { get; set; }

        public string UrlImage { get; set; }


        public virtual ICollection<UserInterface> UserInterfaces { get; set; }


    }
}
