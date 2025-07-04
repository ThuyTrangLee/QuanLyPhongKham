using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class BenhNhanDTO
    {
        private string maBN;
        private string tenBN;
        private string diachiBN;
        private string gtBN;
        private DateTime ngsinhBN;

        public string MaBN { get => maBN; set => maBN = value; }
        public string TenBN { get => tenBN; set => tenBN = value; }
        public string DiachiBN { get => diachiBN; set => diachiBN = value; }
        public string GtBN { get => gtBN; set => gtBN = value; }
        public DateTime NgsinhBN { get => ngsinhBN; set => ngsinhBN = value; }

    }
}
