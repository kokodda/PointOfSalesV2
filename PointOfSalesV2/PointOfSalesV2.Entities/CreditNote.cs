using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class CreditNote : CommonData
    {


        [MaxLength(50)]
        public string OriginInvoiceNumber { get; set; }
        [MaxLength(50)]
        public string AppliedInvoiceNumber { get; set; }
        [MaxLength(50)]
        public string Sequence { get; set; }
        public decimal Amount { get; set; }

        public long CurrencyId { get; set; }

        public bool Applied { get; set; }
        [NotMapped]
        public override string TranslationData { get; set; }

        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

       
    }
}
