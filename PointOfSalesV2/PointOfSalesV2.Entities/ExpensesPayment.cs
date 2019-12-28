using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class ExpensesPayment : CommonData
    {
        public ExpensesPayment() { }

        public ExpensesPayment(int SupplierId, int CurrencyId, int ExpenseCurrencyId, int PaymentTypeId, decimal TotalAmount, decimal PaidAmount, string ExpenseReference, decimal ExchangeRate, decimal OutstandingAmount,
            string Sequence, string Details, DateTime CreatedDate, Guid CreatedBy, bool Active, decimal CurrentOutstandingAmount)
        {
            this.Active = Active;
            this.SupplierId = SupplierId;
            this.CreatedBy = CreatedBy;
            this.Details = Details;
            this.CreatedDate = CreatedDate;
            this.ExpenseCurrencyId = ExpenseCurrencyId;
            this.CurrencyId = CurrencyId;
            this.PaidAmount = PaidAmount;
            this.OutstandingAmount = OutstandingAmount;
            this.TotalAmount = TotalAmount;
            this.ExpenseReference = ExpenseReference;
            this.Sequence = Sequence;
            this.ExchangeRate = ExchangeRate;
            this.PaymentTypeId = PaymentTypeId;
            this.CurrentOutstandingAmount = CurrentOutstandingAmount;
        }
        public long SupplierId { get; set; }


        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public long CurrencyId { get; set; }
        public long ExpenseCurrencyId { get; set; }

        public long PaymentTypeId { get; set; }
        [MaxLength(50)]
        public string ExpenseReference { get; set; }
        public decimal ExchangeRate { get; set; }
        [NotMapped]
        public override string TranslationData { get; set; }
        public decimal OutstandingAmount { get; set; }
        [MaxLength(50)]
        public string Sequence { get; set; }

        [MaxLength(200)]
        public string Details { get; set; }


        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

        [ForeignKey("ExpenseCurrencyId")]
        public Currency ExpenseCurrency { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

        [NotMapped]
        public decimal CurrentOutstandingAmount { get; set; }


        [NotMapped]
        public string Name { get; set; }


    }
}
