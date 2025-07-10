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
    public class ChiTietToaThuocDAL
    {
        private string connectionString;
        public ChiTietToaThuocDAL() 
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value;}
        public bool kethuoc(ChiTietToaThuocDTO kt)
        {
            string query = string.Empty;
            query += "INSERT INTO [ChiTietDonThuoc] ([maToaThuoc], [maThuoc],[soLuong])";
            query += "VALUES (@maToaThuoc,@maThuoc,@soLuong)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maToaThuoc", kt.MaToa);
                    cmd.Parameters.AddWithValue("@maThuoc", kt.MaThuoc);
                    cmd.Parameters.AddWithValue("@soLuong", kt.SoLuong);

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
            }
            return true;
        }
        public List<ChiTietToaThuocDTO> selectbypkb(string mapkb)
        {
            string query = @"
            SELECT KT.maToaThuoc, KT.maThuoc, KT.soLuong 
            FROM PhieuKhamBenh PKB 
            JOIN ToaThuoc T ON PKB.maPKB = T.maPKB 
            JOIN ChiTietDonThuoc KT ON T.maToaThuoc = KT.maToaThuoc 
            JOIN Thuoc TH ON KT.maThuoc = TH.maThuoc 
            WHERE PKB.maPKB = @mapkb";

            List<ChiTietToaThuocDTO> lskethuoc = new List<ChiTietToaThuocDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@mapkb", mapkb);
                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    ChiTietToaThuocDTO kt = new ChiTietToaThuocDTO();
                                    kt.SoLuong = int.Parse(reader["soLuong"].ToString());
                                    kt.MaToa = reader["maToaThuoc"].ToString();
                                    kt.MaThuoc = reader["maThuoc"].ToString();
                                    lskethuoc.Add(kt);
                                }
                            }
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        con.Close();
                        return null;
                    }
                }
            }
            return lskethuoc;
        }
    }
}
