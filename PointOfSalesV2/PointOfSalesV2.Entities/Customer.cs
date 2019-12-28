using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class Customer : CommonData
    {

        [MaxLength(20)]
        public string CardId { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        public long CurrencyId { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Code { get; set; }
        public long InvoiceDueDays { get; set; }

        public decimal BillingAmountLimit { get; set; }
        public decimal CreditAmountLimit { get; set; }
        public long? AssignedWarehouseId { get; set; }
        public long? ZoneId { get; set; }


        [MaxLength(100)]
        public string Name { get; set; }

        [NotMapped]
        public string NameAndCode { get { return $"{Code ?? ""}  {Name}"; } }



        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

        [ForeignKey("AssignedWarehouseId")]
        public Warehouse Warehouse { get; set; }

        [ForeignKey("ZoneId")]
        public Zone Zone { get; set; }



        //Tax receipt number -> NCF
        [MaxLength(50)]
        public string TRNType { get; set; }


        [ForeignKey("TRNControlId")]
        public TRNControl TRNControl { get; set; }

    }
}
