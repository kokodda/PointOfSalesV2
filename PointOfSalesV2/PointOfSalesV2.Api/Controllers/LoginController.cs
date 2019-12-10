using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IMemoryCache _cache;
        private readonly IBase<User> users;

        public LoginController(IMemoryCache cache, IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory)
        {
            this._appSettings = appSettings;
            this._cache = cache;
            this.users = repositoryFactory.GetDataRepositories<User>();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Login model)
        {
            try
            {
                User user = users.Get(x => x.Where(u => u.Active == true && u.Email == model.Email && u.Password == MD5.Encrypt(model.Password, _appSettings.Value.TokenKey)));
                if (user == null)
                    return Ok(new { status = -1, message = "Invalid credentials" });
                var claims = new[]
           {
                        new Claim(JwtRegisteredClaimNames.UniqueName, user.Email),
                        new Claim(JwtRegisteredClaimNames.Sid,  user.Id.ToString()),
                        //new Claim("miValor", "Lo que yo quiera"),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.Value.TokenKey));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var expiration = DateTime.UtcNow.AddHours(_appSettings.Value.TokenTimeHours);

                JwtSecurityToken token = new JwtSecurityToken(
                     issuer: _appSettings.Value.Domain,
                     audience: _appSettings.Value.Domain,
                     claims: claims,
                     expires: expiration,
                     signingCredentials: creds
                     );
                string tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                user.TokenKey = tokenString;
                _cache.Set<User>(tokenString, user, DateTimeOffset.Now.AddHours(_appSettings.Value.TokenTimeHours));
                return Ok(new
                {
                    message = "OK",
                    status = 1,
                    token = tokenString,
                    expiration = expiration,
                    user = user
                });
            }
            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}