using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class WarehouseTransferRepository : Repository<WarehouseTransfer>, IWarehouseTransferRepository
    {
        public WarehouseTransferRepository(MainDataContext context) : base(context)
        {
        }
    }
}
