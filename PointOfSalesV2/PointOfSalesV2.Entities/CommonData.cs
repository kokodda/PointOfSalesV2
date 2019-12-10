using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public virtual long Id { get; set; }

        public bool Active { get; set; }

        [ForeignKey("CreatedBy")]
        public User CreatedByUser { get; set; }
        [ForeignKey("ModifiedBy")]
        public User ModifiedByUser { get; set; }

    }
}
