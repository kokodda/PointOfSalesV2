using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class PaymentDetail : CommonData
    {

        public long PaymentId { get; set; }
        public long InvoiceId { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        [NotMapped]
        public override string TranslationData { get; set; }

        public decimal OwedAmount { get; set; }
        public DateTime BillingDate { get; set; }

        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }






    }
}
