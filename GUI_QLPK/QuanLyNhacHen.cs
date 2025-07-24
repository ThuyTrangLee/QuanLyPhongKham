using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using QLPKBUS;
using QLPKDTO;
using iText.Layout.Element;


namespace GUI_QLPK
{
    public partial class QuanLyNhacHen : Form
    {
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        BenhNhanBUS bnBus = new BenhNhanBUS();
        PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
        private int stt;

        public QuanLyNhacHen()
        {
            InitializeComponent();
            trangthaigui.SelectedIndex = 0; // Mặc định chọn "Tất cả"
            TimVaGuiMailNhacHen();
            load_data();
            gird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void load_data()
        {
            stt = 1;
            bnBus = new BenhNhanBUS();
            pkbBus = new PhieukhambenhBUS();
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            List<phieukhambenhDTO> listPhieuKham = pkbBus.select();
            this.loadData_Vao_GridView(listBenhNhan, listPhieuKham);
        }
        private void loadData_Vao_GridView(List<BenhNhanDTO> listBenhNhan, List<phieukhambenhDTO> listPKB)
        {
            if (listBenhNhan == null || listPKB == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("Số thứ tự", typeof(int));
            table.Columns.Add("Mã bệnh nhân", typeof(string));
            table.Columns.Add("Tên bệnh nhân", typeof(string));
            table.Columns.Add("Ngày tái khám", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Đã gửi mail", typeof(bool)); ;

            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                foreach (phieukhambenhDTO pkb in listPKB)
                {
                    if (bn.MaBN.ToString() == pkb.MaBenhNhan)
                    {
                        DataRow row = table.NewRow();
                        row["Số thứ tự"] = stt;
                        row["Mã bệnh nhân"] = pkb.MaPKB;
                        row["Tên bệnh nhân"] = bn.TenBN;
                        row["Ngày tái khám"] = pkb.NgayTaiKham.ToString("dd/MM/yyyy");
                        row["Email"] = bn.Email;
                        row["Đã gửi mail"] = pkb.DaGuiMail;
                        table.Rows.Add(row);
                        stt += 1;
                    }
                    
                }
            }

            gird.DataSource = table;
        }
        /// <summary>
        /// 1. Tìm tất cả lịch hẹn 2 ngày sau
        /// 2. Gửi mail(nếu chưa gửi và có email)
        /// 3. Cập nhật cờ DaGuiMail
        /// </summary>
        private void TimVaGuiMailNhacHen()
        {
            DateTime ngayHienTai = DateTime.Now.Date;
            DateTime ngayCanNhac = ngayHienTai.AddDays(2);

            List<phieukhambenhDTO> lishPKB = pkbBus.select();
            List<BenhNhanDTO> tatCaBN = bnBus.select();

            foreach (phieukhambenhDTO pkb in lishPKB)
            {
                // chỉ quan tâm ngày hẹn đúng 2 ngày sau
                if (pkb.NgayTaiKham.Date == ngayCanNhac)
                {
                    // chỉ xử lý nếu chưa gửi
                    if (!pkb.DaGuiMail)
                    {
                        // tìm thông tin bệnh nhân
                        BenhNhanDTO bn = null;
                        foreach (BenhNhanDTO item in tatCaBN)
                        {
                            if (item.MaBN.ToString() == pkb.MaBenhNhan)
                            {
                                bn = item;
                                break;
                            }
                        }
                        if (bn != null && !String.IsNullOrEmpty(bn.Email))
                        {
                            bool guiThanhCong = GuiMailReminder(bn.Email, bn.TenBN, pkb.NgayTaiKham);
                            if (guiThanhCong)
                            {
                                // cập nhật DB
                                pkbBus.CapNhatDaGuiMail(pkb.MaPKB, true);
                                // đánh dấu luôn trong object để hiển thị
                                pkb.DaGuiMail = true;
                            }
                        }
                    }
                }
            }
        }
        private bool GuiMailReminder(string toEmail, string tenBN, DateTime ngayHen)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("2251050074trang@ou.edu.vn", "Phòng khám tư nhân");
                msg.To.Add(new MailAddress(toEmail));
                msg.Subject = "Nhắc lịch tái khám";
                msg.Body = "Chào " + tenBN + ",\n\n" +
                           "Bạn có lịch tái khám vào ngày " + ngayHen.ToString("dd/MM/yyyy") + ".\n" +
                           "Xin vui lòng thu xếp thời gian.\n\n" +
                           "Trân trọng,\nPhòng khám Trang";
                msg.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(
                    "httranggg@gmail.com",
                    "ycib qlhn mffw sbqi"
                );
                //smtp.Credentials = new NetworkCredential(
                //    "dealinetoi@gmail.com",
                //    "rtos kcqi bueq nfnd"
                //);
                smtp.Send(msg);
                MessageBox.Show("Gửi mail thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Gửi mail thất bại: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Chi tiết lỗi: " + ex.ToString(), "Lỗi gửi mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string luaChon = trangthaigui.SelectedItem.ToString();

            List<BenhNhanDTO> danhSachBN = bnBus.select();
            List<phieukhambenhDTO> danhSachPKB = pkbBus.select();
            List<phieukhambenhDTO> ketQuaLoc = new List<phieukhambenhDTO>();

            foreach (phieukhambenhDTO pkb in danhSachPKB)
            {
                if (luaChon == "Tất cả")
                {
                    ketQuaLoc.Add(pkb);
                }
                else if (luaChon == "Đã gửi" && pkb.DaGuiMail)
                {
                    ketQuaLoc.Add(pkb);
                }
                else if (luaChon == "Chưa gửi" && !pkb.DaGuiMail)
                {
                    ketQuaLoc.Add(pkb);
                }
            }

            // Gọi lại hàm hiển thị
            loadData_Vao_GridView(danhSachBN, ketQuaLoc);
        }
    }
}
