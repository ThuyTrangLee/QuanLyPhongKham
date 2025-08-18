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
    public partial class DanhSachHoaDon : Form
    {
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        BenhNhanBUS bnBus = new BenhNhanBUS();
        PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
        BenhBUS beBus = new BenhBUS();
        ChandoanBUS cdBus = new ChandoanBUS();
        HoadonBUS hdBus = new HoadonBUS();
        taiKhoanBUS tkBus = new taiKhoanBUS();
        private int stt;
        public DanhSachHoaDon()
        {
            InitializeComponent();
            load_data();
            gird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void load_data()
        {
            stt = 1;
            bnBus = new BenhNhanBUS();
            beBus = new BenhBUS();
            pkbBus = new PhieukhambenhBUS();
            cdBus = new ChandoanBUS();
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            List<benhDTO> listBenh = beBus.select();
            List<phieukhambenhDTO> listpkb = pkbBus.select();
            List<chandoanDTO> listcd = cdBus.select();
            List<hoadonDTO> listhd = hdBus.select();
            List<taiKhoanDTO> listTK = tkBus.select();
            this.loadData_Vao_GridView(listBenhNhan, listBenh, listpkb, listcd, listhd, listTK);
        }
        private void loadData_Vao_GridView(List<BenhNhanDTO> listBenhNhan, List<benhDTO> listBenh, List<phieukhambenhDTO> listpkb, List<chandoanDTO> listcd, List<hoadonDTO> listhd, List<taiKhoanDTO> listTK)
        {

            if (listBenhNhan == null || listpkb == null || listBenh == null || listcd == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }
            // Sắp xếp mã phiếu khám tăng dần
            listpkb.Sort((x, y) => int.Parse(x.MaPKB).CompareTo(int.Parse(y.MaPKB))); //so sánh pkb x voi y dung bieu thuc landa
            DataTable table = new DataTable();
            table.Columns.Add("Số thứ tự", typeof(int));
            table.Columns.Add("Tên bệnh nhân", typeof(string));
            table.Columns.Add("Ngày khám", typeof(string));
            table.Columns.Add("Ngày tái khám", typeof(string));
            table.Columns.Add("Tiền khám", typeof(string));
            table.Columns.Add("Tiền thuốc", typeof(string));
            table.Columns.Add("Tổng tiền", typeof(string));
            table.Columns.Add("Ngày lập", typeof(string));
            table.Columns.Add("Nhân viên thu ngân", typeof(string));
            int stt = 1;

            foreach (phieukhambenhDTO pkb in listpkb)
            {
                foreach (BenhNhanDTO bn in listBenhNhan)
                {
                    if (bn.MaBN == pkb.MaBenhNhan)
                    {
                        foreach (chandoanDTO cd in listcd)
                        {
                            if (cd.MaPkb == pkb.MaPKB)
                            {
                                foreach (hoadonDTO hd in listhd)
                                {
                                    if (hd.MaPKB == pkb.MaPKB)
                                    {
                                        DataRow row = table.NewRow();
                                        row["Số thứ tự"] = stt;
                                        row["Tên bệnh nhân"] = bn.TenBN;
                                        row["Ngày khám"] = pkb.NgayKham.ToString("dd/MM/yyyy");

                                        if (pkb.NgayTaiKham != null)
                                        {
                                            row["Ngày tái khám"] = pkb.NgayTaiKham.ToString("dd/MM/yyyy");
                                        }
                                        else
                                        {
                                            row["Ngày tái khám"] = "Chưa có";
                                        }

                                        row["Tiền khám"] = hd.TienKham.ToString("N0", culture);
                                        row["Tiền thuốc"] = hd.TienThuoc.ToString("N0", culture);
                                        row["Tổng tiền"] = hd.TongTien.ToString("N0", culture);
                                        row["Ngày lập"] = hd.NgayLapHoaDon.ToString("dd/MM/yyyy");

                                        foreach (taiKhoanDTO tk in listTK)
                                        {
                                            if (tk.MaTK == hd.MaNVTN)
                                            {
                                                row["Nhân viên thu ngân"] = tk.Name;
                                            }
                                        }

                                        table.Rows.Add(row);
                                        stt += 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            gird.DataSource = table.DefaultView;
        }
    }
}
