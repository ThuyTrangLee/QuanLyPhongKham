using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class chandoanDTO
    {
        private string maPkb;
        private string maBenh;
        private string tenChuanDoan;

        public string MaPkb { get => maPkb; set => maPkb = value; }
        public string MaBenh { get => maBenh; set => maBenh = value; }
        public string TenChuanDoan { get => tenChuanDoan; set => tenChuanDoan = value; }
    }
}
