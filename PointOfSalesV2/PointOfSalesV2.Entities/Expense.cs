using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Expense : CommonData
    {


        public Expense() { }
        public Expense(Expense obj)
        {
            this.Active = obj.Active;
            this.CreatedBy = obj.CreatedBy;
            this.Details = obj.Details;
            this.State = obj.State;
            this.CreatedDate = obj.CreatedDate;
            this.Date = obj.Date;
            this.ModifiedDate = obj.ModifiedDate;
            this.Id = obj.Id;
            this.Location = obj.Location ?? null;
            this.LocationId = obj.LocationId;
            this.ModifiedBy = obj.ModifiedBy;
            this.Currency = obj.Currency ?? null;
            this.CurrencyId = obj.CurrencyId;
            this.OwedAmount = obj.OwedAmount;
            this.GivenAmount = obj.GivenAmount;
            this.ReturnedAmount = obj.ReturnedAmount;
            this.BeforeTaxesAmount = obj.BeforeTaxesAmount;
            this.TaxesAmount = obj.TaxesAmount;
            this.PaidAmount = obj.PaidAmount;
            this.TotalAmount = obj.TotalAmount;
            this.TRN = obj.TRN;
            this.Name = obj.Name;
            this.ExpenseReference = obj.ExpenseReference;
            this.Supplier = obj.Supplier ?? null;
            this.SupplierId = obj.SupplierId;
            this.PaymentTypeId = obj.PaymentTypeId;

        }
     
        public long PaymentTypeId { get; set; }
        [NotMapped]
        public string Name { get; set; }
        
        public string Details { get; set; }

      
        public List<ExpenseTax> Taxes { get; set; }

        public long SupplierId { get; set; }
        public string ExpenseReference { get; set; }
        public long CurrencyId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public char State { get; set; }
        public DateTime Date { get; set; }
        public decimal TaxesAmount { get; set; }
        public decimal BeforeTaxesAmount { get; set; }
        public decimal ReturnedAmount { get; set; }
        public decimal GivenAmount { get; set; }
        public decimal OwedAmount { get; set; }
        public long LocationId { get; set; }
        public string TRN { get; set; }

        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

        [NotMapped]
        public long NumberOfDays
        {
            get
            {
                if (this.Date.Year > DateTime.MinValue.Year)
                    return Convert.ToInt32((DateTime.Now - this.Date).TotalDays);
                else
                    return 0;
            }
        }

        [ForeignKey("LocationId")]
        public BranchOffice Location { get; set; }

    }
}
