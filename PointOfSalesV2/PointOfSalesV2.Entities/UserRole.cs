using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class UserRole : CommonData
    {
        public Guid UserId { get; set; }
        public long RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }



    }
}
