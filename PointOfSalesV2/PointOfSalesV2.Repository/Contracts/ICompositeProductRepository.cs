using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface ICompositeProductRepository: IBase<CompositeProduct>
    {
        IEnumerable<CompositeProduct> GetDerivedProducts(long productId);
        IEnumerable<CompositeProduct> GetProductBases(long productId);
    }
}
