using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class ExpenseTaxRepository : Repository<ExpenseTax>, IExpenseTaxRepository
    {
        public ExpenseTaxRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<ExpenseTax> GetExpenseTaxes(string reference)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExpenseTax> GetExpenseTaxes(long id)
        {
            throw new NotImplementedException();
        }
    }
}
