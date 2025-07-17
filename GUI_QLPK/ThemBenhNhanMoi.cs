using QLPKBUS;
using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPK
{
    public partial class ThemBenhNhanMoi : Form
    {
        BenhNhanBUS bnBus = new BenhNhanBUS();
        public ThemBenhNhanMoi()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            bnBus = new BenhNhanBUS();
            mabenhnhan.Text = bnBus.autogenerate_mabn().ToString();
            hoten.Text = "";
            ngaysinh.Value = DateTime.Now;
            gioitinh.Text = "";
            diachi.Text = "";
            macccd.Text = "";
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mabenhnhan.Text) || string.IsNullOrEmpty(hoten.Text) || (string.IsNullOrEmpty(gioitinh.Text)) || ngaysinh.Value == null || string.IsNullOrEmpty(diachi.Text) || string.IsNullOrEmpty(macccd.Text))
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập đầy đủ thông tin bệnh nhân");
            }
            else
            {
                BenhNhanDTO bn = new BenhNhanDTO();
                phieukhambenhDTO pkb = new phieukhambenhDTO();
                PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
                bn.MaBN = mabenhnhan.Text;
                bn.TenBN = hoten.Text;
                bn.GtBN = gioitinh.Text;
                bn.NgsinhBN = ngaysinh.Value;
                bn.DiachiBN = diachi.Text;
                bn.CanCuocCongDan = macccd.Text;

                List<BenhNhanDTO> danhSach = bnBus.select();
                if (danhSach.Any(b => b.CanCuocCongDan == bn.CanCuocCongDan))
                {
                    MessageBox.Show("CCCD đã tồn tại. Vui lòng nhập CCCD khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool kq = bnBus.them(bn);
                if (kq == true)
                {
                    System.Windows.Forms.MessageBox.Show("Thêm Bệnh nhân thành công", "Result");
                    this.Close();
                }
                else
                    System.Windows.Forms.MessageBox.Show("Thêm Bệnh nhân thất bại", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning);

            }
        }
    }
}
