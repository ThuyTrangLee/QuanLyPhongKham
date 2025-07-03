using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class loaiTaiKhoanBUS
    {
        private loaiTaiKhoanDAL loaitkDAL;
        public loaiTaiKhoanBUS()
        {
            loaitkDAL = new loaiTaiKhoanDAL();
        }
        public List<loaiTaiKhoanDTO> select()
        {
            return loaitkDAL.select();
        }
    }
}
