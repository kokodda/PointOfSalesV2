using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Invoice : CommonData
    {

        public Invoice() { }

        public Invoice(Invoice nuevaInvoice)
        {
            this.Id = nuevaInvoice.Id;
            this.Active = nuevaInvoice.Active;
            this.Customer = nuevaInvoice.Customer ?? null;
            this.CustomerId = nuevaInvoice.CustomerId;
            this.CreatedBy = nuevaInvoice.CreatedBy;
            this.Details = nuevaInvoice.Details ?? null;
            this.InvoiceDetails = nuevaInvoice.InvoiceDetails ?? new List<InvoiceDetail>();
            this.State = nuevaInvoice.State;
            this.CreatedDate = nuevaInvoice.CreatedDate;
            this.BillingDate = nuevaInvoice.BillingDate;
            this.ModifiedDate = nuevaInvoice.ModifiedDate;
            this.Location = nuevaInvoice.Location ?? null;
            this.LocationId = nuevaInvoice.LocationId;
            this.ModifiedBy = nuevaInvoice.ModifiedBy ;
            this.Currency = nuevaInvoice.Currency ?? null;
            this.CurrencyId = nuevaInvoice.CurrencyId;
            this.OwedAmount = nuevaInvoice.OwedAmount;
            this.ReturnedAmount = nuevaInvoice.ReturnedAmount;
            this.BeforeTaxesAmount = nuevaInvoice.BeforeTaxesAmount;
            this.TaxesAmount = nuevaInvoice.TaxesAmount;
            this.PaidAmount = nuevaInvoice.PaidAmount;
            this.ReceivedAmount = nuevaInvoice.ReceivedAmount;
            this.TotalAmount = nuevaInvoice.TotalAmount;
            this.InvoiceNumber = nuevaInvoice.InvoiceNumber ?? null;
            this.Payments = nuevaInvoice.Payments ?? null;
            this.DiscountAmount = nuevaInvoice.DiscountAmount;
            this.AppliedCreditNoteAmount = nuevaInvoice.AppliedCreditNoteAmount;
            this.Details = nuevaInvoice.Details;
            this.DiscountRate = nuevaInvoice.DiscountRate;
            this.TRN = nuevaInvoice.TRN;
            this.TRNType = nuevaInvoice.TRNType;
            this.TNRControl = nuevaInvoice.TNRControl ?? null;
            this.WarehouseId = nuevaInvoice.WarehouseId;
            this.NRC = nuevaInvoice.NRC;
            this.DocumentNumber = nuevaInvoice.DocumentNumber ?? null;
            this.CajaId = nuevaInvoice.CajaId ?? null;
            this.SellerRate = nuevaInvoice.SellerRate;
            this.SellerId = nuevaInvoice.SellerId ?? null;
            this.ZoneId = nuevaInvoice.ZoneId;
            this.Cost = nuevaInvoice.Cost;
        }

        public long CustomerId { get; set; }

        public long ZoneId { get; set; }
        public string DocumentNumber { get; set; }
        public decimal DiscountRate { get; set; }
        public long? SellerId { get; set; }

        public long WarehouseId { get; set; }
        public decimal SellerRate { get; set; } = 0;
        public long? CajaId { get; set; }



        public decimal ReturnedAmount { get; set; }

        public decimal ReceivedAmount { get; set; }
        public decimal Cost { get; set; }


        public decimal OwedAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal AppliedCreditNoteAmount { get; set; }

        public string NRC { get; set; }


        public long LocationId { get; set; }

        public string InvoiceNumber { get; set; }
        public long CurrencyId { get; set; }
        public decimal TotalAmount { get; set; }
        public string TRN { get; set; }
        public string TRNType { get; set; }
        public decimal PaidAmount { get; set; }

        public char State { get; set; }
        public DateTime? BillingDate { get; set; }
        public decimal TaxesAmount { get; set; }


        public string Details { get; set; }

        public decimal BeforeTaxesAmount { get; set; }


        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }
        [ForeignKey("SellerId")]
        public Seller Seller { get; set; }
        [ForeignKey("ZoneId")]
        public Zone Zone { get; set; }
        [ForeignKey("TRNType")]
        public TNRControl TNRControl { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [ForeignKey("LocationId")]
        public BranchOffice Location { get; set; }
     
        public virtual  List<Payment> Payments { get; set; }

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
        public string NotaCreditoAplicada { get; set; }








    }
}
