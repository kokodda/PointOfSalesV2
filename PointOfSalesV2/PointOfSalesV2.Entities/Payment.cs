using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Payment : CommonData
    {
        public Payment() { }

        public Payment(int CustomerId, int CurrencyId, int InvoiceCurrencyId, int PaymentTypeId, decimal TotalAmount, decimal PaidAmount, string InvoiceNumber, decimal ExchangeRate, decimal OwedAmount,
            string Sequence, string Details, DateTime CreatedDate, Guid CreatedBy, bool Active, decimal CurrentOwedAmount, string ReceiptNumber, decimal SellerPercentage = 0, int? SellerId = null)
        {
            this.Active = Active;
            this.CustomerId = CustomerId;
            this.CreatedBy = CreatedBy;
            this.Details = Details;
            this.CreatedDate = CreatedDate;
            this.InvoiceCurrencyId = InvoiceCurrencyId;
            this.CurrencyId = CurrencyId;
            this.PaidAmount = PaidAmount;
            this.OwedAmount = OwedAmount;
            this.TotalAmount = TotalAmount;
            this.InvoiceNumber = InvoiceNumber;
            this.Sequence = Sequence;
            this.ExchangeRate = ExchangeRate;
            this.PaymentTypeId = PaymentTypeId;
            this.CurrentOwedAmount = CurrentOwedAmount;
            this.ReceiptNumber = ReceiptNumber;
            this.SellerPercentage = SellerPercentage;
            this.SellerId = SellerId;
        }
        public int CustomerId { get; set; }
        [NotMapped]
        public int DaysCount
        {
            get
            {
                return Convert.ToInt32((DateTime.Now - this.CreatedDate).TotalDays);
            }
        }


        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal SellerPercentage { get; set; } = 0;
        public int CurrencyId { get; set; }
        public int InvoiceCurrencyId { get; set; }

        public int PaymentTypeId { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal OwedAmount { get; set; }
        public string Sequence { get; set; }
        public string ReceiptNumber { get; set; }
        public int? SellerId { get; set; }





       
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
        public decimal CurrentOwedAmount { get; set; }


      
    }
}
