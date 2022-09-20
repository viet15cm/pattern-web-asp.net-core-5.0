using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpaServices.Models.Identity;

namespace SpaServices.Areas.Identity.Pages.Account.Manager
{
    public class ProFileModel : PageModel
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public ProFileModel(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        private async Task LoadAsync(AppUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            
            Input = new InputModel
            {
                UrlImage = user.UrlImage,
                LastName = user.LastName,
                FirstName = user.FirstName,
                BirthDate = user.BirthDate,
                Company = user.Company,
                Describe = user.Describe,
                PhoneNumber = user.PhoneNumber
            };
        }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult>OnGetAsync()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return RedirectToPage("~/");
            }
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound($"Không tải được tài khoản ID = '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound($"Không có tài khoản ID: '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Lỗi cập nhật số điện thoại.";
                    return RedirectToPage();
                }
            }

            // Cập nhật các trường bổ sung
            user.UrlImage = Input.UrlImage;
            user.LastName = Input.LastName;
            user.FirstName = Input.FirstName;
            user.BirthDate = Input.BirthDate;
            user.Describe = Input.Describe;
            user.PhoneNumber = Input.PhoneNumber;
            user.Company = Input.Company;
            await _userManager.UpdateAsync(user);

            // Đăng nhập lại để làm mới Cookie (không nhớ thông tin cũ)
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Hồ sơ của bạn đã cập nhật";
            
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostImageAsync()
        {

            if (!_signInManager.IsSignedIn(User))
            {
                return RedirectToPage("~/");
            }
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound($"Không tải được tài khoản ID = '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);

            return Page();
            
        }


        public class InputModel
        {
            
            public string UrlImage { get; set; }

            [Display(Name = "Họ")]
            [StringLength(20, ErrorMessage = "{0} dài từ {2} đến {1} ký tự.", MinimumLength = 3)]
            public string LastName { get; set; }

            [Display(Name = "Tên")]

            [StringLength(20, ErrorMessage = "{0} dài từ {2} đến {1} ký tự.", MinimumLength = 3)]
            public string FirstName { get; set; }

            [Display(Name = "Ngày sinh")]
            public DateTime? BirthDate { set; get; }

            [Display(Name = "Công ty")]
            [StringLength(20, ErrorMessage = "{0} dài từ {2} đến {1} ký tự.", MinimumLength = 5)]
            public string Company { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Mô tả bản thân")]
            public string Describe { get; set; }

            [Phone]
            [Display(Name = "Số điện thoại")]
            public string PhoneNumber { get; set; }

        }
    }


    

    

}
