using eRent.Model.Request.Korisnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Interface
{
    public interface IKorisniciService
    {
        List<Model.Model.Korisnik> Get(KorisniciSearchRequest request);
        Model.Model.Korisnik GetById(int id);
        Model.Model.Korisnik Insert(KorisniciInsertRequest request);

        bool Delete(int id);
        Model.Model.Korisnik Update(int id, KorisniciInsertRequest request);

        Model.Model.Korisnik Authentifikacija(string korisnickoime, string pass);

    }
}
