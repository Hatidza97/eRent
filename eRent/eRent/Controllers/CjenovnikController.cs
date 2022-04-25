using eRent.Interface;
using eRent.Model.Request.Cjenovnik;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CjenovnikController
    {
        private readonly ICjenovnikService _service;
        public CjenovnikController(ICjenovnikService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Model.Model.Cjenovnik>> Get([FromQuery] CjenovnikSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Model.Cjenovnik> GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
