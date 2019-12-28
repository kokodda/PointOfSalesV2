using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class InventoryEntryRepository : Repository<InventoryEntry>, IInventoryEntryRepository
    {
        public InventoryEntryRepository(MainDataContext context) : base(context)
        {
        }
    }
}
