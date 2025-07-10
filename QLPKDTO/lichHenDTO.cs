using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class lichHenDTO
    {
        private int maLichHen;
        private string maBenhNhan;
        private string maBacSi;
        private DateTime ngayHen;
        private string trangThai;

        public int MaLichHen { get => maLichHen; set => maLichHen = value; }
        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public string MaBacSi { get => maBacSi; set => maBacSi = value; }
        public DateTime NgayHen { get => ngayHen; set => ngayHen = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
