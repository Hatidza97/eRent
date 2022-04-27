using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Model
{
    public partial class Rezervacija
    {
        //public Rezervacija()
        //{
        //    //Boravaks = new HashSet<Boravak>();
        //}

        public int RezervacijaId { get; set; }
        public int ObjekatId { get; set; }
        public int GostId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumPrijave { get; set; }
        public DateTime DatumOdjave { get; set; }
        public int CjenovikId { get; set; }
        public double Cijena { get; set; }
        public double Vrijednost { get; set; }
        public int KorisnikId { get; set; }
        public int? BrojMjestaDjeca { get; set; }
        public int? BrojMjestaOdrasli { get; set; }
        public virtual Korisnik Gost { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Objekat Objekat { get; set; }
        public virtual ICollection<Boravak> Boravaks { get; set; }
    }
}
