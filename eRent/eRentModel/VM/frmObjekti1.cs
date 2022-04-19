using eRent.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.VM
{
    public class frmObjekti1
    {
        public int ObjekatId { get; set; }
        public string Naziv { get; set; }
        public int VlasnikId { get; set; }
        public int GradId { get; set; }
        public string Adresa { get; set; }
        public int KategorijaId { get; set; }
        public bool Aktivan { get; set; }
        public string Vlasnik { get; set; }
        public string Kategorija { get; set; }
        public string TipObjekta { get; set; }
        public string BrTelefona { get; set; }
        public string Email { get; set; }
        public int TipObjektaId { get; set; }
        public virtual Grad Grad { get; set; }
       
    }
}
