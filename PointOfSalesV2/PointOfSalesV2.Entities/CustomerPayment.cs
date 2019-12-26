using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class CustomerPayment : CommonData
    {

        public CustomerPayment() { }

        public CustomerPayment(long CustomerId, long CurrencyId, long InvoiceCurrencyId, long PaymentTypeId, decimal TotalAmount, decimal PaidAmount, string InvoiceNumber, decimal ExchangeRate, decimal OutstandingAmount,
            string Sequence, string Details, DateTime CreatedDate, Guid CreatedBy, bool Active, decimal CurrentOutstandingAmount, string CheckbookNumber, decimal SellerRate = 0, int? SellerId = null, decimal currentOwedAmount=0)
        {
            this.Active = Active;
            this.CustomerId = CustomerId;
            this.CreatedBy = CreatedBy;
            this.Details = Details;
            this.CreatedDate = CreatedDate;
            this.InvoiceCurrencyId = InvoiceCurrencyId;
            this.CurrencyId = CurrencyId;
            this.PaidAmount = PaidAmount;
            this.OutstandingAmount = OutstandingAmount; // Monto pendiente
            this.TotalAmount = TotalAmount;
            this.InvoiceNumber = InvoiceNumber;
            this.Sequence = Sequence;
            this.ExchangeRate = ExchangeRate;
            this.PaymentTypeId = PaymentTypeId;
            this.CurrentOutstandingAmount = CurrentOutstandingAmount;
            this.CheckbookNumber = CheckbookNumber;
            this.SellerRate = SellerRate;
            this.SellerId = SellerId;
            this.CurrentOwedAmount = currentOwedAmount;
        }
        public long CustomerId { get; set; }
        [NotMapped]
        public int DaysCount
        {
            get
            {
                return Convert.ToInt32((DateTime.Now - this.CreatedDate).TotalDays);
            }
        }
        [NotMapped]
        public decimal CurrentOwedAmount { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal SellerRate { get; set; } = 0;
        public long CurrencyId { get; set; }
        public long InvoiceCurrencyId { get; set; }

        public long PaymentTypeId { get; set; }
        [MaxLength(50)]
        public string InvoiceNumber { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal OutstandingAmount { get; set; }
        [MaxLength(50)]
        public string Sequence { get; set; }
        [MaxLength(50)]
        public string CheckbookNumber { get; set; }
        public long? SellerId { get; set; }

        [MaxLength(200)]
        public string Details { get; set; }

        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }
        [ForeignKey("SellerId")]
        public Seller Seller { get; set; }
        [ForeignKey("InvoiceCurrencyId")]
        public Currency InvoiceCurrency { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [NotMapped]
        public decimal CurrentOutstandingAmount { get; set; }


        [NotMapped]
        public string Name { get; set; }

     [NotMapped]
        public string PaymentTypeName { get; set; }



    }
}
