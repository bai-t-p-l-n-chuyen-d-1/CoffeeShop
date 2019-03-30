using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

using DTO;

namespace DAO
{
    public class DAO_Order
    {
        private DataProvider dp;
        public DAO_Order()
        {
            dp = new DataProvider();
        }

        public decimal GETMONEY(int ID)
        {
            try
            {
                string sql = "select * from dbo.MonNuoc where MaMonNuoc = " + ID;
                SqlDataReader dr = dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    return dr.GetDecimal(dr.GetOrdinal("GiaTien"));
                }
            }
            catch
            {

            }

            return 0;
        }

        public List<DTO_Order> GetMenu()
        {
            List<DTO_Order> list = new List<DTO_Order>();
            int mamonnuoc;
            decimal giatien;
            string tenmonnuoc, donvi;
            
            //dp.Connect();     
            try
            {
                string sql = "SELECT * FROM MonNuoc";
                SqlDataReader dr = dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    mamonnuoc = dr.GetInt32(0);
                    tenmonnuoc = dr.GetString(1);
                    giatien = dr.GetDecimal(2);
                    donvi = dr.GetString(3);

                    DTO_Order emp = new DTO_Order(mamonnuoc, tenmonnuoc, giatien, donvi);
                    list.Add(emp);
                }
                dr.Close();
                return list;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                dp.DisConnect();
            }
        }

        public void XoaMon(DTO_Order dm, int maban)
        {

            SqlConnection cnn = dp.getConnect();
            dp.Connect();//ham nay de ket noi thay thi cnn.open();
            string XoaMon = "DELETE FROM HoaDon WHERE MaMonNuoc = '" + dm.MaMonNuoc + "'" + "and MaBan ='" + maban + "'";
            SqlCommand cmd = new SqlCommand(XoaMon, cnn);
            cmd.ExecuteNonQuery();
        }

    }
}
