using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class InvoiceDetailRepository : Repository<InvoiceDetail>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<InvoiceDetail> GetByInvoiceId(long invoiceId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceDetail> GetByProductId(long productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceDetail> GetChildren(long parentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceDetail> GetInvoiceParentsDetails(long invoiceId)
        {
            throw new NotImplementedException();
        }
    }
}
