using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class ChiTietToaThuocBUS
    {
        private ChiTietToaThuocDAL ktDAL;

        public ChiTietToaThuocBUS() 
        {
            ktDAL = new ChiTietToaThuocDAL(); 
        }
        public bool kethuoc(ChiTietToaThuocDTO kt)
        {
            bool re = ktDAL.kethuoc(kt);
            return re;
        }
        public List<ChiTietToaThuocDTO> selectbypkb(string mapkb)
        {
            return ktDAL.selectbypkb(mapkb);
        }
    }
}
