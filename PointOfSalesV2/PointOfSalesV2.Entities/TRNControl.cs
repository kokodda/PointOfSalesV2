using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class TRNControl : CommonData
    {
        public string Series { get; set; }
        
        public string Type { get; set; }
        public long Sequence { get; set; }
        public long NumericControl { get; set; }
        public long Quantity { get; set; }

        public string Name { get; set; }

    }
}
