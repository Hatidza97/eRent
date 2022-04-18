using eRent.Interface;
using eRent.Model.Request;
using eRent.Model.Request.Drzava;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Controllers
{
    public class DrzavaController : BaseController<Model.Model.Drzava, Model.Request.DrzavaSearchRequest>
    {
        public DrzavaController(IService<Model.Model.Drzava, DrzavaSearchRequest> service) : base(service)
        {

        }
      
    }
}
