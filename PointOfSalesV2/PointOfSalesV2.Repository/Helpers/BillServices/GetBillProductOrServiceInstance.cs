using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers.BillServices
{
    public class GetBillProductOrServiceInstance
    {
        private static IBillProductsServices GetBillingClass(Product product)
        {
            string clase = ClassList.Where(x => x.IsComposite == product.IsCompositeProduct && x.IsService == product.IsService).FirstOrDefault()?.ClassName;

            if (string.IsNullOrEmpty(clase))
                throw new Exception("notExistingClass_msg.");

            Type serviceType = Type.GetType(clase);
            return (IBillProductsServices)Activator.CreateInstance(serviceType);

        }

        public static IBillProductsServices GetBillingInstance(Product product)
        {
            IBillProductsServices instance = GetBillingClass(product);
            return instance;
        }

        private class ProductServiceBillingClass
        {
            public bool IsComposite { get; set; }
            public bool IsService { get; set; }
            public string ClassName { get; set; }
        }

        private static List<ProductServiceBillingClass> ClassList = new List<ProductServiceBillingClass>()
        {
        new ProductServiceBillingClass()
        {
        ClassName=$"PointOfSalesV2.Repository.Helpers.BillServices.BillComplexService, PointOfSalesV2.Repository, culture=neutral , version=1.0.0.0",
        IsComposite=true,
        IsService=true
        },
        new ProductServiceBillingClass()
        {
         ClassName=$"PointOfSalesV2.Repository.Helpers.BillServices.BillService, PointOfSalesV2.Repository, culture=neutral , version=1.0.0.0",
        IsComposite=false,
        IsService=true
        },
        new ProductServiceBillingClass()
        {
        ClassName=$"PointOfSalesV2.Repository.Helpers.BillServices.BillProduct, PointOfSalesV2.Repository, culture=neutral , version=1.0.0.0",
        IsComposite=false,
        IsService=false,
        }
        };
    }
}
