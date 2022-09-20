using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SpaServices.DbContextLayer;
using SpaServices.Models.Identity;

namespace SpaServices.Areas.Identity.Pages.User
{
    [Authorize(Roles = "Admin")]
    public class UserPageModel : PageModel
    {

        protected readonly UserManager<AppUser> _userManager;
        protected readonly ILogger<UserPageModel> _logger;
        protected readonly AppDbContext _dbContext;

        protected readonly RoleManager<IdentityRole> _roleManager;

        [TempData]
        public string StatusMessage { get; set; } 
        public UserPageModel(UserManager<AppUser>  userManager, ILogger<UserPageModel> logger , AppDbContext dbContext , RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _logger = logger;
            _dbContext = dbContext;
            _roleManager = roleManager;
        }
        
    }
}
