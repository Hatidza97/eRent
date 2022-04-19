using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Request.TipObjektum
{
    public class TipObjektumSearchRequest
    {
        public int TipObjektaId { get; set; }
        public string Tip { get; set; }
        public int? MaxKapacitet { get; set; }
    }
}
