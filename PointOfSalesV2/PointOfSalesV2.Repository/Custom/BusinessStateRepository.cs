using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class BusinessStateRepository :  IBusinessStateRepository
    {
        private readonly MainDataContext _context;
        public BusinessStateRepository(MainDataContext context) 
        {
            this._context = context;
        }

        public List<object> GetFinancialState(DateTime? startDate, DateTime? endDate)
        {
            throw new NotImplementedException();
        }
    }
}
