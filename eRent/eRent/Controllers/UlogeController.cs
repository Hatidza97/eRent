using eRent.Interface;
using eRent.Model.Request.Uloga;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogeController
    {
        private readonly IUlogeService _service;

        public UlogeController(IUlogeService service)
        {
            _service = service;
        } 
        [HttpGet]
        public ActionResult<List<Model.Model.Uloga>> Get([FromQuery] UlogeSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Model.Uloga> GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
