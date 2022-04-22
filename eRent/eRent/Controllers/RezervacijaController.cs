using eRent.Interface;
using eRent.Model.Request.Rezervacija;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class RezervacijaController
        {
            private readonly IRezervacijaService _service;
            public RezervacijaController(IRezervacijaService service)
            {
                _service = service;
            }
            //[Authorize(Roles ="Uposlenik")]
            [HttpGet]
            public ActionResult<List<Model.Model.Rezervacija>> Get([FromQuery] RezervacijaSearchRequest request)
            {
                return _service.Get(request);
            }
            [HttpGet("{id}")]
            public ActionResult<Model.Model.Rezervacija> GetById(int id)
            {
                return _service.GetById(id);
            }
            [HttpPost]
            public ActionResult<Model.Model.Rezervacija> Insert(RezervacijaInsertRequest request)
            {
                return _service.Insert(request);
            }
            [HttpPut("{id}")]
            public ActionResult<Model.Model.Rezervacija> Update(int id, [FromBody] RezervacijaInsertRequest request)
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
