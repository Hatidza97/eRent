using System;
using System.Collections.Generic;

#nullable disable

namespace eRent.Database
{
    public partial class ObjekatSlike
    {
        public int ObjekatSlikeId { get; set; }
        public int ObjekatId { get; set; }
        public byte[] ObjekatSlike1 { get; set; }

        public virtual Objekat Objekat { get; set; }
    }
}
