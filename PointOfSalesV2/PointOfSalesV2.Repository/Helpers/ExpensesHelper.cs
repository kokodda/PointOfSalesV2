using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers
{
   public class ExpensesHelper
    {
      
        public static void UpdateExpenseTaxes(Expense expense, IDataRepositoryFactory dataRepositoryFactory)
        {
            var expensesTaxRepo = dataRepositoryFactory.GetCustomDataRepositories<IExpenseTaxRepository>();
            expense.Taxes = expense.Taxes == null ? new List<ExpenseTax>() : expense.Taxes;
            var expenseTaxes = expensesTaxRepo.GetExpenseTaxes(expense.ExpenseReference).ToList();
            if (expenseTaxes != null && expenseTaxes.Count > 0)
            {
                foreach (ExpenseTax tax in expenseTaxes)
                {
                    expensesTaxRepo.Remove(tax.Id);
                }
            }



            foreach (var expenseTax in expense.Taxes)
            {
                ExpenseTax tax = new ExpenseTax()
                {
                   CreatedBy = expense.CreatedBy,
                    Active = true,
                    ExpenseId = expense.Id,
                    Date = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    TaxId = expenseTax.TaxId,
                    CurrencyId = expense.CurrencyId,
                    TaxAmount = expenseTax.TaxAmount,
                    Reference = expense.ExpenseReference,

                };
                expensesTaxRepo.Add(tax);
            }
        }

        public static Result<ExpensesPayment> ApplyExpensePayment(ExpensesPayment payment, IDataRepositoryFactory dataRepositoryFactory)
        {
            var paymentRepo=dataRepositoryFactory.GetDataRepositories<ExpensesPayment>();
            return paymentRepo.Add(payment);
        }

    }
}
