using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{ 
    public class LocationProduts

    {


        public long LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location Location { get; set; }
        public List<WarehouseProduct> ProductsByWarehouse { get; set; }

    }
}
