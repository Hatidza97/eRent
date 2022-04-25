using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Request.Rezervacija
{
    public class RezervacijaInsertRequest
    {
        public int ObjekatId { get; set; }
        public int GostId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumPrijave { get; set; }
        public DateTime DatumOdjave { get; set; }
        public int? CjenovikId { get; set; }
        public double Cijena { get; set; }
        public double Vrijednost { get; set; }
        public int KorisnikId { get; set; }
        public int? BrojMjestaDjeca { get; set; }
        public int? BrojMjestaOdrasli { get; set; }
    }
}
