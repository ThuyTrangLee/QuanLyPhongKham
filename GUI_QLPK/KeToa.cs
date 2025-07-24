using System;
using System.Collections.Generic;
using System.ComponentModel;
using QLPKBUS;
using QLPKDTO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPKDAL;

namespace GUI_QLPK
{
    public partial class KeToa : Form
    {
        PhieukhambenhBUS pkbBUS = new PhieukhambenhBUS();
        public DataTable db1 = new DataTable();
        ToathuocBUS ttBus = new ToathuocBUS();
        ChiTietToaThuocBUS ktBus = new ChiTietToaThuocBUS();
        ThuocBUS thBus = new ThuocBUS();
        cachDungBUS cdBus = new cachDungBUS();
        donviBUS donVivBus = new donviBUS();
        List<cachdungDTO> listcd;
        List<donViDTO> listdv;
        string id;
        public KeToa()
        {
            InitializeComponent();
            load_data();
            gird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listcd = cdBus.select();
            listdv = donVivBus.select();
        }
        public void load_data()
        {
            db1.Clear();
            db1.Columns.Add("Mã thuốc", typeof(string));
            db1.Columns.Add("Tên thuốc", typeof(string));
            db1.Columns.Add("Đơn vị", typeof(string));
            db1.Columns.Add("Đơn giá", typeof(string));
            db1.Columns.Add("Cách dùng", typeof(string));
            db1.Columns.Add("Số lượng", typeof(System.Int32));

            ThuocBUS thBus = new ThuocBUS();
            List<thuocDTO> listThuoc = thBus.select();
            this.loadData_Vao_Combobox(listThuoc);
            ttBus = new ToathuocBUS();

            List<phieukhambenhDTO> listPKB = pkbBUS.select();
            List<toathuocDTO> listToaThuoc = ttBus.select();
            this.loadData_Vao_Combobox(listThuoc, listPKB, listToaThuoc);
            maToa.Text = ttBus.autogenerate_matoa().ToString();

        }
        public void reset()
        {
            db1.Clear();
            mapkb.Text = "";
            soLuong.Text = "";
            TenThuoc.Text = "";
            maToa.Text = ttBus.autogenerate_matoa().ToString();
        }
        private void loadData_Vao_Combobox(List<thuocDTO> listThuoc)
        {
            if (listThuoc == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            DataTable table = new DataTable();

            table.Columns.Add("Tên thuốc", typeof(string));
            foreach (thuocDTO th in listThuoc)
            {
                DataRow row = table.NewRow();
                row["Tên thuốc"] = th.TenThuoc;
                table.Rows.Add(row);
            }
            TenThuoc.DataSource = table.DefaultView;
            TenThuoc.DisplayMember = "Tên thuốc";
            TenThuoc.SelectedIndex = -1;
        }
        private void loadData_Vao_GridView(List<thuocDTO> listThuoc, string soluong)
        {

            if (listThuoc == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            foreach (thuocDTO th in listThuoc)
            {
                if (th.TenThuoc == TenThuoc.Text)
                {
                    DataRow row = db1.NewRow();
                    row["Mã thuốc"] = th.MaThuoc;
                    row["Tên thuốc"] = th.TenThuoc;
                    foreach (donViDTO donvi in listdv)
                    {
                        if (donvi.MaDonVi == th.MaDonVi)
                        {
                            row["Đơn vị"] = donvi.TenDonVi;
                        }

                    }
                    row["Đơn giá"] = th.DonGia;
                    foreach (cachdungDTO cd in listcd)
                    {
                        if (cd.MaCachDung == th.MaCachDung)
                        {
                            row["Cách dùng"] = cd.TenCachDung;
                        }

                    }
                    row["Số lượng"] = soluong;
                    db1.Rows.Add(row);
                }
            }
        }
        private void loadData_Vao_Combobox(List<thuocDTO> listThuoc, List<phieukhambenhDTO> listPKB, List<toathuocDTO> listToaThuoc)
        {

            if (listThuoc == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            if (listPKB == null)
            {
                System.Windows.Forms.MessageBox.Show("Không có phiếu khám bệnh nào cần kê thuốc !!!", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            DataTable table = new DataTable();

            table.Columns.Add("Tên thuốc", typeof(string));
            foreach (thuocDTO th in listThuoc)
            {
                DataRow row = table.NewRow();
                row["Tên thuốc"] = th.TenThuoc;
                table.Rows.Add(row);
            }
            TenThuoc.DataSource = table.DefaultView;
            TenThuoc.DisplayMember = "Tên thuốc";
            TenThuoc.SelectedIndex = -1;

            HashSet<string> maPKBDaCoTrongToaThuoc = new HashSet<string>();

            foreach (toathuocDTO tt in listToaThuoc)
            {
                maPKBDaCoTrongToaThuoc.Add(tt.MaPkb);
            }

            foreach (phieukhambenhDTO pkb in listPKB)
            {
                if (!maPKBDaCoTrongToaThuoc.Contains(pkb.MaPKB))
                {
                    mapkb.Items.Add(pkb.MaPKB);

                }
            }
        }

        private void AddThuoc_SoLuong_Click(object sender, EventArgs e)
        {
            bool kt;
            try
            {
                int.Parse(soLuong.Text);
                kt = true;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập số và không được để trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kt = false;

            }
            int soLuongNhap;
            bool laSoNguyen = int.TryParse(soLuong.Text, out soLuongNhap);

            if (!laSoNguyen || soLuongNhap <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                soLuong.Text = "";
                soLuong.Focus();
                return;
            }

            if (kt == false)
            {
                soLuong.Text = "";
                soLuong.Focus();
            }
            else
            {
                bool notExist = true;
                DataRow[] rows = db1.Select();
                if (rows.Length == 0)
                {
                    thBus = new ThuocBUS();
                    List<thuocDTO> listThuoc = thBus.select();
                    this.loadData_Vao_GridView(listThuoc, soLuong.Text);
                    gird.DataSource = db1.DefaultView;
                }
                else
                {
                    for (int i = 0; i < rows.Length; i++)
                    {
                        if (rows[i]["Tên thuốc"].ToString() == TenThuoc.Text.ToString())
                        {
                            int sl = 0;
                            sl = int.Parse(rows[i]["Số lượng"].ToString());
                            db1.Rows[i][5] = sl + int.Parse(soLuong.Text.ToString());
                            notExist = false;
                            break;
                        }
                    }
                    if (notExist == true)
                    {
                        thBus = new ThuocBUS();
                        List<thuocDTO> listThuoc = thBus.select();
                        this.loadData_Vao_GridView(listThuoc, soLuong.Text);
                        gird.DataSource = db1.DefaultView;
                    }
                }
            }
        }

        private void KeThuoc_Click(object sender, EventArgs e)
        {
            int row = db1.Rows.Count;
            toathuocDTO tt = new toathuocDTO();
            tt.MaToa = maToa.Text.ToString();
            tt.MaPkb = mapkb.Text.ToString();
            tt.NgayKetoa = DateTime.UtcNow.Date;
            ttBus = new ToathuocBUS();
            bool kq = ttBus.them(tt);
            ChiTietToaThuocDTO kt = new ChiTietToaThuocDTO();
            for (int i = 0; i < row; i++)
            {
                kt.MaToa = maToa.Text;
                kt.MaThuoc = gird.Rows[i].Cells[0].Value.ToString();
                int val = int.Parse(gird.Rows[i].Cells[5].Value.ToString());

                bool check = int.TryParse(gird.Rows[i].Cells[5].Value.ToString(), out val);
                if (!check)
                {
                    return;
                }
                else
                {
                    kt.SoLuong = val;
                }
                ktBus = new ChiTietToaThuocBUS();
                bool kq1 = ktBus.kethuoc(kt);
            }
            if (kq == false)
            {
                System.Windows.Forms.MessageBox.Show("Kê toa thất bại", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Kê toa thành công", "Result");
                reset();
            }
        }

        private void gird_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewRow row_selected = dataGridView.CurrentRow;
            if (row_selected != null)
            {
                id = row_selected.Cells["Mã thuốc"].Value.ToString();
            }
        }

        private void gird_Click(object sender, EventArgs e)
        {
            DataRow[] drr = db1.Select("Mã thuốc='" + id + "'");
            for (int i = 0; i < drr.Length; i++)
                drr[i].Delete();
            db1.AcceptChanges();
            gird.DataSource = db1.DefaultView;
        }

        private void XoaThuoc_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("Vui lòng chọn thuốc cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thuốc này khỏi toa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataRow[] rows = db1.Select("[Mã thuốc] = '" + id + "'");
                foreach (DataRow row in rows)
                {
                    row.Delete();
                }
                db1.AcceptChanges();
                gird.DataSource = db1.DefaultView;
                id = null; // reset lại
            }
        }
    }
}
