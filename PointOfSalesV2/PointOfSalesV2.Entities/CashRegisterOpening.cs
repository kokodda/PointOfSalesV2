using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace PointOfSalesV2.Entities
{
    public class CashRegisterOpening : CommonData
    {

        public Guid UserId { get; set; }
        public long CurrencyId { get; set; }
        public long CashRegisterId { get; set; }
        public long LocationId { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime MaxClosureDate { get; set; }
        public DateTime ClosureDate { get; set; }
        public string OpeningDetails { get; set; } = "{}";
        public string ClosureDetails { get; set; } = "{}";
        public decimal TotalPaymentsAmount { get; set; }
        public decimal OpeningClosureDifference { get; set; }

        public string UserName { get; set; }
        public char State { get; set; }
        public decimal TotalOpeningAmount { get; set; }
        public decimal TotalClosureAmount { get; set; }

        [ForeignKey("CashRegisterId")]
        public CashRegister CashRegister { get; set; }

        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

        [ForeignKey("LocationId")]
        public BranchOffice Location { get; set; }

    }
}
