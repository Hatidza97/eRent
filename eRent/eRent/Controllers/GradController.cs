using eRent.Interface;
using eRent.Model.Request.Grad;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class GradController : BaseCRUDController<Model.Model.Grad, GradSearchRequest, GradInsertRequest, GradInsertRequest>
    {
        public GradController(ICRUDService<Model.Model.Grad, GradSearchRequest, GradInsertRequest, GradInsertRequest> service) : base(service)
        {

        }
    }
}
