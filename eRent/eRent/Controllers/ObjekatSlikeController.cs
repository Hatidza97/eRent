using eRent.Interface;
using eRent.Model.Request.ObjekatSlike;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjekatSlikeController
    {
        private readonly IObjekatSlikeService _service;
        public ObjekatSlikeController(IObjekatSlikeService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Model.Model.ObjekatSlike>> Get([FromQuery] ObjekatSlikeSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Model.ObjekatSlike> GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public ActionResult<Model.Model.ObjekatSlike> Insert(ObjekatSlikeInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
