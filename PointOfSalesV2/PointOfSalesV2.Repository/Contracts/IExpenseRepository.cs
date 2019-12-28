using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IExpenseRepository : IBase<Expense>
    {
        IEnumerable<Expense> GetDebsToPay(DateTime? startDate, DateTime? endDate, Nullable<long> supplierId, Nullable<long> currencyId, Nullable<long> branchOfficeId);
    }
}
