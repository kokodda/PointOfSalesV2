using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class CreditNoteRepository : Repository<CreditNote>, ICreditNoteRepository
    {
        public CreditNoteRepository(MainDataContext context) : base(context)
        {
        }

        public CreditNote GetBySequence(string sequence)
        {
            throw new NotImplementedException();
        }
    }
}
