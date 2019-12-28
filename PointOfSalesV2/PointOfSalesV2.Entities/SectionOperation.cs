using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class SectionOperation : CommonData
    {
        public long SectionId { get; set; }
        public long OperationId { get; set; }


        [NotMapped]
        public override string TranslationData { get; set; }

    }
}
