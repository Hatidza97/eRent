using System;
using System.Collections.Generic;
using System.Text;
using eRent.Model;
namespace eRent.Model.Request.Cjenovnik
{
    public class CjenovnikSearchRequest
    {
        public int? CjenovnikId { get; set; }
        public int? ObjekatId { get; set; }
        public DateTime? VaziOd { get; set; }
        public DateTime? VaziDo { get; set; }
        public double? Cijena { get; set; }

        //public virtual Objekat Objekat { get; set; }
    }
}
