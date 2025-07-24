using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace QLPKDAL
{
    public class lichHenDAL
    {
        private string connectionString;
        public lichHenDAL()
        {
            connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public List<lichHenDTO> select()
        {
            string query = "SELECT * FROM [LichHen]";
            List<lichHenDTO> lslichHen = new List<lichHenDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            lichHenDTO lh = new lichHenDTO();
                            lh.MaLichHen = reader["maLichHen"].ToString();
                            lh.MaBenhNhan = reader["maBenhNhan"].ToString();
                            lh.MaTaiKhoan = reader["maTaiKhoan"].ToString();
                            lh.MaDieuDuong = int.Parse(reader["maDieuDuong"].ToString());
                            lh.NgayHen = DateTime.Parse(reader["ngayHen"].ToString());
                            lh.TrangThai = reader["trangThai"].ToString();
                            lslichHen.Add(lh);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return lslichHen;
        }
        public bool them(lichHenDTO lh)
        {
            string query = string.Empty;
            query = "INSERT INTO [LichHen] (maBenhNhan, maTaiKhoan, ngayHen, trangThai, maDieuDuong) VALUES (@maBenhNhan, @maTaiKhoan, @ngayHen, @trangThai, @maDieuDuong)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maBenhNhan", lh.MaBenhNhan);
                    cmd.Parameters.AddWithValue("@maTaiKhoan", lh.MaTaiKhoan);
                    cmd.Parameters.AddWithValue("@maDieuDuong", lh.MaDieuDuong);
                    cmd.Parameters.AddWithValue("@ngayHen", lh.NgayHen);
                    cmd.Parameters.AddWithValue("@trangThai", lh.TrangThai);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }
            return true;
        }
        //tự động tạo mã lịch hẹn
        public int AutoGenerateMaLichHen()
        {
            int maLichHen = 1;
            string query = "";
            query += "SELECT MAX(maLichHen) AS MaxMaLH FROM[LichHen]";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            maLichHen = int.Parse(reader["MaxMaLH"].ToString()) + 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return maLichHen;
        }
        public bool xoa(lichHenDTO lh)
        {
            string query = string.Empty;
            query += "delete from [LichHen]";
            query += "where maLichHen=@maLichHen";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maLichHen", lh.MaLichHen);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }

                return true;
            }
        }
        public bool CapNhatTrangThai(int maLichHen, string trangThaiMoi)
        {
            string query = "UPDATE LichHen SET trangThai = @trangThai WHERE maLichHen = @maLichHen";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@trangThai", trangThaiMoi);
                cmd.Parameters.AddWithValue("@maLichHen", maLichHen);
                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
        public bool CapNhatTrangThai(string maBenhNhan, DateTime ngayHen, string trangThaiMoi)
        {
            string query = "UPDATE LichHen SET TrangThai = @trangThaiMoi WHERE MaBenhNhan = @maBenhNhan AND CAST(NgayHen AS DATE) = @ngayHen";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@trangThaiMoi", trangThaiMoi);
                cmd.Parameters.AddWithValue("@maBenhNhan", maBenhNhan);
                cmd.Parameters.AddWithValue("@ngayHen", ngayHen.Date);  // chỉ lấy phần ngày

                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
        public List<lichHenDTO> selectByDate(DateTime ngay)
        {
            string query = "SELECT * FROM LichHen WHERE CAST(NgayHen AS DATE) = @ngay";
            List<lichHenDTO> ds = new List<lichHenDTO>();

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ngay", ngay.Date);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lichHenDTO lh = new lichHenDTO();
                    lh.MaLichHen = reader["maLichHen"].ToString();
                    lh.MaBenhNhan = reader["maBenhNhan"].ToString();
                    lh.MaTaiKhoan = reader["maTaiKhoan"].ToString();
                    lh.MaDieuDuong = int.Parse(reader["maDieuDuong"].ToString());
                    lh.NgayHen = DateTime.Parse(reader["ngayHen"].ToString());
                    lh.TrangThai = reader["trangThai"].ToString();
                    ds.Add(lh);
                }
            }

            return ds;
        }
  

    }
}
