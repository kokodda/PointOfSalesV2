using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Inventory : CommonData
    {
        public long WarehouseId { get; set; }

        public long BranchOfficeId { get; set; }

        public long ProductId { get; set; }

        public decimal Quantity { get; set; }
        [NotMapped]
        public override string TranslationData { get; set; }

        public long UnitId { get; set; }

        [ForeignKey("WarehouseId")]
        public Warehouse Warehouse { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }

    }
}
