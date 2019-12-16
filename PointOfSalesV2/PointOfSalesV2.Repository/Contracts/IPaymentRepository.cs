using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IPaymentRepository: IBase<Payment>
    {
        Payment ApplyInvoicePayment(Payment payment);
        public object IncomesReport(object searchParams);
        public object CommisionsReport(object searchParams);
    }
}
