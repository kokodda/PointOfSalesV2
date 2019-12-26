using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PointOfSalesV2.Common;

namespace PointOfSalesV2.Entities
{
    public class Invoice : CommonData
    {

        public Invoice() { }

        public Invoice(Invoice newInvoice)
        {
            this.Id = newInvoice.Id;
            this.Active = newInvoice.Active;
            this.Customer = newInvoice.Customer ?? null;
            this.CustomerId = newInvoice.CustomerId;
            this.CreatedBy = newInvoice.CreatedBy;
            this.Details = newInvoice.Details ?? null;
            this.InvoiceDetails = newInvoice.InvoiceDetails ?? new List<InvoiceDetail>();
            this.State = newInvoice.State;
            this.CreatedDate = newInvoice.CreatedDate;
            this.BillingDate = newInvoice.BillingDate;
            this.ModifiedDate = newInvoice.ModifiedDate;
            this.BranchOffice = newInvoice.BranchOffice ?? null;
            this.BranchOfficeId = newInvoice.BranchOfficeId;
            this.ModifiedBy = newInvoice.ModifiedBy ;
            this.Currency = newInvoice.Currency ?? null;
            this.CurrencyId = newInvoice.CurrencyId;
            this.OwedAmount = newInvoice.OwedAmount;
            this.ReturnedAmount = newInvoice.ReturnedAmount;
            this.BeforeTaxesAmount = newInvoice.BeforeTaxesAmount;
            this.TaxesAmount = newInvoice.TaxesAmount;
            this.PaidAmount = newInvoice.PaidAmount;
            this.ReceivedAmount = newInvoice.ReceivedAmount;
            this.TotalAmount = newInvoice.TotalAmount;
            this.InvoiceNumber = newInvoice.InvoiceNumber ?? null;
            this.Payments = newInvoice.Payments ?? new List<Payment>();
            this.DiscountAmount = newInvoice.DiscountAmount;
            this.AppliedCreditNoteAmount = newInvoice.AppliedCreditNoteAmount;
            this.Details = newInvoice.Details;
            this.DiscountRate = newInvoice.DiscountRate;
            this.TRN = newInvoice.TRN;
            this.TRNType = newInvoice.TRNType;
            this.TNRControl = newInvoice.TNRControl ?? null;
            this.WarehouseId = newInvoice.WarehouseId;
            this.NRC = newInvoice.NRC;
            this.DocumentNumber = newInvoice.DocumentNumber ?? null;
            this.CashRegisterId = newInvoice.CashRegisterId ?? null;
            this.SellerRate = newInvoice.SellerRate;
            this.SellerId = newInvoice.SellerId ?? null;
            this.ZoneId = newInvoice.ZoneId;
            this.Cost = newInvoice.Cost;
            this.Seller = newInvoice.Seller ?? null;
            this.Zone = newInvoice.Zone ?? null;
            this.TRNControlId = newInvoice.TRNControlId;
            this.AppliedCreditNote = newInvoice.AppliedCreditNote;
            this.Taxes = newInvoice.Taxes ?? new List<InvoiceTax>();
        }

        public long CustomerId { get; set; }

        public long ZoneId { get; set; }
        [MaxLength(50)]
        public string DocumentNumber { get; set; }
        public decimal DiscountRate { get; set; }
        public long? SellerId { get; set; }

        public long WarehouseId { get; set; }
        public decimal SellerRate { get; set; } = 0;
        public long? CashRegisterId { get; set; }



        public decimal ReturnedAmount { get; set; }

        public decimal ReceivedAmount { get; set; }
        public decimal Cost { get; set; }


        public decimal OwedAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal AppliedCreditNoteAmount { get; set; }
        [MaxLength(100)]
        public string NRC { get; set; }


        public long BranchOfficeId { get; set; }
        [MaxLength(50)]
        public string InvoiceNumber { get; set; }
        public long CurrencyId { get; set; }
        public decimal TotalAmount { get; set; }
        [MaxLength(50)]
        public string TRN { get; set; }
        [MaxLength(2)]
        public string TRNType { get; set; }
        public long TRNControlId { get; set; }
        public decimal PaidAmount { get; set; }

        public char State { get; set; }
        public DateTime? BillingDate { get; set; }
        public decimal TaxesAmount { get; set; }

        [MaxLength(200)]
        public string Details { get; set; }

        public decimal BeforeTaxesAmount { get; set; }

        [NotMapped]
        public Enums.BillingStates BillingState 
        {
            get 
            {
                return  (Enums.BillingStates)this.State;
            }
        }


        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }
        [ForeignKey("SellerId")]
        public Seller Seller { get; set; }
        [ForeignKey("ZoneId")]
        public Zone Zone { get; set; }
        [ForeignKey("TRNControlId")]
        public TRNControl TNRControl { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [ForeignKey("BranchOfficeId")]
        public BranchOffice BranchOffice { get; set; }
     
        public virtual  List<CustomerPayment> Payments { get; set; }

        public virtual List<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual List<InvoiceTax> Taxes { get; set; }


        [NotMapped]
        public int DaysAmount
        {
            get
            {
                if (this.BillingDate.HasValue && this.BillingDate.Value.Year > DateTime.MinValue.Year)
                    return Convert.ToInt32((DateTime.Now - this.BillingDate.Value).TotalDays);
                else
                    return 0;
            }
        }

      [NotMapped]
        public string AppliedCreditNote { get; set; }








    }
}
