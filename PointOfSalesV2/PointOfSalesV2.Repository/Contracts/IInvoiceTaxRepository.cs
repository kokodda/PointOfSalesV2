using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IInvoiceTaxRepository: IBase<InvoiceTax>
    {
        IEnumerable<InvoiceTax> GetInvoiceTaxes(string invoiceNumber);
        IEnumerable<InvoiceTax> GetInvoiceTaxes(long invoiceID);
    }
}
