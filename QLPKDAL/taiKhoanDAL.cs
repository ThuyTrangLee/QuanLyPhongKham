using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDAL
{
    public class taiKhoanDAL
    {
        
        private string connectionString;
        public taiKhoanDAL()
        {
            //khởi tạo chuỗi kết nối từ file cấu hình
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value;}
        public List<taiKhoanDTO> select()
        {
            //khởi tạo chuỗi rổng
            string query = string.Empty;
            //câu lệnh truy vấn
            query += "SELECT *";
            query += " FROM TaiKhoan";
            List<taiKhoanDTO> lsTK= new List<taiKhoanDTO>();

            //tạo kết nối đến cơ sở dữ liệu SQL Server
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                //tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                using (SqlCommand cmd = new SqlCommand())
                {
                    //gán kết nối cho SqlCommand
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text; // chỉ định loại câu lệnh là văn bản (text)
                    cmd.CommandText = query;

                    try
                    {
                        //mở kết nối đến cơ sở dữ liệu
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        //kiểm tra xem có dữ liệu trả về hay không
                        if (reader.HasRows == true)
                        {
                            //nếu có dữ liệu thì đọc từng dòng dữ liệu
                            while (reader.Read())
                            {
                                taiKhoanDTO tk = new taiKhoanDTO();
                                tk.Name = reader["Name"].ToString();
                                tk.Username = reader["username"].ToString();
                                tk.Password = reader["password"].ToString();
                                tk.MaLoai = int.Parse(reader["maRole"].ToString());
                                tk.MaTK = int.Parse(reader["maTaiKhoan"].ToString());


                                lsTK.Add(tk);
                            }
                        }
                        con.Close();
                        con.Dispose(); // giải phóng tài nguyên kết nối
                    }
                    catch(Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsTK;
        }



    }
}
