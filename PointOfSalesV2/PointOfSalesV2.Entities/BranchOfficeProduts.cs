using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{ 
    public class BranchOfficeProduts

    {


        public long LocationId { get; set; }
        [ForeignKey("LocationId")]
        public BranchOffice Location { get; set; }
        public List<Inventory> ProductsByWarehouse { get; set; }

    }
}
