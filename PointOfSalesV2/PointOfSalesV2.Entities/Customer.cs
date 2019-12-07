using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace PointOfSalesV2.Entities
{
    public class Customer : CommonData
    {

        public string CardId { get; set; }
        public string PhoneNumber { get; set; }

        public int CurrencyId { get; set; }

        public string Address { get; set; }
        public string Code { get; set; }
        public int InvoiceDueDays { get; set; }

        public decimal BillingAmountLimit { get; set; }
        public decimal CreditAmountLimit { get; set; }
        public int? AssignedWarehouseId { get; set; }
        public int? ZoneId { get; set; }


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
        public string TRNType { get; set; }


        [ForeignKey("TRNControlId")]
        public TRNControl TRNControl { get; set; }

    }
}
