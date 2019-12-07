using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class CustomerBalance : CommonData
    {

        public long ClientId { get; set; }

        public long CurrencyId { get; set; }

        public decimal OwedAmount { get; set; }

        [ForeignKey("ClientId")]
        public Customer Client { get; set; }


        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }




    }
}
