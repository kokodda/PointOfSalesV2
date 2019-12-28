using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<Product> GetFilteredAndLimited(int pageZise, string fieldName, string fieldName2, string searchCharacters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsOnlyFilteredAndLimited(int pageZise, string name, string searchCharacters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsOnlyFilteredAndLimited(int pageZise, string fieldName1, string fieldName2, string searchCharacters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetServicesOnlyFilteredAndLimited(int pageZise, string fieldName, string searchCharacters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetServicesOnlyFilteredAndLimited(int pageZise, string fieldName, string fieldName2, string searchCharacters)
        {
            throw new NotImplementedException();
        }
    }
}
