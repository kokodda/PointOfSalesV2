using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class SupplierReturnRepository : Repository<SupplierReturn>, ISupplierReturnRepository
    {
        public SupplierReturnRepository(MainDataContext context) : base(context)
        {
        }
    }
}
