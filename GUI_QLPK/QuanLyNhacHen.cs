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
        lichHenBUS lhBus = new lichHenBUS();
        private int stt;

        public QuanLyNhacHen()
        {
            InitializeComponent();
            TimVaGuiMailNhacHen();
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
            this.loadData_Vao_GridView(listBenhNhan, listlh);
        }
        private void loadData_Vao_GridView(List<BenhNhanDTO> listBenhNhan, List<lichHenDTO> listlh)
        {
            if (listBenhNhan == null || listlh == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("Số thứ tự", typeof(int));
            table.Columns.Add("Mã lịch hẹn", typeof(string));
            table.Columns.Add("Tên bệnh nhân", typeof(string));
            table.Columns.Add("Ngày hẹn", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Đã gửi mail", typeof(bool)); ;

            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                foreach (lichHenDTO lh in listlh)
                {
                    if (bn.MaBN.ToString() == lh.MaBenhNhan)
                    {
                        DataRow row = table.NewRow();
                        row["Số thứ tự"] = stt;
                        row["Mã lịch hẹn"] = lh.MaLichHen;
                        row["Tên bệnh nhân"] = bn.TenBN;
                        row["Ngày hẹn"] = lh.NgayHen.ToString("dd/MM/yyyy");
                        row["Email"] = bn.Email;
                        row["Đã gửi mail"] = lh.DaGuiMail;
                        table.Rows.Add(row);
                        stt += 1;
                    }
                    
                }
            }

            gird.DataSource = table;
        }
        /// <summary>
        /// 1. Tìm tất cả lịch hẹn 2 ngày sau
        /// 2. Gửi mail (nếu chưa gửi và có email)
        /// 3. Cập nhật cờ DaGuiMail
        /// </summary>
        private void TimVaGuiMailNhacHen()
        {
            DateTime ngayHienTai = DateTime.Now.Date;
            DateTime ngayCanNhac = ngayHienTai.AddDays(2);

            List<lichHenDTO> tatCaLich = this.lhBus.select();
            List<BenhNhanDTO> tatCaBN = this.bnBus.select();

            foreach (lichHenDTO lich in tatCaLich)
            {
                // chỉ quan tâm ngày hẹn đúng 2 ngày sau
                if (lich.NgayHen.Date == ngayCanNhac)
                {
                    // chỉ xử lý nếu chưa gửi
                    if (!lich.DaGuiMail)
                    {
                        // tìm thông tin bệnh nhân
                        BenhNhanDTO bn = null;
                        foreach (BenhNhanDTO item in tatCaBN)
                        {
                            if (item.MaBN.ToString() == lich.MaBenhNhan)
                            {
                                bn = item;
                                break;
                            }
                        }
                        if (bn != null && !String.IsNullOrEmpty(bn.Email))
                        {
                            bool guiThanhCong = this.GuiMailReminder(bn.Email, bn.TenBN, lich.NgayHen);
                            if (guiThanhCong)
                            {
                                // cập nhật DB
                                this.lhBus.CapNhatDaGuiMail(lich.MaLichHen, true);
                                // đánh dấu luôn trong object để hiển thị
                                lich.DaGuiMail = true;
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

                SmtpClient smtp = new SmtpClient("smtp.ou.edu.vn", 587);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(
                    "2251050074trang@ou.edu.vn",
                    "trang4869744@"
                );

                smtp.Send(msg);
                MessageBox.Show("Gửi mail thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi mail thất bại: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        } 
    }
}
