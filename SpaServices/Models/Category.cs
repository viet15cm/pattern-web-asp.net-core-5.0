using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} có độ dài từ {2} đến {1} kí tự")]
        [Required(ErrorMessage = "{0 không được bỏ trống")]
        [Display(Name="Tên")]
        public string Name { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} có độ dài từ {2} đến {1} kí tự")]
        [Required(ErrorMessage = "{0 không được bỏ trống")]
        [Display(Name ="Tiêu đề")]
        public string Title { get; set; }

        [Display(Name = "Tiêu đề nhỏ")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} có độ dài từ {2} đến {1} kí tự")]
        public string TitleChild { get; set; }

       
        [Display(Name = "Mô tả")]
        [DataType(DataType.Text)]
        public string Description { get; set; }


        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "{0 không được bỏ trống")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} có độ dài từ {2} đến {1} kí tự")]         
        [RegularExpression(@"^[a-z0-9-]*$", ErrorMessage = "{0} phải là chử thường và số từ 0 - tới 9")]
        public string Slug { set; get; }

        public virtual ICollection<PostCategory> PostCategories { get; set; }


    }
}
