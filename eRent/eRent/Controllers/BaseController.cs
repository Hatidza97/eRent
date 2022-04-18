using eRent.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Controllers
{
 
    
       // [Authorize]
        [Route("api/[controller]")]
        [ApiController]
        public class BaseController<TModel, Tsearch> : Controller where Tsearch : class
        {
            private readonly IService<TModel, Tsearch> _service;
            public BaseController(IService<TModel, Tsearch> service)
            {
                _service = service;
            }

            [HttpGet]
            public List<TModel> Get([FromQuery] Tsearch search)
            {
                return _service.Get(search);
            }


            [HttpGet("{id}")]
            public TModel GetById(int id)
            {
                return _service.GetByID(id);
            }
        }
    
}
