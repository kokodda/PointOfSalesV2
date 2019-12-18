using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers
{
  public  class InvoiceDetailsHelper
    {
        public static void AddDetails(Invoice Invoice, IInvoiceDetailRepository invoiceDetailRepo, IProductRepository productRepository, 
            IInventoryRepository inventoryRepo, IInvoiceTaxRepository invoiceTaxRepository, IProductTaxRepository productTaxRepository, bool updateTaxes = true)
        {
    

            Invoice.InvoiceDetails.ForEach(x =>
            {
                x.InvoiceId = Invoice.Id;
                x.CreatedDate = DateTime.Now;
                x.CreatedBy = Invoice.CreatedBy;
                x.Active = true;
                x.Date = DateTime.Now;
                x.ModifiedDate = DateTime.Now;
                x = InventarioEnAlmacenHelper.ActualizarProductoEnAlmacen(Invoice.BranchOffice, x, productRepository, inventoryRepo,
                    invoiceDetailRepo, Invoice);
                if (x.SaveRegister)
                    invoiceDetailRepo.Add(x);
            });
            if (updateTaxes)
                UpdateInvoiceTaxes(Invoice, invoiceTaxRepository, productTaxRepository);

        }

        static void UpdateInvoiceTaxes(Invoice invoice, IInvoiceTaxRepository invoiceTaxRepo,
    IProductTaxRepository productTaxRepository)
        {
            var invoiceTaxes = invoiceTaxRepo.GetInvoiceTaxes(invoice.InvoiceNumber).ToList();
            if (invoiceTaxes != null && invoiceTaxes.Count > 0)
            {
                foreach (var tax in invoiceTaxes)
                {
                    invoiceTaxRepo.Remove(tax.Id);
                }
            }
            Dictionary<long, decimal> amountPerTax = new Dictionary<long, decimal>();
            invoice.InvoiceDetails.ForEach(x =>
            {
                x.InvoiceId = invoice.Id;

                var productTaxes = x.Product?.Taxes != null && x.Product?.Taxes.Count > 0 ? x.Product.Taxes :
                productTaxRepository.GetProductTaxes(x.ProductId);
                foreach (var impuesto in productTaxes)
                {
                    if (amountPerTax.Any(i => i.Key == impuesto.TaxId))
                    {
                        amountPerTax[impuesto.TaxId] += impuesto.Tax.Rate * x.BeforeTaxesAmount;
                    }
                    else
                        amountPerTax.Add(impuesto.TaxId, impuesto.Tax.Rate * x.BeforeTaxesAmount);
                }
            });

            foreach (var invoiceTaxAmount in amountPerTax)
            {
                InvoiceTax InvoiceImpuesto = new InvoiceTax()
                {
                    CreatedBy = invoice.CreatedBy,
                    Active = true,
                    InvoiceId = invoice.Id,
                    CreatedDate = DateTime.Now,
                    TaxId = invoiceTaxAmount.Key,
                    CurrencyId = invoice.CurrencyId,
                    TaxAmount = invoiceTaxAmount.Value,
                    InvoiceNumber = string.IsNullOrEmpty(invoice.InvoiceNumber) ? invoice.DocumentNumber : invoice.InvoiceNumber,

                };
                invoiceTaxRepo.Add(InvoiceImpuesto);
            }
        }

    }
}
