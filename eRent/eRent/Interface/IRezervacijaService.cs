using eRent.Model.Request.Rezervacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Interface
{
    public interface IRezervacijaService
    {
        List<Model.Model.Rezervacija> Get(RezervacijaSearchRequest request);
        Model.Model.Rezervacija GetById(int id);
        Model.Model.Rezervacija Insert(RezervacijaInsertRequest request);

        bool Delete(int id);
        Model.Model.Rezervacija Update(int id, RezervacijaInsertRequest request);

        //Model.Model.Korisnik Authentifikacija(string korisnickoime, string pass);
    }
}
