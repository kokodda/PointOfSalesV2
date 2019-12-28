using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class RoleSectionData
    {
        public Section Section { get; set; }
        public List<UserOperation> Operations { get; set; }

    }
}
