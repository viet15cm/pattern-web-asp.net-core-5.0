using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.Security.Requirements
{
    public class CanOptionPostUserRequirements : IAuthorizationRequirement
    {
     
        public bool IsRemoveSharePosUser { get; set; }

        public CanOptionPostUserRequirements( bool _IsRemoveSharePosUser = false)
        {
            IsRemoveSharePosUser = _IsRemoveSharePosUser;
        }
    }
}
