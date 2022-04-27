using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Model
{
    public partial class Objekat
    {
        //public Objekat()
        //{
        //    Cjenovniks = new HashSet<Cjenovnik>();
        //    ObjekatSlikes = new HashSet<ObjekatSlike>();
        //    Rezervacijas = new HashSet<Rezervacija>();
        //}

        public int ObjekatId { get; set; }
        public string Naziv { get; set; }
        public int VlasnikId { get; set; }
        public int GradId { get; set; }
        public string Adresa { get; set; }
        public int KategorijaId { get; set; }
        public bool Aktivan { get; set; }
        public string BrTelefona { get; set; }
        public string Email { get; set; }
        public int TipObjektaId { get; set; }
        public bool Rezervisano { get; set; }
        public virtual Kategorija Kategorija { get; set; }
        public virtual TipObjektum TipObjekta { get; set; }
        public virtual Korisnik Vlasnik { get; set; }
        //public virtual ICollection<Cjenovnik> Cjenovniks { get; set; }
        //public virtual ICollection<ObjekatSlike> ObjekatSlikes { get; set; }
        //public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
