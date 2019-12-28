using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Entities
{
   public class Result<T> where T: new()
    {
        public Result() { }
        public Result(long id = 0, int status = 0, string message = "", IEnumerable<T> data = null, Exception exception=null) 
        {
            this.Id = id;
            this.Status = status;
            this.Message = message;
            this.Data = data;
            this.Exception = exception;
        }
        public long Id { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public IEnumerable<T> Data { get; set; }
        public Exception Exception { get; set; }
    }
}
