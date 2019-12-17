using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IInventoryRepository: IBase<Inventory>
    {
        IEnumerable<Inventory> GetWarehouseInventoryByProduct(long warehouseId,long productId);
        IEnumerable<Inventory> GetWarehouseInventory(long warehouseId);
        IEnumerable<Inventory> GetProductInventory(long productId);
        IEnumerable<Inventory> GetBranchOfficeInventory(long branchOfficeId, long? productId);
    }
}
