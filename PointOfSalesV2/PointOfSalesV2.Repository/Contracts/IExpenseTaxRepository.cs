using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IExpenseTaxRepository: IBase<ExpenseTax>
    {
        IEnumerable<ExpenseTax> GetExpenseTaxes(string reference);
        IEnumerable<ExpenseTax> GetExpenseTaxes(long id);
    }
}
