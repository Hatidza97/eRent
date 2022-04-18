using eRent.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class BaseCRUDController<TModel, Tsearch, TInsert, TUpdate> : BaseController<TModel, Tsearch> where Tsearch : class
    {
        protected readonly ICRUDService<TModel, Tsearch, TInsert, TUpdate> _service = null;

        public BaseCRUDController(ICRUDService<TModel, Tsearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]

        public TModel Insert(TInsert request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public TModel Update(int id, TUpdate request)
        {
            return _service.Update(id, request);
        }
        [HttpDelete]
        //[Authorize(Roles = "Administrator")]
        void Delete(int id)
        {
           _service.Delete(id);
        }
    }
}
