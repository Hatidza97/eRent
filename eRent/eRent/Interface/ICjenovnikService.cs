using eRent.Model.Request.Cjenovnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Interface
{
    public interface ICjenovnikService
    {
        List<Model.Model.Cjenovnik> Get(CjenovnikSearchRequest request);
        Model.Model.Cjenovnik GetById(int id);
    }
}
