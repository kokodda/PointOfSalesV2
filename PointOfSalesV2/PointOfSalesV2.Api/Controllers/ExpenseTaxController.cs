﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseTaxController : BaseController<ExpenseTax>
    {
        public ExpenseTaxController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory) : base(appSettings, repositoryFactory)
        {
        }
    }
}