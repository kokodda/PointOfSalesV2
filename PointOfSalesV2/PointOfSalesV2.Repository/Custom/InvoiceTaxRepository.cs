using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class InvoiceTaxRepository : Repository<InvoiceTax>, IInvoiceTaxRepository
    {
        public InvoiceTaxRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<InvoiceTax> GetInvoiceTaxes(string invoiceNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceTax> GetInvoiceTaxes(long invoiceID)
        {
            throw new NotImplementedException();
        }
    }
}
