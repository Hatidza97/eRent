using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Request.Grad
{
     public class GradSearchRequest
    {
        public int GradId { get; set; }
        public string NazivGrada { get; set; }

        public int? DrzavaId { get; set; }
    }
}
