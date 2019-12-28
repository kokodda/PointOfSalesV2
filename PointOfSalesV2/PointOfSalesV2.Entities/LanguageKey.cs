using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class LanguageKey : CommonData
    {
        [NotMapped]
        public override long Id { get => base.Id; set => base.Id = value; }
        [NotMapped]
        public override string TranslationData { get => base.TranslationData; set => base.TranslationData = value; }
        public long LanguageId { get; set; }
        [MaxLength(2)]
        public string LanguageCode { get; set; }
        [MaxLength(100)]
        public string Key { get; set; }
        public string Value { get; set; }

        [ForeignKey("LanguageCode")]
        public Language Language { get; set; }

    }
}
