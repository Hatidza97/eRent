using eRent.Model.Request.Kategorija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Interface
{
    public interface IKategorijaService
    {
        List<Model.Model.Kategorija> Get(KategorijaSearchRequest request);
        Model.Model.Kategorija GetById(int id);
        Model.Model.Kategorija Insert(KategorijaInsertRequest request);

        bool Delete(int id);
        Model.Model.Kategorija Update(int id, KategorijaInsertRequest request);
    }
}
