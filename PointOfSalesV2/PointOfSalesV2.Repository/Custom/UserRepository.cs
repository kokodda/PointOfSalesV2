using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MainDataContext context) : base(context)
        {
        }

        public User Login(Login login,string tokenKey)
        {
            var user = _Context.Users.FirstOrDefault(u => u.Active == true && u.Email == login.Email && u.Password == MD5.Encrypt(login.Password, tokenKey));
            if (user != null) 
            {
               user.Permissions =
                        (
                        from ur in _Context.UserRoles
                        join rs in _Context.RoleSections on ur.RoleId equals rs.RoleId
                        join s in _Context.Sections on rs.SectionId equals s.Id
                        join so in _Context.SectionOperations on s.Id equals so.SectionId
                        
                        where ur.UserId == user.UserId && ur.Active == true
                        select new UserOperation()
                        {
                           Controllers=so.Section.Controllers,
                           OperationId=so.OperationId,
                           OperationName=so.Operation.Name,
                           SectionId=so.SectionId,
                           SectionName=so.Section.Name
                        }
                        );

            }
            return user;
        }
    }
}
