using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPKDAL;
using QLPKDTO;

namespace QLPKBUS
{
    public class ChandoanBUS
    {
        private ChandoanDAL cdDAL;

        public ChandoanBUS()
        {
            cdDAL = new ChandoanDAL(); // Khởi tạo DAL
        }
        public bool them(chandoanDTO cd)
        {
            return cdDAL.them(cd);
        }
        // Phương thức lấy danh sách các chẩn đoán
        public List<chandoanDTO> select()
        {
            return cdDAL.select(); 
        }

        public List<chandoanDTO> selectByKeyWord(string sKeyword)
        {
            return cdDAL.selectByKeyWord(sKeyword);
        }

    }
}
