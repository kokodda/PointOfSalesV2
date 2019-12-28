using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IWarehouseMovementRepository : IBase<WarehouseMovement>
    {
        IEnumerable<WarehouseMovement> GetMovementsByProduct(long? productId, long? warehouseId, DateTime? initialDate, DateTime? endDate);
        IEnumerable<WarehouseMovement> GetProductHistory(long? productId);
    }
}
