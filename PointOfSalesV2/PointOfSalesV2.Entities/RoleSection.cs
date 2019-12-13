using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class RoleSection : CommonData
    {
        public long RoleId { get; set; }
        public string JsonData { get; set; } = "[]";



    }
}
