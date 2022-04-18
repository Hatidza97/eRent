using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Model
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
