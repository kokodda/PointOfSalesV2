using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers.BillServices
{
    public abstract class BillProductServiceBase : IBillProductsServices
    {
        public Result<InvoiceDetail> ProcessProductService(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory _dataRepositoryFactory, Invoice invoice)
        {
            return ProcessDetail(branchOfficeId, detail, _dataRepositoryFactory, invoice);
        }

        public Result<InvoiceDetail> ReturnProductService(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory _dataRepositoryFactory, Invoice invoice)
        {
            return ProcessReturnDetail(branchOfficeId, detail, _dataRepositoryFactory, invoice);
        }

        protected abstract Result<InvoiceDetail> ProcessDetail(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory dataRepositoryFactory, Invoice invoice);

        protected abstract Result<InvoiceDetail> ProcessReturnDetail(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory dataRepositoryFactory, Invoice invoice);

    }
}
