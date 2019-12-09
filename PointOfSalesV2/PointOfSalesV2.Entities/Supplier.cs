using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Supplier : CommonData
    {


        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        //public int MonedaId { get; set; }
        public string CardId { get; set; }
        public string Name { get; set; }
       

       
    }
}
