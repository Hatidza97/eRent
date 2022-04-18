using System;
using System.Collections.Generic;

#nullable disable

namespace eRent.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            Korisniks = new HashSet<Korisnik>();
        }

        public int UlogaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Korisnik> Korisniks { get; set; }
    }
}
