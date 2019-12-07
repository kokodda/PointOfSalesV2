using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesV2.Entities
{
    public interface ICommonData
    {
        Guid CreatedBy { get; set; }

        Guid? ModifiedBy { get; set; }
        DateTime CreatedDate { get; set; }

        DateTime? ModifiedDate { get; set; }

       
        long Id { get; set; }

        bool Active { get; set; }
    }
}
