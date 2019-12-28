using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class UnitProductEquivalenceRepository : Repository<UnitProductEquivalence>, IUnitProductEquivalenceRepository
    {
        public UnitProductEquivalenceRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<UnitProductEquivalence> GetProductUnits(long productId)
        {
            throw new NotImplementedException();
        }
    }
}
