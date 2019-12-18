using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class WarehouseMovement : CommonData
    {

        public long WarehouseId { get; set; }
        public long LocationId { get; set; }
        public long ProductId { get; set; }
        public decimal Quantity { get; set; }





        public long UnitId { get; set; }

        public string MovementType { get; set; }
        [MaxLength(50)]
        public string Reference { get; set; }

        public decimal CurrentBalance { get; set; }


        public WarehouseMovement() { }

        public WarehouseMovement(int warehouseId, int productId, decimal quantity, Guid createdBy, bool active, int unitId, int locationId, string movType, string reference, decimal currentBalance = 0)
        {
            this.WarehouseId = warehouseId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = createdBy;
            this.Active = active;
            this.UnitId = unitId;
            this.LocationId = locationId;
            this.MovementType = movType;
            this.Reference = reference;
            this.CurrentBalance = currentBalance;
        }


        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("LocationId")]
        public BranchOffice Location { get; set; }
        [ForeignKey("WarehouseId")]
        public Warehouse Warehouse { get; set; }

        [NotMapped]
        public string WarehouseName { get; set; }
        [NotMapped]
        public string LocationName { get; set; }
        [NotMapped]
        public string Name { get; set; }

        [NotMapped]
        public string Details { get; set; }
        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }
       

    }
}
