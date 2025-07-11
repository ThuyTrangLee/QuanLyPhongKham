using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace QLPKDAL
{

    public class HoadonDAL
    {
        private string connectionString;
        public HoadonDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public List<hoadonDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [HoaDon]";

            List<hoadonDTO> lsHoaDon = new List<hoadonDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                hoadonDTO hd = new hoadonDTO();
                                hd.MaHoaDon = int.Parse(reader["maHoaDon"].ToString());
                                hd.NgayLapHoaDon = DateTime.Parse(reader["NgayLapHoaDon"].ToString());
                                hd.TienThuoc = decimal.Parse(reader["tienThuoc"].ToString());
                                hd.TongTien = float.Parse(reader["tongTien"].ToString());
                                hd.TienKham = float.Parse(reader["tienKham"].ToString());
                                hd.MaPKB = reader["maPKB"].ToString();
                                hd.MaNVTN = int.Parse(reader["maTaiKhoan"].ToString());

                                lsHoaDon.Add(hd);

                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsHoaDon;
        }
        public int sobenhnhan(string ngayLapHoaDon)
        {
            int sobn = 0;
            string query = string.Empty;
            query += "SELECT count (HD.maHoaDon) as sobn FROM HoaDon HD WHERE HD.NgayLapHoaDon=@NgayLapHoaDon";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@NgayLapHoaDon", ngayLapHoaDon);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                sobn = int.Parse(reader["sobn"].ToString());

                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return 0;
                    }
                }
            }
            return sobn;
        }
        public decimal tienthuoc(hoadonDTO hd, string maPKB)
        {
            decimal tien = 0;
            string query = string.Empty;
            query += "SELECT SUM(TH.donGia * KT.soLuong) AS TIENTHUOC ";
            query += "FROM PhieuKhamBenh PKB ";
            query += "JOIN ToaThuoc T ON PKB.maPKB = T.maPKB ";
            query += "JOIN KeThuoc KT ON T.maToaThuoc = KT.maToaThuoc ";
            query += "JOIN Thuoc TH ON KT.maThuoc = TH.maThuoc ";
            query += "WHERE PKB.maPKB = @maPKB";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maPKB", maPKB);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["TIENTHUOC"] != DBNull.Value)
                                {
                                    tien = decimal.Parse(reader["TIENTHUOC"].ToString());
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error calculating medication cost: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            return tien;
        }
        public int autogenerate_mahd()
        {
            int mahd = 1;
            string query = string.Empty;
            query += "SELECT MAX (KQ.MAHoaDon) AS MM from (SELECT CONVERT(float, HoaDon.maHoaDon) AS MAHoaDon FROM HoaDon) AS KQ";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                mahd = int.Parse(reader["MM"].ToString()) + 1;
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();

                    }
                }
            }
            return mahd;
        }
        public float tienkham()
        {
            float tien = 0;
            string query = "SELECT tienDichVu FROM DichVu WHERE tenDichVu = @tenDichVu";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@tenDichVu", "Kham benh");

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            tien = Convert.ToSingle(result);
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle exception (optional: log the exception)
                        con.Close();
                    }
                }
            }
            return tien;
        }
    }

}
