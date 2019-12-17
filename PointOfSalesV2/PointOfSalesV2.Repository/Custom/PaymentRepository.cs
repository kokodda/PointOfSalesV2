using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        public PaymentRepository(MainDataContext context) : base(context)
        {
        }

        public Payment ApplyInvoicePayment(Payment payment)
        {
            throw new NotImplementedException();
        }

        public object CommisionsReport(object searchParams)
        {
            throw new NotImplementedException();
        }

        public object IncomesReport(object searchParams)
        {
            throw new NotImplementedException();
        }
    }
}
