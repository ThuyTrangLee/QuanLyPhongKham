using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class BenhNhanBUS
    {
        private BenhNhanDAL bnDAL;
        public BenhNhanBUS()
        {
            bnDAL = new BenhNhanDAL();
        }
        public List<BenhNhanDTO> select()
        {
            return bnDAL.select();
        }
        public List<BenhNhanDTO> selectByKeyWord(string sKeyword)
        {
            return bnDAL.SelectByKeyWord(sKeyword);
        }
    }
}
