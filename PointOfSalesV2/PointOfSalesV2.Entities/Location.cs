using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Location : CommonData
    {
        public decimal Percentage { get; set; }
        public string Name { get; set; }



    }
}
