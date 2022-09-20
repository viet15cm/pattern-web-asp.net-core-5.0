using Microsoft.AspNetCore.Authorization;
using SpaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.Security.Requirements
{
    public class NewUpdatePostHandler : AuthorizationHandler<AppAuthorizationRequirement, Post>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AppAuthorizationRequirement requirement, Post resource)
        {
            if (IsNewDateTimePost(resource))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }

        private bool IsNewDateTimePost(Post post)
        {
            return false;
        }
    }
}
