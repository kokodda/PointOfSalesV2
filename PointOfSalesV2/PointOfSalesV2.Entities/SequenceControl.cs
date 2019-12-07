using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class SequenceControl : CommonData
    {
        public string Code { get; set; }
        public int NumericControl { get; set; }

        public string Name { get; set; }

    }
}
