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
    public partial class ThemDichVuMoi : Form
    {
        DichvuBUS dvBus = new DichvuBUS();
        public ThemDichVuMoi()
        {
            InitializeComponent();
        }


        private void ThemDichVuMoi_Load(object sender, EventArgs e)
        {
            DichvuBUS dvBus = new DichvuBUS();
            maDichVu.Text = dvBus.autogenerate_madv().ToString();
        }


        private void Them_Click_1(object sender, EventArgs e)
        {
            float gia;
            if (!float.TryParse(tienDichVu.Text.Trim(), out gia) || gia <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập số dương và không được để trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tienDichVu.Text = "";
                tienDichVu.Focus();
                return;
            }

            if (string.IsNullOrEmpty(maDichVu.Text.Trim()) ||
                string.IsNullOrEmpty(tenDichVu.Text.Trim()) ||
                string.IsNullOrEmpty(tienDichVu.Text.Trim()))
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập đầy đủ thông tin loại thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dichvuDTO dv = new dichvuDTO();

            dv.TenDichVu = tenDichVu.Text;
            dv.TienDichVu = float.Parse(tienDichVu.Text);

            dvBus = new DichvuBUS();
            bool kq = dvBus.them(dv);
            if (!kq)
                System.Windows.Forms.MessageBox.Show("Thêm Dịch vụ thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                System.Windows.Forms.MessageBox.Show("Thêm Dịch vụ thành công", "Result");
                this.Close();
            }
        }
    }
}
