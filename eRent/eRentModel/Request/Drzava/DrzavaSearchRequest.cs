using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Request
{
    public class DrzavaSearchRequest
    {
        public int? DrzavaId { get; set; }
        public string NazivDrzave { get; set; }
    }
}
