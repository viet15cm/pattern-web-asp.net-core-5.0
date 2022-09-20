using SpaServices.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} có độ dài từ {2} đến {1} kí tự")]
        [Required(ErrorMessage = "{0 không được bỏ trống")]
        [Display(Name = "Tiêu đề")]
        public string  Title { get; set; }

        [Display(Name = "Nội dung")]
        [DataType(DataType.Text)]
        public string Content { get; set; }

        [Display(Name = "Mô tả")]
        [DataType(DataType.Text)]
        public string Description { set; get; }

        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "{0 không được bỏ trống")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} có độ dài từ {2} đến {1} kí tự")]
        [RegularExpression(@"^[a-z0-9-]*$", ErrorMessage = "{0} phải là chữ thường và số từ 0 - 9")]
        public string Slug { set; get; }

        [Display(Name = "Tác giả")]
        public string AuthorId { set; get; }

        [ForeignKey("AuthorId")]
        public AppUser Author { set; get; }

        public int ImageId { get; set; }

        [ForeignKey("ImageId")]
        public virtual Image Image { get; set; }

        public virtual ICollection<PostCategory> PostCategories { get; set; }

    }
}
