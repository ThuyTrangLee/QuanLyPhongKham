using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class taiKhoanBUS
    {

        private taiKhoanDAL tkDAL;
        public taiKhoanBUS()
        {
            tkDAL = new taiKhoanDAL();
        }
        public List<taiKhoanDTO> select()
        {
            return tkDAL.select();
        }
    }
}
