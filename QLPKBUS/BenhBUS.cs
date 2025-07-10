using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPKDAL;
using QLPKDTO;

namespace QLPKBUS
{
    public class BenhBUS
    {
        private BenhDAL beDAL;
        public BenhBUS()
        {
            beDAL = new BenhDAL(); // Khởi tạo DAL
        }
        // Phương thức lấy danh sách các bệnh
        public List<benhDTO> select()
        {
            return beDAL.select(); // Gọi phương thức select từ DAL để lấy danh sách bệnh
        }
        public List<benhDTO> selectByKeyWord(string sKeyword)
        {
            return beDAL.selectByKeyWord(sKeyword);
        }

    }
}
