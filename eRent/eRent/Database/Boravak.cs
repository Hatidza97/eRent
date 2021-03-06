using System;
using System.Collections.Generic;

#nullable disable

namespace eRent.Database
{
    public partial class Boravak
    {
        public int BoravakId { get; set; }
        public int RezervacijaId { get; set; }
        public DateTime BoravioOd { get; set; }
        public DateTime BoravioDo { get; set; }
        public string Komentar { get; set; }
        public int? Ocjena { get; set; }

        public virtual Rezervacija Rezervacija { get; set; }
    }
}
