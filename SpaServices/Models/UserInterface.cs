using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.Models
{
    public class UserInterface
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Background")]
        public int BackgroundId { get; set; }

        [ForeignKey("BackgroundId")]
        public virtual Backgound Backgound { get; set; }

        [Display(Name = "Logo")]
        public int LogoId { get; set; }

        [ForeignKey("LogoId")]
        public virtual Logo Logo { get; set; }
         
        [Display(Name ="Banner thống kê")]
        public int BannerStatiscalId { get; set; }

        [ForeignKey("BannerStatiscalId")]
        public Banner Banner { get; set; }
        
       
        
    }
}
