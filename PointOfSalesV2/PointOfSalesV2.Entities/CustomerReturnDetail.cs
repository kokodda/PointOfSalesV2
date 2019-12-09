using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class CustomerReturnDetail : CommonData
    {


        public long ProductoId { get; set; }

        public decimal Quantity { get; set; }
        public string Reference { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        public decimal TaxesAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public long CustomerId { get; set; }

        public bool Defective { get; set; }

        public Nullable<long> UnitId { get; set; }


        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [ForeignKey("ProductoId")]
        public Product Product { get; set; }
        [ForeignKey("WarehouseId")]
        public Warehouse Warehouse { get; set; }






    }
}
