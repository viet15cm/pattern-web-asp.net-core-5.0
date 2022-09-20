using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SpaServices.DbContextLayer;

namespace SpaServices.Areas.Identity.Pages.Role
{
    [Authorize(Policy = "Admin")]
    public class RolePageModel : PageModel
    {
        protected readonly RoleManager<IdentityRole> _roleManager;

        protected readonly AppDbContext _context;
        protected readonly ILogger<IndexModel> _logger;


        [TempData]
        public string StatusMessage { get; set; }

        public RolePageModel(RoleManager<IdentityRole> roleManager, ILogger<IndexModel> logger , AppDbContext context)
        {
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
        }

    }
}
