using QLPKBUS;
using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPK
{
    public partial class DSLaySoKham : Form
    {
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        BenhNhanBUS bnBus = new BenhNhanBUS();
        lichHenBUS lhBus = new lichHenBUS();
        taiKhoanBUS tkBus = new taiKhoanBUS();
        private int stt;
        loaiTaiKhoanBUS loaitkBUS = new loaiTaiKhoanBUS();

        public DSLaySoKham()
        {
            InitializeComponent();
            nhapngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            load_data();    
            gird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void load_data()
        {
            stt = 1;
            bnBus = new BenhNhanBUS();
            lhBus = new lichHenBUS();
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            List<lichHenDTO> listlh = lhBus.select();
            List<taiKhoanDTO> listTK = tkBus.select();
            List<loaiTaiKhoanDTO> listLoaiTk = loaitkBUS.select();
            this.loadData_Vao_GridView(listBenhNhan, listlh, listTK, listLoaiTk);
        }
        private void loadData_Vao_GridView(List<BenhNhanDTO> listBenhNhan, List<lichHenDTO> listlh, List<taiKhoanDTO> listTK, List<loaiTaiKhoanDTO> listLoaiTk)
        {
            if (listBenhNhan == null || listlh == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("Số thứ tự", typeof(int));
            table.Columns.Add("Mã bệnh nhân", typeof(string));
            table.Columns.Add("Tên bệnh nhân", typeof(string));
            table.Columns.Add("Ngày khám", typeof(string));
            table.Columns.Add("Giờ khám", typeof(string));
            table.Columns.Add("Bác sĩ khám", typeof(string));
            table.Columns.Add("Trạng thái", typeof(string));
            table.Columns.Add("Nhân viên đăng ký", typeof(string));

            if (listBenhNhan != null && listlh != null && listTK != null && listLoaiTk != null)
            {
                foreach (BenhNhanDTO bn in listBenhNhan)
                {
                    foreach (lichHenDTO lh in listlh)
                    {
                        if (bn.MaBN == lh.MaBenhNhan)
                        {
                            string bacsi = "";
                            string trangthai = "";
                            DataRow row =  table.NewRow();
                            row["Số thứ tự"] = stt++;
                            row["Mã bệnh nhân"] = bn.MaBN;
                            row["Tên bệnh nhân"] = bn.TenBN;
                            row["Trạng thái"] = lh.TrangThai;
                            row["Ngày khám"] = lh.NgayHen.ToString("dd/MM/yyyy");
                            row["Giờ khám"] = lh.NgayHen.ToString("HH:mm");
                            foreach (taiKhoanDTO tk in listTK)
                            {
                                if (tk.MaTK.ToString() == lh.MaTaiKhoan)
                                {
                                    row["Bác sĩ khám"] = tk.Name;
 
                                }
                                if (tk.MaTK == lh.MaDieuDuong)
                                {
                                    row["Nhân viên đăng ký"] = tk.Name;
                                }
                            }
                            //foreach (loaiTaiKhoanDTO loaiTk in listLoaiTk)
                            //{
                            //    if (loaiTk.MaRole == ma)
                            //    {
                            //        bacsi = loaiTk.TenLoaiTaiKhoan;
                            //        if (lh.TrangThai == "Chờ khám")
                            //        {
                            //            trangthai = "Chờ khám";
                            //        }
                            //        else if (lh.TrangThai == "Đã khám")
                            //        {
                            //            trangthai = "Đã khám";
                            //        }
                            //        else
                            //        {
                            //            trangthai = "Hủy lịch hẹn";
                            //        }
                            //    }
                            //}
                            table.Rows.Add(row);
                        }
                    }
                }
            }
            gird.DataSource = table.DefaultView;
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            List<lichHenDTO> listlh = lhBus.select();
            List<taiKhoanDTO> listTK = tkBus.select();
            List<loaiTaiKhoanDTO> listLoaiTk = loaitkBUS.select();
            List<lichHenDTO> fill = new List<lichHenDTO>();
            foreach (lichHenDTO lh in listlh)
            {
                if (lh.NgayHen.Date == nhapngay.Value.Date)
                {
                    fill.Add(lh);
                }
            }
            stt = 1;
            loadData_Vao_GridView(listBenhNhan, fill, listTK, listLoaiTk);
        }
        private void btn_hoantac_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
