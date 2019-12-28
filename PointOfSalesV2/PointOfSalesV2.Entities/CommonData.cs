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
        public virtual Guid CreatedBy { get; set; }
        public virtual string CreatedByName { get; set; }

        public virtual Guid? ModifiedBy { get; set; }
        public virtual string ModifiedByName { get; set; }
        public virtual DateTime CreatedDate { get; set; }

        public virtual DateTime? ModifiedDate { get; set; }

        [Key]
        public virtual long Id { get; set; }

        public virtual bool Active { get; set; }
        public virtual string TranslationData { get; set; } = "[]";

        //[ForeignKey("CreatedBy")]
        //public virtual User CreatedByUser { get; set; }
        //[ForeignKey("ModifiedBy")]
        //public virtual User ModifiedByUser { get; set; }

    }
}
