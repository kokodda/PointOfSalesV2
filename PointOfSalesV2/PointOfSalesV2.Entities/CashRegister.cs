using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class CashRegister : CommonData
    {


        public long LocationId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        [ForeignKey("LocationId")]
        public Location Location { get; set; }

    }
}
