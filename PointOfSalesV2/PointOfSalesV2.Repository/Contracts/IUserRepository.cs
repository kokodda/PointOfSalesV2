using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IUserRepository : IBase<User>
    {
        User Login(Login login,string tokenKey);
    }
}
