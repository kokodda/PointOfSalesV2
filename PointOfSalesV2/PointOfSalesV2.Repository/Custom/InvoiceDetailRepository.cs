﻿using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PointOfSalesV2.Repository
{
    public class InvoiceDetailRepository : Repository<InvoiceDetail>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<InvoiceDetail> GetByInvoiceId(long invoiceId)
        {
            return _Context.InvoicesDetails.Where(x => x.Active == true && x.InvoiceId == invoiceId);
        }

        public IEnumerable<InvoiceDetail> GetByProductId(long productId)
        {
            return _Context.InvoicesDetails.Where(x => x.Active == true && x.ProductId == productId);
        }

        public IEnumerable<InvoiceDetail> GetChildren(long parentId)
        {
            return _Context.InvoicesDetails.Where(x => x.Active == true && x.ParentId==parentId);
        }

        public IEnumerable<InvoiceDetail> GetInvoiceParentsDetails(long invoiceId)
        {
            return _Context.InvoicesDetails.Where(x => x.Active == true && x.InvoiceId == invoiceId && x.ParentId==null);
        }
    }
}
