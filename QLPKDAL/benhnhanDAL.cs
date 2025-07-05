using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPKDTO;



namespace QLPKDAL
{
    public class BenhNhanDAL
    {
        private string connectionString;

        public BenhNhanDAL()
        {
            // Đọc chuỗi kết nối từ cấu hình ứng dụng
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        // Thuộc tính cho chuỗi kết nối
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        // Phương thức chọn tất cả các bệnh nhân
        public List<BenhNhanDTO> select()
        {
            // Chuỗi truy vấn SQL để chọn tất cả các bệnh nhân
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [BenhNhan]";

            List<BenhNhanDTO> lsBenhNhan = new List<BenhNhanDTO>(); // Danh sách để chứa kết quả

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con; // Kết nối lệnh với cơ sở dữ liệu
                    cmd.CommandType = System.Data.CommandType.Text; // Kiểu lệnh là văn bản
                    cmd.CommandText = query; // Gán chuỗi truy vấn cho lệnh

                    try
                    {
                        con.Open(); // Mở kết nối
                        SqlDataReader reader = cmd.ExecuteReader(); // Thực thi lệnh và nhận kết quả
                        if (reader.HasRows)
                        {
                            while (reader.Read()) // Đọc từng dòng kết quả
                            {
                                BenhNhanDTO bn = new BenhNhanDTO(); // Tạo đối tượng BenhNhanDTO
                                bn.MaBN = reader["maBenhNhan"].ToString(); // Gán giá trị cho MaBN
                                bn.TenBN = reader["tenBenhNhan"].ToString(); // Gán giá trị cho TenBN
                                bn.GtBN = reader["gioiTinh"].ToString(); // Gán giá trị cho GtBN
                                bn.NgsinhBN = DateTime.Parse(reader["ngaySinh"].ToString()); // Gán giá trị cho NgsinhBN
                                bn.DiachiBN = reader["diaChi"].ToString(); // Gán giá trị cho DiachiBN
                                lsBenhNhan.Add(bn); // Thêm vào danh sách
                            }
                        }
                        con.Close(); // Đóng kết nối
                    }
                    catch (Exception)
                    {
                        con.Close(); // Đóng kết nối khi có lỗi
                        return null; // Trả về null nếu có lỗi
                    }
                }
            }
            return lsBenhNhan;
        }
        // Phương thức chọn bệnh nhân theo từ khóa
        public List<BenhNhanDTO> SelectByKeyWord(string sKeyword)
        {
            // Chuỗi truy vấn SQL để chọn bệnh nhân theo từ khóa
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [BenhNhan] ";
            query += "WHERE (maBenhNhan LIKE CONCAT('%',@sKeyword,'%')) ";
            query += "OR (tenBenhNhan LIKE CONCAT('%',@sKeyword,'%')) ";
            query += "OR (ngaySinh LIKE CONCAT('%',@sKeyword,'%')) ";

            List<BenhNhanDTO> lsBenhNhan = new List<BenhNhanDTO>(); // Danh sách để chứa kết quả

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con; // Kết nối lệnh với cơ sở dữ liệu
                    cmd.CommandType = System.Data.CommandType.Text; // Kiểu lệnh là văn bản
                    cmd.CommandText = query; // Gán chuỗi truy vấn cho lệnh
                    cmd.Parameters.AddWithValue("@sKeyword", sKeyword); // Thêm tham số cho lệnh SQL

                    try
                    {
                        con.Open(); // Mở kết nối
                        SqlDataReader reader = cmd.ExecuteReader(); // Thực thi lệnh và nhận kết quả
                        if (reader.HasRows)
                        {
                            while (reader.Read()) // Đọc từng dòng kết quả
                            {
                                BenhNhanDTO bn = new BenhNhanDTO(); // Tạo đối tượng BenhNhanDTO
                                bn.MaBN = reader["maBenhNhan"].ToString(); // Gán giá trị cho MaBN
                                bn.TenBN = reader["tenBenhNhan"].ToString(); // Gán giá trị cho TenBN
                                bn.GtBN = reader["gioiTinh"].ToString(); // Gán giá trị cho GtBN
                                bn.NgsinhBN = DateTime.Parse(reader["ngaySinh"].ToString()); // Gán giá trị cho NgsinhBN
                                bn.DiachiBN = reader["diaChi"].ToString(); // Gán giá trị cho DiachiBN
                                lsBenhNhan.Add(bn); // Thêm vào danh sách
                            }
                        }
                        con.Close(); // Đóng kết nối
                    }
                    catch (Exception)
                    {
                        con.Close(); // Đóng kết nối khi có lỗi
                        return null; // Trả về null nếu có lỗi
                    }
                }
            }
            return lsBenhNhan;
        }

    }
}
