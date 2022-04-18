using eRent.Model.Request.Uloga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Interface
{
    public interface IUlogeService
    {
        List<Model.Model.Uloga> Get(UlogeSearchRequest request);
        Model.Model.Uloga GetById(int id);
    }
}
