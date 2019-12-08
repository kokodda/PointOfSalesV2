using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class OpeningAmount : CommonData
    {

        public decimal Amount { get; set; }
        public long Order { get; set; }

    }
}
