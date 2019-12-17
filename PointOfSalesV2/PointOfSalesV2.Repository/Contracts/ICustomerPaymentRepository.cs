using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface ICustomerPaymentRepository: IBase<CustomerPayment>
    {
        CustomerPayment ApplyInvoicePayment(CustomerPayment payment);
        public object IncomesReport(object searchParams);
        public object CommisionsReport(object searchParams);
    }
}
