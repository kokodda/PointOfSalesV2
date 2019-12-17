using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class WarehouseMovementRepository : Repository<WarehouseMovement>, IWarehouseMovementRepository
    {
        public WarehouseMovementRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<WarehouseMovement> GetMovementsByProduct(long? productId, long? warehouseId, DateTime? initialDate, DateTime? endDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WarehouseMovement> GetProductHistory(long? productId)
        {
            throw new NotImplementedException();
        }
    }
}
