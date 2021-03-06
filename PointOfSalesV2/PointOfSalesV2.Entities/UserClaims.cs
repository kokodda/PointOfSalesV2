using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class UserClaims : CommonData
    {
        public Guid UserId { get; set; }
        [MaxLength(100)]
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }


        [NotMapped]
        public override string TranslationData { get; set; }

    }
}
