using QLPKBUS;
using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QLPK
{
    public partial class BaoCaoDoanhThu : Form
    {
        HoadonBUS hdBus = new HoadonBUS();
        public int stt;
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
            gird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            nam.SelectedItem = "2025";
            thang.SelectedItem = "7";
        }
        public void load_data()
        {
            stt = 1;
            string month= thang.Text.ToString();
            string year = nam.Text.ToString();
            hdBus = new HoadonBUS();
            List<hoadonDTO> listHoadonMonth = hdBus.selectByMonth(month, year);
            this.loadData_Vao_GirdView(listHoadonMonth);
            Dictionary<string, float> dataByMonth = new Dictionary<string, float>();
            for(int mon = 1; mon <= 12; mon++)
            {
                //lấy tên tháng bằng culture hiện tại
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mon);
                //lấy doanh thu tháng hiện tại
                float doanhthu = hdBus.doanhthuMonth(mon.ToString(), year);
                if(doanhthu > 0)
                {
                    dataByMonth.Add(monthName, doanhthu);
                }
            }
            //xóa all dữ liệu 
            chart1.Series.Clear();
            //xóa khu vực biểu đồ
            chart1.ChartAreas.Clear();
            //tạo series mới
            ChartArea chartArea = chart1.ChartAreas.Add("chartArea");

            // 3) Tạo series mới kiểu Column
            Series series = chart1.Series.Add("Doanh thu năm " + year);
            series.ChartType = SeriesChartType.Column;

            // 4) Cấu hình trục X
            chartArea.AxisX.IsLabelAutoFit = true;
            chartArea.AxisX.Interval = 1;                  // mỗi tháng một nhãn
            chartArea.AxisX.LabelStyle.Angle = -45;         // xoay nghiêng 45° cho dễ đọc

            foreach (KeyValuePair<string, float> item in dataByMonth)
            {
                series.Points.AddXY(item.Key, item.Value);
            }


            Dictionary<string, float> dataByDate = new Dictionary<string, float>();
            for (int day = 1; day <= DateTime.DaysInMonth(int.Parse(year), int.Parse(month)); day++)
            {
                string ngayLapHD = new DateTime(int.Parse(year), int.Parse(month), day).ToString("yyyy-MM-dd");
                float doanhThu = float.Parse(hdBus.doanhthu(ngayLapHD).ToString());

                if (doanhThu > 0)
                {
                    dataByDate.Add(ngayLapHD, doanhThu);
                }
            }

            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            ChartArea chartArea2 = chart2.ChartAreas.Add("chartArea");
            Series series2 = chart2.Series.Add("Doanh thu tháng " + month);
            series2.ChartType = SeriesChartType.Column;

            foreach (var item in dataByDate)
            {
                series2.Points.AddXY(item.Key, item.Value);
            }
        }
        private void loadData_Vao_GirdView(List<hoadonDTO> listhoadon)
        {
            if (listhoadon == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            decimal tongdoanhthu = 0;
            DataTable table = new DataTable();
            table.Columns.Add("Số Thứ Tự", typeof(int));
            table.Columns.Add("Ngày Lập Hóa Đơn", typeof(string));
            table.Columns.Add("Số Bệnh Nhân", typeof(int));
            table.Columns.Add("Doanh Thu", typeof(string));
            table.Columns.Add("Tỷ Lệ", typeof(string));
            // Tính tổng doanh thu
            foreach (hoadonDTO hd in listhoadon)
            {
                string ngkham = DateTime.Parse(hd.NgayLapHoaDon.ToString()).ToString("yyyy-MM-dd");
                tongdoanhthu += decimal.Parse(hdBus.doanhthu(ngkham).ToString());
            }
            foreach(hoadonDTO hd in listhoadon)
            {
                DataRow row = table.NewRow();
                //format cho ngày tháng
                string ngkham = DateTime.Parse(hd.NgayLapHoaDon.ToString()).ToString("yyyy-MM-dd");
                row["Ngày Lập Hóa Đơn"] = DateTime.Parse(ngkham.ToString()).ToString("dd-MM-yyyy");
                //lấy số bệnh nhân trong ngày
                row["Số Bệnh Nhân"] = int.Parse(hdBus.sobenhnhan(ngkham).ToString());
                //lấy doanh thu trong ngày và chuyển đổi sang chuỗi
                string valueDoanhthu = hdBus.doanhthu(ngkham).ToString(CultureInfo.InvariantCulture);
                decimal parsedDoanhthu;
                // Format doanh thu với "en-US" culture. Có dấu phân cách số
                if (decimal.TryParse(valueDoanhthu, NumberStyles.Number, culture, out parsedDoanhthu))
                {
                    // Chuyển đổi doanh thu sang chuỗi với định dạng "N0" (số nguyên không có phần thập phân)
                    row["Doanh Thu"] = parsedDoanhthu.ToString("N0", culture);
                }
                // Tính tỷ lệ doanh thu so với tổng doanh thu
                row["Tỷ Lệ"] = Math.Round(((double)float.Parse(hdBus.doanhthu(ngkham).ToString()) / (double)tongdoanhthu) * 100, 2).ToString() + "%";
                row["Số Thứ Tự"] = stt;
                table.Rows.Add(row);
                stt += 1;
            }
            gird.DataSource = table.DefaultView;
        }

        private void xem_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
