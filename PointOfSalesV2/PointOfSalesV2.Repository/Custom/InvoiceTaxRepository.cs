using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return _Context.InvoicesTaxes.Where(x => x.NoInvoice.ToLower() == invoiceNumber.ToLower());
        }

        public IEnumerable<InvoiceTax> GetInvoiceTaxes(long invoiceID)
        {
            return _Context.InvoicesTaxes.Where(x => x.InvoiceId == invoiceID);
        }
    }
}
