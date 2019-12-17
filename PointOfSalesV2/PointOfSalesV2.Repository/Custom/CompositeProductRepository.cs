using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class CompositeProductRepository : Repository<CompositeProduct>, ICompositeProductRepository
    {
        public CompositeProductRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<CompositeProduct> GetDerivedProducts(long productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CompositeProduct> GetProductBases(long productId)
        {
            throw new NotImplementedException();
        }
    }
}
