using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using SpaServices.Models;
using SpaServices.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.Security.Requirements
{
    public class CanOptionCategoryUserHandler : AuthorizationHandler<CanOptionCategoryUserRequirements, Category>
    {
        private readonly UserManager<AppUser> _userManager;

        public CanOptionCategoryUserHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CanOptionCategoryUserRequirements requirement, Category resource)
        {
            var user = _userManager.GetUserAsync(context.User).Result;

            if (context.User.IsInRole("Admin"))
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }


            return Task.CompletedTask;
        }
    }
}
