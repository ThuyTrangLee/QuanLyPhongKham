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
    public partial class DanhSachBenhNhan : Form
    {
        BenhNhanBUS bnBus = new BenhNhanBUS();
        PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
        BenhBUS beBus = new BenhBUS();
        ChandoanBUS cdBus = new ChandoanBUS();
        taiKhoanBUS tkBus = new taiKhoanBUS();
        private int stt;

        public DanhSachBenhNhan()
        {
            InitializeComponent();
            load_data();
            gird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void load_data()
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
            List<taiKhoanDTO> listTK = tkBus.select();
            this.loadData_Vao_GridView(listBenhNhan, listBenh, listpkb, listcd, listTK);
        }

        private void loadData_Vao_GridView(List<BenhNhanDTO> listBenhNhan, List<benhDTO> listBenh, List<phieukhambenhDTO> listpkb, List<chandoanDTO> listcd, List<taiKhoanDTO> listTK)
        {

            if (listBenhNhan == null || listpkb == null || listBenh == null || listcd == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }

            DataTable table = new DataTable();
            table.Columns.Add("Số thứ tự", typeof(int));
            table.Columns.Add("Mã phiếu khám", typeof(string));
            table.Columns.Add("Tên bệnh nhân", typeof(string));
            table.Columns.Add("CCCD", typeof(string));
            table.Columns.Add("Ngày khám", typeof(string));
            table.Columns.Add("Ngày tái khám", typeof(string));
            table.Columns.Add("Triệu chứng", typeof(string));
            table.Columns.Add("Tên bệnh", typeof(string));
            table.Columns.Add("Bác sĩ khám", typeof(string));
            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                foreach (phieukhambenhDTO pkb in listpkb)
                {
                    if (bn.MaBN == pkb.MaBenhNhan)
                    {
                        foreach (chandoanDTO cd in listcd)
                        {
                            if (pkb.MaPKB == cd.MaPkb)
                            {
                                foreach (benhDTO be in listBenh)
                                {
                                    if (cd.MaBenh == be.MaBenh)
                                    {
                                        DataRow row = table.NewRow();
                                        row["Số thứ tự"] = stt;
                                        row["Mã phiếu khám"] = pkb.MaPKB;
                                        row["Tên bệnh nhân"] = bn.TenBN;
                                        row["CCCD"] = bn.CanCuocCongDan;
                                        row["Ngày khám"] = DateTime.Parse(pkb.NgayKham.ToString()).ToString("dd/MM/yyyy");
                                        row["Ngày tái khám"] = DateTime.Parse(pkb.NgayTaiKham.ToString()).ToString("dd/MM/yyyy");   
                                        row["Triệu chứng"] = pkb.TrieuChung;
                                        row["Tên bệnh"] = be.TenBenh;
                                        foreach (taiKhoanDTO tk in listTK)
                                        {
                                            if (pkb.MBS == tk.MaTK)
                                            {
                                                row["Bác sĩ khám"] = tk.Name;

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
