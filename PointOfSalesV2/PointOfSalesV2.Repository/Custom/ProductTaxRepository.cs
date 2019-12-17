using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class ProductTaxRepository : Repository<ProductTax>, IProductTaxRepository
    {
        public ProductTaxRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<ProductTax> GetProductTaxes(long productId)
        {
            throw new NotImplementedException();
        }
    }
}
