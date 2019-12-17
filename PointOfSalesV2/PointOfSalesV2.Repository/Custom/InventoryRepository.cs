using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class InventoryRepository : Repository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<Inventory> GetLocationInventory(long locationId, long? productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inventory> GetProductInventory(long productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inventory> GetWarehouseInventory(long warehouseId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inventory> GetWarehouseInventoryByProduct(long warehouseId, long productId)
        {
            throw new NotImplementedException();
        }
    }
}
