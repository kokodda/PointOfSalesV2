﻿using PointOfSalesV2.Entities;
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
                    //  newDetailCustom.UnitId = newDetailCustom.Product.ProductUnits.FirstOrDefault(x => x.IsPrimary).UnitId;
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

             return new Result<InvoiceDetail>(0, 0, "ok_msg", new List<InvoiceDetail>() { newDetail }) ;
        }

        protected override Result<InvoiceDetail> ProcessReturnDetail(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory dataRepositoryFactory, Invoice invoice)
        {
            Inventory currentInventory = null;
            var warehouseRepo = dataRepositoryFactory.GetDataRepositories<Warehouse>();
            var productRepo = dataRepositoryFactory.GetDataRepositories<Product>();
           var inventoryRepo= dataRepositoryFactory.GetDataRepositories<Inventory>();
           var productUnitsRepo= dataRepositoryFactory.GetDataRepositories<UnitProductEquivalence>();
           var logMovementsRepo= dataRepositoryFactory.GetDataRepositories<WarehouseMovement>();

            if (detail.WarehouseId.HasValue)
            {
                detail.Product.ProductUnits = detail.Product.ProductUnits == null || detail.Product.ProductUnits.Count == 0 ?
                    productUnitsRepo.GetAll(x=>x.Where(y=>y.Active==true && y.ProductId==detail.ProductId)).Data.ToList() : detail.Product.ProductUnits;

                if (detail.Defective)
                {
                    var defectiveWarehouse = warehouseRepo.Get(x => x.Where(y => y.Active == true && y.Code == "DEF" && y.BranchOfficeId == branchOfficeId));
                    if (defectiveWarehouse == null)
                        return new Result<InvoiceDetail>(-1, -1, $"defWarehouseNotExit_msg");

                    currentInventory = inventoryRepo.Get(x=>x.Where(y=>y.Active==true && y.BranchOfficeId==branchOfficeId && y.ProductId==detail.ProductId &&
                    y.WarehouseId== defectiveWarehouse.Id)) ??
                new Inventory()
                {
                    WarehouseId = defectiveWarehouse.Id,
                    ProductId = detail.ProductId,
                    Active = true,
                    Quantity = 0,
                    CreatedBy = detail.CreatedBy,
                    CreatedDate = DateTime.Now,
                    BranchOfficeId = branchOfficeId,
                    UnitId = detail.Product.ProductUnits.FirstOrDefault(u => u.IsPrimary).UnitId,
                    Product = detail.Product
                };
                }
                else
                {
                    currentInventory = inventoryRepo.Get(x => x.Where(y => y.Active == true && y.ProductId == detail.ProductId && y.WarehouseId == detail.WarehouseId));
                   
                }
                if (currentInventory != null)
                {
                    currentInventory.Product.ProductUnits = currentInventory.Product.ProductUnits == null || currentInventory.Product.ProductUnits.Count == 0 ?
                    productUnitsRepo.GetAll(x=>x.Where(y=>y.Active==true && y.ProductId==currentInventory.ProductId)).Data.ToList(): currentInventory.Product.ProductUnits;

                    currentInventory.Quantity =(decimal) ProductsHelper.ConvertToProductPrincipalUnit(
         currentInventory.Quantity,
         detail.Product.ProductUnits.FirstOrDefault(pu => pu.IsPrimary).UnitId,
         detail.Product.ProductUnits
         ).Data.FirstOrDefault();
                    detail.Quantity =(decimal) ProductsHelper.ConvertToProductPrincipalUnit(
           detail.Quantity,
           detail.UnitId.Value,
           detail.Product.ProductUnits
           ).Data.FirstOrDefault();
                    var units = detail.Product.ProductUnits == null || detail.Product.ProductUnits.Count == 0 ?
                    productUnitsRepo.GetAll(x => x.Where(y => y.Active == true && y.ProductId == detail.ProductId)).Data.ToList() : detail.Product.ProductUnits;

                    var warehouseMov = new WarehouseMovement(currentInventory.WarehouseId, detail.ProductId, detail.Quantity,true, 
                        units.Where(u => u.IsPrimary).FirstOrDefault().UnitId, branchOfficeId, "IN", invoice.InvoiceNumber??invoice.DocumentNumber ?? string.Empty);
                    logMovementsRepo.Add(warehouseMov);

                    currentInventory.Quantity += detail.Quantity;
                    currentInventory.UnitId = currentInventory.Product.ProductUnits.FirstOrDefault(x => x.IsPrimary).UnitId;
                    Product Product = productRepo.Get(detail.ProductId).Data.FirstOrDefault();
                    Product.Existence += detail.Quantity;
                    productRepo.Update(Product);
                    if (currentInventory.Id > 0)
                       inventoryRepo.Update(currentInventory);
                    else
                        inventoryRepo.Add(currentInventory);
                }
                else
                    return new Result<InvoiceDetail>(-1,-1, "outOfStock_msg");

            }

            return new Result<InvoiceDetail>(0, 0, "ok_msg", new List<InvoiceDetail>() { detail });
        }
    }
}
