using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSalesV2.Api.Security
{
    public class ControllerAuthorize : TypeFilterAttribute
    {
        public ControllerAuthorize(string section="") : base(typeof(ClaimRequirementFilter))
        {

            Arguments = new object[] { section };
        }




    }

    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        readonly string[] _section;
        readonly IHttpContextAccessor _httpContextAccessor;
        readonly IMemoryCache _cache;

        public ClaimRequirementFilter(string section, IHttpContextAccessor httpContextAccessor, IMemoryCache cache)
        {
            _section = string.IsNullOrEmpty(section)?new string[0]:(section.Contains(",")?section.ToLower().Split(","):new string[1] { section.ToLower()});
            _httpContextAccessor = httpContextAccessor;
            _cache = cache;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool isInvalid = false;
            var currentToken = _httpContextAccessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "Authorization").Value.ToString();


            var currentPath = _httpContextAccessor.HttpContext.Request.Path.ToString().Split("/").ToList();
            int index = currentPath.IndexOf("api") + 1;
            string[] currentController =_section.Length==0? new string[1] { currentPath[index] } :_section;
            if (string.IsNullOrEmpty(currentToken) || currentController.Length==0 || !currentToken.Contains("Bearer"))
                isInvalid = true;

            if (!isInvalid)
            {
                string token = currentToken.Split(" ").LastOrDefault();
                User user = _cache.Get<User>(token);
                if (user == null)
                    context.Result = new ForbidResult();
                else
                {
                    var actualPermission = user.Permissions.Where(x => currentController.Contains(x.SectionName.ToLower())||
                    x.SectionName.ToLower() == "*").FirstOrDefault();

                    if (actualPermission == null && user.Permissions.Count() > 0)
                        context.Result = new ForbidResult();
                }

            }
            else
                context.Result = new ForbidResult();
        }
    }
}
