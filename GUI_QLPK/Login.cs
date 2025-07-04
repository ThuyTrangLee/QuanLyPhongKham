using QLPKBUS;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            matkhau.UseSystemPasswordChar = true;
        }
        taiKhoanBUS tkBUS = new taiKhoanBUS();
        taiKhoanDTO tk = new taiKhoanDTO();
        loaiTaiKhoanBUS loaitkBUS = new loaiTaiKhoanBUS();
        loaiTaiKhoanDTO loaitk = new loaiTaiKhoanDTO();

        Boolean check = true;

        private void dangnhap_Click(object sender, EventArgs e)
        {
            List<taiKhoanDTO> listTk = tkBUS.select();
            List<loaiTaiKhoanDTO> listLoaiTk = loaitkBUS.select();
            int TENTK = 0;
            foreach(taiKhoanDTO tk in listTk)
            {
                if(tk.Username == username.Text)
                {
                    if(tk.Password == matkhau.Text)
                    {
                        check = true;
                        TENTK = tk.MaLoai; // Lấy mã loại tài khoản
                    }
                }
            }
            if (check)
            {
                this.Hide();
                QLPMMain main = new QLPMMain(TENTK);
                main.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Text = "";
                matkhau.Text = "";
                // Đặt con trỏ vào ô nhập tên đăng nhập
                username.Focus();
            }
        }
    }
}
