using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Currency : CommonData
    {
        public string Code { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool IsLocalCurrency { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public bool TasaActualizada { get; set; }

    }
}
