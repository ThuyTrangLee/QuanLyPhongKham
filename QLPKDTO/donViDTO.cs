using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class donViDTO
    {
        private int maDonVi;
        private string tenDonVi;
        public int MaDonVi { get { return maDonVi; } set { maDonVi = value; } }
        public string TenDonVi { get { return tenDonVi; } set { tenDonVi = value; } }
    }
}
