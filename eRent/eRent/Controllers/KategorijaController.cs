using eRent.Interface;
using eRent.Model.Request.Kategorija;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class KategorijaController
    {
        private readonly IKategorijaService _service;
        public KategorijaController(IKategorijaService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Model.Model.Kategorija>> Get([FromQuery] KategorijaSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Model.Kategorija> GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public ActionResult<Model.Model.Kategorija> Insert(KategorijaInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public ActionResult<Model.Model.Kategorija> Update(int id, [FromBody] KategorijaInsertRequest request)
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
