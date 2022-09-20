using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SpaServices.Security.Requirements;
using SpaServices.DbContextLayer;
using SpaServices.Models;
using SpaServices.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.Security.Requirements
{
    public class CanOptionPostUserHandler : AuthorizationHandler<CanOptionPostUserRequirements, Post>
    {
        
        private readonly UserManager<AppUser> _userManager;

        private readonly AppDbContext _context;

        public CanOptionPostUserHandler(UserManager<AppUser> userManager , AppDbContext dbContext)
        {         
            _userManager = userManager;
            _context = dbContext;
        }

        protected override async  Task HandleRequirementAsync(AuthorizationHandlerContext context, CanOptionPostUserRequirements requirement, Post resource)
        {
            var user = _userManager.GetUserAsync(context.User).Result;

           

            if (context.User.IsInRole("Admin"))
            {
                context.Succeed(requirement);
                await Task.CompletedTask;
            }


            if (user.Id == resource.AuthorId)
            {
                context.Succeed(requirement);
                await Task.CompletedTask;
            }

            //if (requirement.IsRemoveSharePosUser)
            //{
            //    var category = await _context.Categories.FindAsync(resource.CategoryId);

            //    if (category != null)
            //    {
            //        if (user.Id == category.AuthorId)
            //        {
            //            context.Succeed(requirement);
            //            await Task.CompletedTask;
            //        }
            //    }
            //}

            await Task.CompletedTask;
        }
    }
}
