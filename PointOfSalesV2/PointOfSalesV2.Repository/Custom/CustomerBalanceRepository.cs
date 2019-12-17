using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class CustomerBalanceRepository : Repository<CustomerBalance>, ICustomerBalanceRepository
    {
        public CustomerBalanceRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<CustomerBalance> CustomerBalanceByCurrency(long customerId, long currencyId)
        {
            throw new NotImplementedException();
        }
    }
}
