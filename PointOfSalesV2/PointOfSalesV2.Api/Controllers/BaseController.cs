using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
   // [ControllerAuthorize]
    public class BaseController<T> : ODataController where T : class, ICommonData, new()
    {
        protected readonly IDataRepositoryFactory _repositoryFactory;
        protected readonly IOptions<AppSettings> _appSettings;
        protected readonly IBase<T> _baseRepo;
        public BaseController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory)
        {
            _appSettings = appSettings;
            _repositoryFactory = repositoryFactory;
            this._baseRepo = _repositoryFactory.GetDataRepositories<T>();
        }

        [HttpGet]
     //   [ActionAuthorize("ReadAll")]
        [EnableQuery(AllowedQueryOptions = AllowedQueryOptions.All)]
        public virtual IEnumerable<T> Get()
        {
            try
            {
                var data = _baseRepo.GetAll(x => x.Where(y => y.Active == true));
                //    var result = new PageResult<T>(data, new Uri("https://localhost:44383/api/products?$skip=2&$top=2"), data.Count());
                return data;
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet("{id:long}")]
        [EnableQuery]
        [ActionAuthorize("Read")]
        public virtual IActionResult Get(long id)
        {
            try
            {
                var data = _baseRepo.Get(id);
                return Ok(new { status = 0, message = "OK", data = data });
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("{number:int}/{size:int}")]
        [EnableQuery]
        [ActionAuthorize("ReadPaged")]
        public virtual IActionResult Get(int number, int size)
        {
            try
            {
                var data = _baseRepo.GetPaged(number, size);
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }





        [HttpPost]
        [ActionAuthorize("Add")]
        public virtual IActionResult Post([FromBody] T model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as T;
                }
                var result = _baseRepo.Add(model);

                return Ok(new { status = 0, message = "OK", data = result });
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpPut]
        [ActionAuthorize("Update")]
        public virtual IActionResult Put([FromBody] T model)
        {
            try
            {
                var result = _baseRepo.Update(model);
                return Ok(new { status = 0, message = "OK", data = result });
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpDelete("{id:long}")]
        [ActionAuthorize("Delete")]
        public virtual IActionResult Delete(long id)
        {
            try
            {
                var model = _baseRepo.Get(id) as ICommonData;
                if (model != null)
                {
                    model.Active = false;
                    _baseRepo.Update(model as T);
                }

                return Ok(new { status = 0, message = "OK" });
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        protected virtual IBase<K> GetDataRepo<K>() where K : class, ICommonData, new()
        {
            return _repositoryFactory.GetDataRepositories<K>();
        }
    }
}