﻿using QLPKBUS;
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
    public partial class QuanLyDichVu : Form
    {
        public DataTable db1 = new DataTable("DichVu");
        DichvuBUS dvBus = new DichvuBUS();
        dichvuDTO dv = new dichvuDTO();
        public int temp_ma;

        public QuanLyDichVu()
        {
            InitializeComponent();
            load_data();
            gird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            db1.Clear();
        }

        public void load_data()
        {
            List<dichvuDTO> listDichVu = dvBus.select();
            this.loadData_Vao_GridView(listDichVu);
        }
        private void loadData_Vao_GridView(List<dichvuDTO> listDichVu)
        {

            if (listDichVu == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            DataTable table = new DataTable();
            table.Columns.Add("Mã dịch vụ", typeof(string));
            table.Columns.Add("Tên dịch vụ", typeof(string));
            table.Columns.Add("Tiền dịch vụ", typeof(string));
            foreach (dichvuDTO dv in listDichVu)
            {
                DataRow row = table.NewRow();
                row["Mã dịch vụ"] = dv.MaDichVu;
                row["Tên dịch vụ"] = dv.TenDichVu;
                row["Tiền dịch vụ"] = dv.TienDichVu;
                table.Rows.Add(row);
            }
            gird.DataSource = table.DefaultView;
        }

        private void TimKiem_Click_1(object sender, EventArgs e)
        {
            string sKeyword = maDichVu.Text;
            if (string.IsNullOrEmpty(sKeyword)) // Tìm tất cả nếu không có từ khóa
            {
                List<dichvuDTO> listDichVu = dvBus.select();
                this.loadData_Vao_GridView(listDichVu);
            }
            else
            {
                List<dichvuDTO> listDichVu = dvBus.selectByKeyWord(sKeyword);
                this.loadData_Vao_GridView(listDichVu);
            }
        }

        private void themdv_Click(object sender, EventArgs e)
        {
            ThemDichVuMoi themdvm = new ThemDichVuMoi();
            themdvm.Show();
            load_data();
        }

        private void capnhatdv_Click(object sender, EventArgs e)
        {
            float tien;
            if (float.TryParse(txtTienDV.Text.Trim(), out tien) && tien <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập số dương và không được để trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienDV.Focus();
                return;
            }
            dv.TenDichVu = txtTenDV.Text;
            dv.TienDichVu = int.Parse(txtTienDV.Text);

            bool kq = dvBus.sua(dv, temp_ma);
            if (!kq)
                System.Windows.Forms.MessageBox.Show("Cập nhật dịch vụ thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                System.Windows.Forms.MessageBox.Show("Cập nhật dịch vụ thành công", "Result");
                load_data();
            }
        }

        private void xoadv_Click_1(object sender, EventArgs e)
        {
            dv.MaDichVu = temp_ma;
            bool kq = dvBus.xoa(dv);
            if (!kq)
                System.Windows.Forms.MessageBox.Show("Xóa dịch vụ thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                System.Windows.Forms.MessageBox.Show("Xóa dịch vụ thành công", "Result");
                load_data();
            }
        }

        private void huydv_Click_1(object sender, EventArgs e)
        {
            txtTenDV.Text = string.Empty;
            txtTienDV.Text = string.Empty;
            maDichVu.Text = string.Empty;
        }

        private void gird_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gird.Rows.Count)
            {
                DataGridViewRow row = gird.Rows[e.RowIndex];
                txtTenDV.Text = row.Cells[1].Value.ToString();
                txtTienDV.Text = row.Cells[2].Value.ToString();
                temp_ma = int.Parse(row.Cells[0].Value.ToString());
            }
        }
    }
}
