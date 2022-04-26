using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Request.ObjekatSlike
{
    public class ObjekatSlikeInsertRequest
    {
        public int ObjekatId { get; set; }
        public byte[] ObjekatSlike1 { get; set; }
    }
}
