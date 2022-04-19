using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Model
{
    public partial class Grad
    {
        public Grad()
        {
            //Korisniks = new HashSet<Korisnik>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<Korisnik> Korisniks { get; set; }
    
    }
}
