using QLPKDTO;
using QLPKDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class cachDungBUS
    {
        private cachDungDAL cdDAL;

        public cachDungBUS() // Hàm khởi tạo cho lớp cachDungBUS
        {
            cdDAL = new cachDungDAL(); // Khởi tạo đối tượng cachDungDAL
        }

        // Phương thức lấy danh sách các cách dùng
        public List<cachdungDTO> select()
        {
            return cdDAL.getcachdung(); // Gọi phương thức getcachdung từ lớp cachDungDAL
        }
    }
}
