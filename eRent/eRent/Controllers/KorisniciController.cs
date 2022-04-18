using eRent.Interface;
using eRent.Model.Request.Korisnik;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }
        //[Authorize(Roles ="Uposlenik")]
        [HttpGet]
        public ActionResult<List<Model.Model.Korisnik>> Get([FromQuery] KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Model.Korisnik> GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public ActionResult<Model.Model.Korisnik> Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public ActionResult<Model.Model.Korisnik> Update(int id, [FromBody] KorisniciInsertRequest request)
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

