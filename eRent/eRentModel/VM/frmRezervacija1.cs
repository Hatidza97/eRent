using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.VM
{
    public class frmRezervacija1
    {
        public int RezervacijaId { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRezervacije { get; set; }
        public DateTime? DatumPrijave { get; set; }
        public DateTime? DatumOdjave { get; set; }
        public string Cijena { get; set; }
        public string Objekat { get; set; }
        public double Vrijednost { get; set; }
        public int KorisnikId { get; set; }
        public int? BrojMjestaDjeca { get; set; }
        public int? BrojMjestaOdrasli { get; set; }

    }
}
