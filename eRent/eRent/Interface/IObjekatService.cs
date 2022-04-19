using eRent.Model.Request.Objekat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Interface
{
    public interface IObjekatService
    {
        List<Model.Model.Objekat> Get(ObjekatSearchRequest request);
        Model.Model.Objekat GetById(int id);
        Model.Model.Objekat Insert(ObjekatInserRequest request);

        bool Delete(int id);
        Model.Model.Objekat Update(int id, ObjekatInserRequest request);

    }
}
