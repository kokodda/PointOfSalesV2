using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers
{
 public   class InventoryHelper
    {
        public static void ActualizarInventarioEnAlmacen(InvoiceDetail detail, IProductRepository productRepository, 
            IInventoryRepository inventoryRepository, Warehouse currentWarehouse, Invoice invoice)
        {
            IProductosUnidadesService productoUnidades = new ProductoUnidadesService();
            IMovimientoAlmacenService logMovimientos = new MovimientoAlmacenService();
            AlmacenProducto existenciaActual = inventoryRepository.ObtenerExistenciaDeProductoEnAlmacen(detail.ProductoId, currentWarehouse.Id).FirstOrDefault();
            if (existenciaActual != null)
            {
                detail.Cantidad = PuntoDeVenta.DataAccess.Dto.Helpers.ProductosHelper.ConvertirAUnidadPrincipalProducto(
       detail.Cantidad,
       detail.UnidadId.Value,
      detail.Producto.ProductoUnidades
       );
                detail.UnidadId = detail.Producto.ProductoUnidades.FirstOrDefault(pu => pu.EsPrincipal).UnidadId;
                existenciaActual.Cantidad = PuntoDeVenta.DataAccess.Dto.Helpers.ProductosHelper.ConvertirAUnidadPrincipalProducto(
       existenciaActual.Cantidad,
       detail.Producto.ProductoUnidades.Where(pu => pu.EsPrincipal).FirstOrDefault().UnidadId,
      detail.Producto.ProductoUnidades
       );


                if (existenciaActual.Cantidad < detail.Cantidad)
                    throw new Exception($"Existencia insuficiente para el producto {detail.Producto.Nombre}. Solo existen {existenciaActual.Cantidad.ToString()} en el almacen {currentWarehouse.Nombre}. invoice cancelada.");
                else
                {
                    existenciaActual.Cantidad -= detail.Cantidad;
                    Producto producto = service.ObtenerPorId(detail.ProductoId);
                    producto.Existencia -= detail.Cantidad;
                    service.Actualizar(producto);
                    inventoryRepository.Actualizar(existenciaActual);


                    var unidades = detail.Producto.ProductoUnidades ?? productoUnidades.ObtenerUnidadesDeProducto(detail.ProductoId);
                    MovimientoAlmacen movimientoAlmacen = new MovimientoAlmacen(currentWarehouse.Id, detail.ProductoId, detail.Cantidad * -1, detail.CreadoPor ?? "system", true, unidades.Where(u => u.EsPrincipal).FirstOrDefault().UnidadId, 0, "OUT", invoice.Numeroinvoice ?? string.Empty);
                    logMovimientos.Insertar(movimientoAlmacen);


                }
            }
            else
                throw new Exception("No existe inventario de ese producto. No se puede invoicer");

        }


        public static void SumarInventarioAlAlmacen(InvoiceDetail detail, invoice invoice, IProductoService service = null, IinventoryRepository inventoryRepository = null)
        {
            IProductosUnidadesService productoUnidades = new ProductoUnidadesService();
            IMovimientoAlmacenService logMovimientos = new MovimientoAlmacenService();
            if (!detail.Producto.EsServicio)
            {
                detail.Producto.ProductoUnidades = detail.Producto.ProductoUnidades ?? productoUnidades.ObtenerUnidadesDeProducto(detail.ProductoId);
                IProductoService newService = service ?? new ProductoService();
                IinventoryRepository newinventoryRepository = inventoryRepository ?? new inventoryRepository();
                if (detail.AlmacenId.HasValue)
                {
                    AlmacenProducto existenciaActual = newinventoryRepository.ObtenerExistenciaDeProductoEnAlmacen(detail.ProductoId, detail.AlmacenId.Value).FirstOrDefault();
                    if (existenciaActual != null)
                    {

                        existenciaActual.Cantidad = PuntoDeVenta.DataAccess.Dto.Helpers.ProductosHelper.ConvertirAUnidadPrincipalProducto(
               existenciaActual.Cantidad,
               detail.Producto.ProductoUnidades.Where(pu => pu.EsPrincipal).FirstOrDefault().UnidadId,
               detail.Producto.ProductoUnidades
               );
                        detail.Cantidad = PuntoDeVenta.DataAccess.Dto.Helpers.ProductosHelper.ConvertirAUnidadPrincipalProducto(
               detail.Cantidad,
               detail.UnidadId.Value,
                detail.Producto.ProductoUnidades
               );
                        var unidades = detail.Producto.ProductoUnidades ?? productoUnidades.ObtenerUnidadesDeProducto(detail.ProductoId);
                        MovimientoAlmacen movimientoAlmacen = new MovimientoAlmacen(existenciaActual.AlmacenId, detail.ProductoId, detail.Cantidad, detail.CreadoPor ?? "system", true, unidades.Where(u => u.EsPrincipal).FirstOrDefault().UnidadId, 0, "IN", invoice.Numeroinvoice ?? string.Empty);
                        logMovimientos.Insertar(movimientoAlmacen);

                        existenciaActual.Cantidad += detail.Cantidad;
                        Producto producto = newService.ObtenerPorId(detail.ProductoId);
                        producto.Existencia += detail.Cantidad;
                        newService.Actualizar(producto);
                        newinventoryRepository.Actualizar(existenciaActual);

                    }
                    else
                        throw new Exception("No existe inventario de ese producto. No se puede invoicer");
                }
            }



        }


        public static void ReinsertarInventarioEnAlmacen(InvoiceDetail detail, IProductoService service, IinventoryRepository inventoryRepository, Almacen currentWarehouse)
        {
            IProductosUnidadesService productoUnidades = new ProductoUnidadesService();
            AlmacenProducto existenciaActual = inventoryRepository.ObtenerExistenciaDeProductoEnAlmacen(detail.ProductoId, currentWarehouse.Id).FirstOrDefault();
            if (existenciaActual != null)
            {
                detail.Producto.ProductoUnidades = detail.Producto.ProductoUnidades ?? productoUnidades.ObtenerUnidadesDeProducto(detail.ProductoId);
                existenciaActual.Cantidad = PuntoDeVenta.DataAccess.Dto.Helpers.ProductosHelper.ConvertirAUnidadPrincipalProducto(
       existenciaActual.Cantidad,
       detail.Producto.ProductoUnidades.Where(pu => pu.EsPrincipal).FirstOrDefault().UnidadId,
        detail.Producto.ProductoUnidades
       );

                detail.Cantidad = PuntoDeVenta.DataAccess.Dto.Helpers.ProductosHelper.ConvertirAUnidadPrincipalProducto(
           detail.Cantidad,
           detail.UnidadId.Value,
           detail.Producto.ProductoUnidades
           );

                existenciaActual.Cantidad += detail.Cantidad;
                Producto producto = service.ObtenerPorId(detail.ProductoId);
                producto.Existencia += detail.Cantidad;
                service.Actualizar(producto);
                inventoryRepository.Actualizar(existenciaActual);

            }
            else
                inventoryRepository.Insertar(new AlmacenProducto()
                {
                    Activo = true,
                    Cantidad = detail.Cantidad,
                    AlmacenId = currentWarehouse.Id,
                    CreadoPor = detail.CreadoPor,
                    FechaCreacion = DateTime.Now,
                    ProductoId = detail.ProductoId,
                    UnidadId = detail.Producto.ProductoUnidades.Where(u => u.EsPrincipal).FirstOrDefault().Id
                });

        }

        public static InvoiceDetail ActualizarProductoEnAlmacen(Localidad localidad, InvoiceDetail detail, IProductoService service,
            IinventoryRepository inventoryRepository, IInvoiceDetailService detailService, invoice invoice)
        {
            InvoiceDetail newdetail = new InvoiceDetail(detail);

            var instanciainvoicerProducto = InstanciarClaseinvoicerProductoServicio.Instanciarinvoicedor(detail.Producto);
            newdetail = instanciainvoicerProducto.ProcesarProductoServicio(localidad.Id, detail, service, inventoryRepository, detailService, invoice);



            return newdetail;
        }
    }
}
