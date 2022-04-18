using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Model
{
    public partial class ObjekatSlike
    {
        public int ObjekatSlikeId { get; set; }
        public int ObjekatId { get; set; }
        public byte[] ObjekatSlike1 { get; set; }

        public virtual Objekat Objekat { get; set; }
    }
}
