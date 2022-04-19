using eRent.Interface;
using eRent.Model.Request.TipObjektum;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TipObjektumController
    {
        private readonly ITipObjektumService _service;
        public TipObjektumController(ITipObjektumService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Model.Model.TipObjektum>> Get([FromQuery] TipObjektumSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Model.TipObjektum> GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public ActionResult<Model.Model.TipObjektum> Insert(TipObjektumInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public ActionResult<Model.Model.TipObjektum> Update(int id, [FromBody] TipObjektumInsertRequest request)
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
