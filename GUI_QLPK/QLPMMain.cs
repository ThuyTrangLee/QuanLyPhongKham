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
    public partial class QLPMMain : Form
    {
        
        public int mataikhoan;
        taiKhoanBUS tkBUS = new taiKhoanBUS();
        public taiKhoanDTO tk = new taiKhoanDTO();
        loaiTaiKhoanBUS loaitkBUS = new loaiTaiKhoanBUS();
        loaiTaiKhoanDTO loaitk = new loaiTaiKhoanDTO();

        public QLPMMain(int mataikhoanLogin)
        {
            
            mataikhoan = mataikhoanLogin;
            List<taiKhoanDTO> listTk = tkBUS.select();
            List<loaiTaiKhoanDTO> listLoaiTk = loaitkBUS.select();
            InitializeComponent();
            foreach(taiKhoanDTO taiKhoan in listTk)
            {
                if(taiKhoan.MaTK == mataikhoanLogin)
                {
                    tentaikhoandangnhat.Text = taiKhoan.Name;
                    foreach(loaiTaiKhoanDTO loaiTaiKhoan in listLoaiTk)
                    {
                        if(loaiTaiKhoan.MaRole == taiKhoan.MaLoai)
                        {
                            txtChucvu.Text = loaiTaiKhoan.TenLoaiTaiKhoan;
                        }
                    }
                    if(taiKhoan.MaLoai == 1)
                    {

                    }
                }
            }
        }
        private void QLPMMain_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            customSubMenu();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            label_Val.Text = "Home";
            
        }

        //hàm container để hiển thị form con vào panel
        private void container(object _form)
        {
            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            label_Val.Text = "Tra cứu bệnh nhân";
            container(new TraCuuBenhNhan());
            
        }

        private void customSubMenu()
        {
            PansubMenuHoaDon.Visible = false;
            subMenuDanhMuc.Visible = false;
            PanSubBaoCao.Visible = false;
        }
        private void hideSubMenu()
        {
            if (PansubMenuHoaDon.Visible == true)
            {
                PansubMenuHoaDon.Visible = false;
            }
            if (subMenuDanhMuc.Visible == true)
            {
                subMenuDanhMuc.Visible = false;
            }
            if (PanSubBaoCao.Visible == true)
            {
                PanSubBaoCao.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        //nút chính
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            label_Val.Text = "Hóa Dơn";
            showSubMenu(PansubMenuHoaDon);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            label_Val.Text = "Danh Mục";
            showSubMenu(subMenuDanhMuc);
        }

        //nút phụ 
        private void btnLHD_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void btnDSHD_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void btn_qlThuoc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn_qlLoaiBenh_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn_qlBN_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn_qlDV_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn_qlAcc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        //Nút chính
        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            label_Val.Text = "Báo Cáo";
            showSubMenu(PanSubBaoCao);
        }

        private void btn_DThu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn_sdThuoc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label_Val.Text = "Phiếu khám bệnh";
            container(new ThemPhieuKhamBenh(mataikhoan));
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }
    }
}
