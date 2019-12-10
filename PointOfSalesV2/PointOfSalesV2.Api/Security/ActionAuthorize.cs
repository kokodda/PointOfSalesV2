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
    public class ActionAuthorize : TypeFilterAttribute
    {
        public ActionAuthorize(int actionId) : base(typeof(ActionRequirementFilter))
        {

            Arguments = new object[] { actionId };
        }




    }

    public class ActionRequirementFilter : IAuthorizationFilter
    {
        readonly int _action;
        readonly IHttpContextAccessor _httpContextAccessor;
        readonly IMemoryCache _cache;

        public ActionRequirementFilter(int action, IHttpContextAccessor httpContextAccessor, IMemoryCache cache)
        {
            _action = action;
            _httpContextAccessor = httpContextAccessor;
            _cache = cache;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool isInvalid = false;
            var currentToken = _httpContextAccessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "Authorization").Value.ToString();


            var currentPath = _httpContextAccessor.HttpContext.Request.Path.ToString().Split("/").ToList();
            int index = currentPath.IndexOf("api") + 1;
            string currentController = currentPath[index];
            if (string.IsNullOrEmpty(currentToken) || string.IsNullOrEmpty(currentController) || !currentToken.Contains("Bearer"))
                isInvalid = true;

            if (!isInvalid)
            {
                string token = currentToken.Split(" ").LastOrDefault();
                User user = _cache.Get<User>(token);
                if (user == null)
                    context.Result = new ForbidResult();
                else
                {
                    //var operations = user.UserRoles.Where(r => r.Role.Controllers != null && r.Role.Controllers.Exists(c => c.ControllerName.ToLower() == currentController.ToLower())).Select(x => x.Role.Controllers).SelectMany(a => a.SelectMany(b => b.Actions)).ToList();

                    //if (user.UserRoles?.Count > 0 && !operations.Exists(o => o == _action))
                    //    context.Result = new ForbidResult();
                }

            }
            else
                context.Result = new ForbidResult();
        }
    }
}
