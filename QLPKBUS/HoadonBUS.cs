using QLPKDTO;
using QLPKDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class HoadonBUS
    {
        private HoadonDAL hdDAL;
        public HoadonBUS()
        {
            hdDAL = new HoadonDAL();
        }
        public int sobenhnhan(string ngHD)
        {
            return hdDAL.sobenhnhan(ngHD);
        }
        public int autogenerate_mahd()
        {
            return hdDAL.autogenerate_mahd();
        }
        public decimal tienthuoc(hoadonDTO hd, string mapkb)
        {
            decimal re = hdDAL.tienthuoc(hd, mapkb);
            return re;
        }
        public float tienkham()
        {
            float re = hdDAL.tienkham();
            return re;
        }
    }
}
