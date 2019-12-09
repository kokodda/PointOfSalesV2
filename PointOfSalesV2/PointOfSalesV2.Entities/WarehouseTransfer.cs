using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class WarehouseTransfer : CommonData
    {


        public long OrigingId { get; set; }
        public long DestinyId { get; set; }
        public long ProductId { get; set; }
        public decimal Quantity { get; set; }
        public string Reference { get; set; }



        public long UnitId { get; set; }




        [ForeignKey("OriginId")]
        public Warehouse Origin { get; set; }


        [ForeignKey("DestinyId")]
        public Warehouse Destiny { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }




    }
}
