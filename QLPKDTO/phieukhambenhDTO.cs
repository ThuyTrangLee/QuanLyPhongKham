using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class phieukhambenhDTO
    {
        private string maPKB;
        private DateTime ngayKham;
        private string trieuChung;
        private string maBenhNhan;
        private int maBS;
        private DateTime ngayTaiKham;
        private bool daGuiMail;

        public string MaPKB { get => maPKB; set => maPKB = value; }
        public string TrieuChung { get => trieuChung; set => trieuChung = value; }
        public DateTime NgayKham { get => ngayKham; set => ngayKham = value; }
        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public int MBS { get => maBS; set => maBS = value; }
        public DateTime NgayTaiKham { get => ngayTaiKham; set => ngayTaiKham = value; }
        public bool DaGuiMail { get => daGuiMail; set => daGuiMail = value; }
    }
}
