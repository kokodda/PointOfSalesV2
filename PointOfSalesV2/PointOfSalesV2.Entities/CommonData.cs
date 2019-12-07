using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesV2.Entities
{
    public class CommonData : ICommonData
    {
        public Guid CreatedBy { get; set; }
        public string CreatedByName { get; set; }

        public Guid? ModifiedBy { get; set; }
        public string ModifiedByName { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Key]
        public long Id { get; set; }

        public bool Active { get; set; }

    }
}
