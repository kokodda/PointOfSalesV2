using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<Expense> GetDebsToPay(DateTime? startDate, DateTime? endDate, long? supplierId, long? currencyId, long? branchOfficeId)
        {
            throw new NotImplementedException();
        }
    }
}
