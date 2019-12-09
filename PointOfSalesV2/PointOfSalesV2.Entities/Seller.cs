using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Seller : CommonData
    {
        public string Name { get; set; }
        public string CardId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public long? ZoneId { get; set; }
        public decimal ComissionRate { get; set; }
        public bool ComissionByProduct { get; set; }
        public bool FixedComission { get; set; }

        [NotMapped]
        public string NameAndCode { get { return $"{Code ?? ""}  {Name}"; } }



        [ForeignKey("ZoneId")]
        public Zone Zone { get; set; }
    }
}
