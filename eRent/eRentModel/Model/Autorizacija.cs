using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Model
{
    public partial class Autorizacija
    {
        public int AutorizacijaId { get; set; }
        public int KorisnikId { get; set; }
        public bool? DodajFunkcija { get; set; }
        public bool? BrisiFunkcija { get; set; }
        public bool? UrediFunkcija { get; set; }
        public bool? CitajFunkcija { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
