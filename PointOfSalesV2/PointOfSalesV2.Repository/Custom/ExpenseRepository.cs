using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Func<Expense, bool> func = expense => expense.Active==true && (startDate.HasValue?expense.Date>=startDate.Value:expense.Id>0) &&
            (endDate.HasValue ? expense.Date <= endDate.Value : expense.Id > 0) && (supplierId.HasValue ? expense.SupplierId ==supplierId.Value : expense.Id > 0) &&
            (currencyId.HasValue ? expense.CurrencyId == currencyId.Value : expense.Id > 0) && (branchOfficeId.HasValue ? expense.BranchOfficeId == branchOfficeId.Value : expense.Id > 0)
            ;
            return _Context.Expenses.Where(func);
        }
    }
}
