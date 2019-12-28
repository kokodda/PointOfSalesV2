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
        public ActionAuthorize(string operation) : base(typeof(ActionRequirementFilter))
        {

            Arguments = new object[] { operation };
        }




    }

    public class ActionRequirementFilter : IAuthorizationFilter
    {
        readonly string _operation;
        readonly IHttpContextAccessor _httpContextAccessor;
        readonly IMemoryCache _cache;

        public ActionRequirementFilter(string operation, IHttpContextAccessor httpContextAccessor, IMemoryCache cache)
        {
            _operation = operation;
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
                    var operations = user.Permissions.Where(r => r.SectionName.ToLower()==currentController.ToLower() && r.OperationName.ToLower()==_operation.ToLower());

                    if (user.Permissions.Count() > 0 && operations==null)
                        context.Result = new ForbidResult();
                }

            }
            else
                context.Result = new ForbidResult();
        }
    }
}
