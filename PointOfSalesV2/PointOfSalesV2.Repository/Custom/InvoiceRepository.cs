using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PointOfSalesV2.Common;

namespace PointOfSalesV2.Repository
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<Invoice> GetAccountsReceivable(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId, long? sellerId)
        {

            Func<Invoice, bool> func = invoice => invoice.Active == true && (startDate.HasValue ? invoice.BillingDate >= startDate.Value : invoice.Id > 0) &&
            (endDate.HasValue ? invoice.BillingDate <= endDate.Value : invoice.Id > 0) && (customerId.HasValue ? invoice.CustomerId == customerId.Value : invoice.Id > 0) &&
            (currencyId.HasValue ? invoice.CurrencyId == currencyId.Value : invoice.Id > 0) && (sellerId.HasValue ? invoice.SellerId == sellerId.Value : invoice.Id > 0) &&
            invoice.OwedAmount > 0 && (invoice.State == (char)Enums.BillingStates.Billed);
            return _Context.Invoices.Where(func);
        }

        public IEnumerable<object> GetAccountStatus(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId)
        {
            throw new NotImplementedException();
        }

        public Invoice GetByInvoiceNumber(string invoiceNumber)
        {
            return _Context.Invoices.FirstOrDefault(x => x.Active == true && x.InvoiceNumber.ToLower() == invoiceNumber.ToLower());
        }

        public PagedList<Invoice> GetPagedQuotes(int page, int size)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetSales(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId, long? sellerId)
        {
            Func<Invoice, bool> func = invoice => invoice.Active == true && (startDate.HasValue ? invoice.BillingDate >= startDate.Value : invoice.Id > 0) &&
         (endDate.HasValue ? invoice.BillingDate <= endDate.Value : invoice.Id > 0) && (customerId.HasValue ? invoice.CustomerId == customerId.Value : invoice.Id > 0) &&
         (currencyId.HasValue ? invoice.CurrencyId == currencyId.Value : invoice.Id > 0) && (sellerId.HasValue ? invoice.SellerId == sellerId.Value : invoice.Id > 0) 
         && (invoice.State != (char)Enums.BillingStates.Nulled);
            return _Context.Invoices.Where(func);
        }

        public override Result<Invoice> Add(Invoice entity)
        {
            return base.Add(entity);
        }

        private Result<Invoice> CreateNRC(Invoice obj)
        {
            if (!string.IsNullOrEmpty(obj.TRNType) && obj.TRNType != "N/A")
            {
                
                var trnControl = _Context.TRNsControl.FirstOrDefault(x => x.Active == true && x.Type == obj.TRNType);
                if (trnControl == null || trnControl.Quantity <= 0)
                    return new Result<Invoice>(-1, -1, "trnNotAvailable_msg");

                obj.TRN = $"{trnControl.Series}{trnControl.Type}{string.Format("{0:00000000}", trnControl.Sequence)}";
                trnControl.Sequence++;
                trnControl.Quantity--;
                trnControl.NumericControl++;
                _Context.TRNsControl.Update(trnControl);
                _Context.SaveChanges();
                return new Result<Invoice>(0, 0, "ok_msg", new List<Invoice>() { obj });
            }
            return new Result<Invoice>(0, 0, "ok_msg", new List<Invoice>() { obj });
        }
    }
}
