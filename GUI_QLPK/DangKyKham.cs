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
    public partial class DangKyKham : Form
    {
        lichHenBUS lhBus = new lichHenBUS();
        BenhNhanBUS bnBus = new BenhNhanBUS();
        private int madd;
        private int stt;
        taiKhoanBUS tkBus = new taiKhoanBUS();
        loaiTaiKhoanBUS ltkBus = new loaiTaiKhoanBUS();
        lichHenDTO lh = new lichHenDTO();
        public DangKyKham(int mataikhoan)
        {
            madd = mataikhoan;
            InitializeComponent();
            load_combobox_mabn(); // load mã bệnh nhân
            load_combobox_bacsi(); // load bác sĩ
            ngaykham.Text = DateTime.Now.ToString();
            gird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            load_Gird(); 
            load_data();
            
        }
        public void load_data()
        {
            malichhen.Text = lhBus.autogenerate_malichhen().ToString();
            hoten.Text = "";
            mabenhnhan.Text = "";
        }

        //load dữ liệu bệnh nhân
        public void load_combobox_mabn()
        {
            bnBus = new BenhNhanBUS();
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            this.loadData_Vao_comboboxbn(listBenhNhan);
        }
        // load dữ liệu mã bệnh nhân vào combobox
        private void loadData_Vao_comboboxbn(List<BenhNhanDTO> listBenhNhan)
        {
            if (listBenhNhan == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin bệnh nhân từ DB", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                mabenhnhan.Items.Add(bn.MaBN.ToString());
            }
        }
        public void load_combobox_bacsi()
        {
            List<loaiTaiKhoanDTO> listTaiKhoan = ltkBus.select();
            loaiTaiKhoanDTO bacSiRole = null;
            if (listTaiKhoan == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin bác sĩ từ DB", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            foreach (loaiTaiKhoanDTO role in listTaiKhoan)
            {
                if (role.TenLoaiTaiKhoan.Equals("Bác sĩ", StringComparison.OrdinalIgnoreCase))
                {
                    bacSiRole = role;
                    break;
                }
            }
            List<taiKhoanDTO> allUsers = tkBus.select();
            List<taiKhoanDTO> listBacSi = new List<taiKhoanDTO>();
            foreach (taiKhoanDTO user in allUsers)
            {
                if (user.MaLoai == bacSiRole.MaRole)
                {
                    listBacSi.Add(user);
                }
            }
            loadData_Vao_comboboxtenbs(listBacSi);

        }
        private void loadData_Vao_comboboxtenbs(List<taiKhoanDTO> listBacSi)
        {
            bacsi.DataSource = listBacSi;
            bacsi.ValueMember = "MaTK";  
            bacsi.DisplayMember = "Name";   
            bacsi.SelectedIndex = -1;      
        }
        private void load_ten(List<BenhNhanDTO> listBenhNhan, string mabn)
        {
            if (listBenhNhan == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                if (bn.MaBN.ToString() == mabn)
                {
                    hoten.Text = bn.TenBN;

                }
            }
        }

        private void mabenhnhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mabenhnhan.SelectedIndex < 0) return;
            //lấy mã đã được chọn
            string selectedMaBN = mabenhnhan.SelectedItem.ToString();
            //lấy danh sách bệnh nhân
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            load_ten(listBenhNhan, selectedMaBN);
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(mabenhnhan.Text) || bacsi.SelectedIndex < 0)
{
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }
            DateTime ngay = ngaykham.Value.Date;
            TimeSpan gio = giokham.Value.TimeOfDay;
            DateTime lichhen = ngay + gio;
            if (lichhen < DateTime.Now)
            {
                MessageBox.Show("Bạn đã chọn ngày/giờ trong quá khứ. Vui lòng chọn lại!",
                                "Ngày hẹn không hợp lệ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            lichHenDTO lh = new lichHenDTO();
            lh.MaDieuDuong = madd;
            lh.MaBenhNhan = mabenhnhan.Text;
            lh.MaTaiKhoan = bacsi.SelectedValue.ToString();
            lh.NgayHen = lichhen;
            lh.TrangThai = "Chờ khám";
            bool kq = lhBus.them(lh);
            if (kq == true)
            {
                System.Windows.Forms.MessageBox.Show("Đăng ký lịch hẹn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                load_Gird();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Đăng ký lịch hẹn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void load_Gird()
        {
            int stt = 1;
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            List<lichHenDTO> listLichHen = lhBus.select();
            List<taiKhoanDTO> listTaiKhoan = tkBus.select();
            DataTable table = new DataTable();
            table.Columns.Add("Số thứ tự", typeof(int));
            table.Columns.Add("Mã khám bệnh", typeof(string));
            table.Columns.Add("Mã bệnh nhân", typeof(string));
            table.Columns.Add("Tên bệnh nhân", typeof(string));
            table.Columns.Add("Tên bác sĩ", typeof(string));
            table.Columns.Add("Ngày hẹn", typeof(string));
            table.Columns.Add("Giờ hẹn", typeof(string));
            table.Columns.Add("Trạng thái", typeof(string));

            foreach (lichHenDTO lh in listLichHen)
            {
                DataRow row = table.NewRow();
                row["Số thứ tự"] = stt;
                row["Mã khám bệnh"] = lh.MaLichHen;
                foreach (BenhNhanDTO bn in listBenhNhan)
                {
                    if (bn.MaBN == lh.MaBenhNhan.ToString())
                    {
                        row["Mã bệnh nhân"] = bn.MaBN;
                        row["Tên bệnh nhân"] = bn.TenBN;
                        break;
                    }
                }
                foreach (taiKhoanDTO tk in listTaiKhoan)
                {
                    if (tk.MaTK.ToString() == lh.MaTaiKhoan)
                    {
                        row["Tên bác sĩ"] = tk.Name;
                        break;
                    }
                }
                row["Ngày hẹn"] = lh.NgayHen.ToString("dd/MM/yyyy");
                row["Giờ hẹn"] = lh.NgayHen.ToString("HH:mm");
                row["Trạng thái"] = lh.TrangThai;
                table.Rows.Add(row);
                stt += 1;
            }
            gird.DataSource = table.DefaultView;
            if (gird.Columns["Mã bệnh nhân"] != null)
                gird.Columns["Mã bệnh nhân"].Visible = false; // Ẩn cột Mã bệnh nhân
        }
        private void gird_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gird.Rows.Count)
            {
                DataGridViewRow row = gird.Rows[e.RowIndex];
                mabenhnhan.Text = row.Cells[2].Value.ToString();
                hoten.Text = row.Cells[3].Value.ToString();
                malichhen.Text = row.Cells[1].Value.ToString();
                bacsi.Text = row.Cells[4].Value.ToString();
                string ngay = row.Cells[5].Value.ToString();    // "dd/MM/yyyy"
                string gio = row.Cells[6].Value.ToString();     // "HH:mm"
                if (DateTime.TryParseExact($"{ngay} {gio}", "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime dt))
                {
                    ngaykham.Value = dt;
                    giokham.Value = dt;
                }
                else
                {
                    MessageBox.Show("Invalid date or time format.");
                }


            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            lh.MaLichHen = malichhen.Text;
            bool kq = lhBus.xoa(lh);
            if (!kq)
            {
                MessageBox.Show("Xóa lịch hẹn thất bại. Vui lòng kiểm tra lại dữ liệu.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Xóa lịch hẹn thành công.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                load_data();
                load_Gird();
            }
        }
    }
}
