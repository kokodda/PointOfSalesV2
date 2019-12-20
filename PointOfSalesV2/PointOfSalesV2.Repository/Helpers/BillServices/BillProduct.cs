using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers.BillServices
{
    public class BillProduct : BillProductServiceBase
    {
        protected override Result<InvoiceDetail> ProcessDetail(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory dataRepositoryFactory, Invoice invoice)
        {
            var inventoriesRepo = dataRepositoryFactory.GetDataRepositories<Inventory>();
            var warehouseRepo = dataRepositoryFactory.GetDataRepositories<Warehouse>();
            var productUnitsRepo = dataRepositoryFactory.GetDataRepositories<UnitProductEquivalence>();
            InvoiceDetail newDetail = new InvoiceDetail(detail);
            detail.Product.ProductUnits = detail.Product.ProductUnits == null || detail.Product.ProductUnits.Count == 0 ?
                    productUnitsRepo.GetAll(x=>x.Where(y=>y.Active==true && y.ProductId==detail.ProductId)).Data.ToList() : detail.Product.ProductUnits;
            var convertionResult = ProductsHelper.ConvertToProductPrincipalUnit(
newDetail.Quantity,
newDetail.UnitId.Value,
newDetail.Product.ProductUnits
);

            if (convertionResult.Status < 0)
                return new Result<InvoiceDetail>(-1,-1,convertionResult.Message);

            decimal warehouseQuantity = (decimal)convertionResult.Data.FirstOrDefault();
            decimal quantitySumm = warehouseQuantity;

            InvoiceDetail newDetailCustom = new InvoiceDetail(newDetail)
            {

               Quantity = warehouseQuantity
            };
            Warehouse warehouse = null;
            if ((invoice.WarehouseId <= 0))
            {
                var branchOfficeWarehouses = warehouseRepo.GetAll(x => x.Where(y => y.Active == true && y.BranchOfficeId == branchOfficeId
                && y.Code.ToLower() != "DEF")).Data.ToList();
                // ojo ojo ojo
                var productInventory = inventoriesRepo.Get(x => x.Where(y => y.Active == true && y.ProductId == newDetail.ProductId &&
                y.Quantity >= warehouseQuantity && branchOfficeWarehouses.Select(r => r.Id).ToList().Contains(y.WarehouseId)));

                if (productInventory == null)
                    return new Result<InvoiceDetail>(-1, -1, "outOfStock_msg");
                // ojo ojo ojo

                warehouse = branchOfficeWarehouses.FirstOrDefault(x => x.Id == productInventory.WarehouseId);
            }
            else
            {
                warehouse = warehouseRepo.Get(invoice.WarehouseId).Data.FirstOrDefault();
            }
          

            if ((invoice.WarehouseId > 0) && (inventoriesRepo.Get(x => x.Where(y => y.Active == true && y.ProductId == newDetail.ProductId && 
            y.Quantity >= warehouseQuantity && y.WarehouseId==invoice.WarehouseId))==null))
                return new Result<InvoiceDetail>(-1, -1, $"outOfStock_msg | {detail.Product?.Name?? ""}");

            if (warehouse == null)
            {
                var branchOfficeWarehouses = warehouseRepo.GetAll(x => x.Where(y => y.Active == true && y.BranchOfficeId == branchOfficeId
                              && y.Code.ToLower() != "DEF")).Data.ToList();
                // ojo ojo ojo
                var branchOfficeInventory = inventoriesRepo.GetAll(x => x.Where(y => y.Active == true && y.ProductId == newDetail.ProductId &&
                y.Quantity >0 && branchOfficeWarehouses.Select(r => r.Id).ToList().Contains(y.WarehouseId))).Data.ToList();

                if (branchOfficeInventory == null)
                    return new Result<InvoiceDetail>(-1, -1, $"outOfStock_msg | {newDetail.Product.Name}");


                convertionResult = ProductsHelper.ConvertToProductPrincipalUnit(
 branchOfficeInventory.Sum(p => p.Quantity),
 branchOfficeInventory.FirstOrDefault().UnitId,
 newDetail.Product.ProductUnits
 );
                if (convertionResult.Status < 0)
                    return new Result<InvoiceDetail>(-1, -1, convertionResult.Message);

                decimal warehousesQuantitySumm =(decimal) convertionResult.Data.FirstOrDefault() ;

                if (warehousesQuantitySumm < warehouseQuantity)
                    return new Result<InvoiceDetail>(-1, -1, $"outOfStock_msg | {newDetail.Product.Name}");

                foreach (Inventory warehouseProduct in branchOfficeInventory)
                {
                    if (quantitySumm <= 0)
                        break;
                    decimal currentWarehouseQuantity = warehouseProduct.Quantity;
                    if (quantitySumm < currentWarehouseQuantity)
                        currentWarehouseQuantity = quantitySumm;

                    newDetailCustom = new InvoiceDetail(newDetail);
                    newDetailCustom.Quantity =(decimal) ProductsHelper.ConvertFromProductPrincipalUnit(
 currentWarehouseQuantity,
 newDetail.UnitId.Value,
 newDetail.Product.ProductUnits
 ).Data.FirstOrDefault();

                    newDetailCustom.WarehouseId = warehouseProduct.WarehouseId;
                    //  newDetailCustom.UnitId = newDetailCustom.Product.ProductUnits.FirstOrDefault(x => x.EsPrincipal).UnitId;
                    InventoryHelper.UpdateInventory(newDetailCustom,  warehouseRepo.Get(warehouseProduct.WarehouseId).Data.FirstOrDefault(), invoice,dataRepositoryFactory);
                    newDetail.WarehouseId = warehouseProduct.WarehouseId;

                    quantitySumm -= currentWarehouseQuantity;
                }


            }
            else
            {
                newDetail.WarehouseId = warehouse.Id;
                newDetailCustom.Unit = newDetailCustom.Product.ProductUnits.FirstOrDefault(x => x.IsPrimary).Unit;
                newDetailCustom.UnitId = newDetailCustom.Unit.Id;
                InventoryHelper.UpdateInventory(newDetailCustom, warehouse, invoice,dataRepositoryFactory);

            }

            return newDetail;
        }

        protected override Result<InvoiceDetail> ProcessReturnDetail(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory dataRepositoryFactory, Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
