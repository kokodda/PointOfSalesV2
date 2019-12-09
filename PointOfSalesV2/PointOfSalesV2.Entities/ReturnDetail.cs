using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class ReturnDetail : CommonData
    {
        public ReturnDetail() { }

        public ReturnDetail(ReturnDetail newDetail)
        {
            this.Id = newDetail.Id;
           
        }



        public bool Equals(InvoiceDetail other)
        {
            return (this.Id == other.Id && this.ProductId == other.ProductId && this.Quantity == other.Quantity && this.Amount == other.Amount && this.Cost == other.Cost &&
                this.UnitId == other.UnitId && this.TaxesAmount == other.TaxesAmount && this.BeforeTaxesAmount == other.BeforeTaxesAmount && this.TotalAmount == other.TotalAmount &&
                this.InvoiceId == other.InvoiceId && this.CreditNoteAmount == other.CreditNoteAmount && this.DiscountAmount == other.DiscountAmount && this.DiscountRate == other.DiscountRate
                && this.Free == other.Free && this.ParentId == other.ParentId && this.WarehouseId == other.WarehouseId &&
                this.Active == other.Active && this.Date == other.Date && this.CreatedDate == other.CreatedDate);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ this.Id;

                hashCode = (hashCode * 397) ^ this.ProductId;
                hashCode = (hashCode * 397) ^ this.InvoiceId;



                hashCode = this.UnitId.HasValue ? (hashCode * 397) ^ this.UnitId.Value : hashCode;
                hashCode = this.ParentId.HasValue ? (hashCode * 397) ^ this.ParentId.Value : hashCode;
                hashCode = this.WarehouseId.HasValue ? (hashCode * 397) ^ this.WarehouseId.Value : hashCode;
                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.Active);

                var hashCodeDecimal = this.Quantity.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal;

                var hashCodeDecimal2 = this.Amount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal2;

                var hashCodeDecimal3 = this.BeforeTaxesAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal3;

                var hashCodeDecimal4 = this.TaxesAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal4;

                var hashCodeDecimal5 = this.TotalAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal5;

                var hashCodeDecimal6 = this.DiscountAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal6;

                var hashCodeDecimal7 = this.CreditNoteAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal7;

                var hashCodeDecimal8 = this.DiscountRate.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal8;

                var hashCodeDecimal9 = this.Cost.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal9;

                return Convert.ToInt32( hashCode);
            }
        }


        

    }

}

