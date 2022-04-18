using System;
using System.Collections.Generic;

#nullable disable

namespace eRent.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Objekats = new HashSet<Objekat>();
        }

        public int KategorijaId { get; set; }
        public string NazivKategorije { get; set; }

        public virtual ICollection<Objekat> Objekats { get; set; }
    }
}
