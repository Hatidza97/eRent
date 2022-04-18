using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Model
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
