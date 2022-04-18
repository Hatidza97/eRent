using System;
using System.Collections.Generic;

#nullable disable

namespace eRent.Database
{
    public partial class Cjenovnik
    {
        public int CjenovnikId { get; set; }
        public int ObjekatId { get; set; }
        public DateTime VaziOd { get; set; }
        public DateTime VaziDo { get; set; }
        public double Cijena { get; set; }

        public virtual Objekat Objekat { get; set; }
    }
}
