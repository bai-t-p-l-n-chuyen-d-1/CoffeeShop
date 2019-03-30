using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using DTO;

namespace DAO
{
    public class DAO_Invoice
    {
        private DataProvider dp;

        public DAO_Invoice()
        {
            dp = new DataProvider();
        }

        

        public DataTable GetTheoSoBan(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, dp.cnn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        public List<DTO_Invoice> GetInvoiceDAO(string sql)
        {
            List<DTO_Invoice> list = new List<DTO_Invoice>();
            SqlCommand cmd = new SqlCommand(sql, dp.cnn);
            SqlDataReader dr;
            int MaHoaDon;
            int MaMonNuoc;
            int MaBan;
            dp.Connect();
            //SqlConnection cnn = dp.getConnect();
            //cnn.Open();
            try
            {
                dr = cmd.ExecuteReader();
                //SqlDataReader dr = dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    MaHoaDon = dr.GetInt32(0);
                    MaMonNuoc = dr.GetInt32(1);
                    MaBan = dr.GetInt32(2);                                      
                    DTO_Invoice prod = new DTO_Invoice(MaHoaDon, MaMonNuoc, MaBan);
                    list.Add(prod);
                }
                return list;
            }
            catch (SqlException ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                dp.DisConnect();
            }
        }
        public void Add_MonNuoc(int mamonnuoc, int maban)
        {
            try
            {
                dp.Connect();
                string query = "Insert into HoaDon (MaMonNuoc, MaBan) values ('" + mamonnuoc + "','" + maban + "' )";
                SqlCommand cmd = new SqlCommand(query, dp.cnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dp.DisConnect();
            }
        }
    }
}
