using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Model
{
    public partial class Drzava
    {
        //public Drzava()
        //{
        // //   Grads = new HashSet<Grad>();
        //}

        public int DrzavaId { get; set; }
        public string Naziv { get; set; }

        //public virtual ICollection<Grad> Grads { get; set; }
    }
}
