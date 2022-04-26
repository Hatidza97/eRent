using eRent.Interface;
using eRent.Model.Request.Objekat;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjekatController
    {
        private readonly IObjekatService _service;
    public ObjekatController(IObjekatService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Model.Model.Objekat>> Get([FromQuery] ObjekatSearchRequest request=null)
        {
            return _service.Get(request);
        }
       
        [HttpGet("{id}")]
        public ActionResult<Model.Model.Objekat> GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public ActionResult<Model.Model.Objekat> Insert(ObjekatInserRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public ActionResult<Model.Model.Objekat> Update(int id, [FromBody] ObjekatInserRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
