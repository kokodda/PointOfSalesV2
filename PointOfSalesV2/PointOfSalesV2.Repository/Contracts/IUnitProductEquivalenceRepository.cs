using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IUnitProductEquivalenceRepository : IBase<UnitProductEquivalence>
    {
        IEnumerable<UnitProductEquivalence> GetProductUnits(long productId);
    }
}
