using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IInvoiceRepository: IBase<Invoice>
    {
        IEnumerable<Invoice> GetAccountsReceivable(DateTime? startDate, DateTime? endDate, Nullable<long> customerId, Nullable<long> currencyId, long? sellerId);
        IEnumerable<Invoice> GetSales(DateTime? startDate, DateTime? endDate, Nullable<long> customerId, Nullable<long> currencyId, Nullable<long> sellerId);
        Invoice GetByInvoiceNumber(string invoiceNumber);
        PagedList<Invoice> GetPagedQuotes(int page, int size);
        IEnumerable<object> GetAccountStatus(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId);

    }
}
