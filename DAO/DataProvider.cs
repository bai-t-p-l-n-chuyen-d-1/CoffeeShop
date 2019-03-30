using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAO
{
    public class DataProvider
    {
        string cnStr = "Data Source=.;Initial Catalog=QLCaPhe;Integrated Security=True";
        public SqlConnection cnn;
        public DataProvider()
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cnn = new SqlConnection(cnStr);
        }
        public SqlConnection getConnect()
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cnn = new SqlConnection(cnStr);
            return cnn;
        }

        public SqlCommand CountLogin()
        {
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan.Username =@username AND TaiKhoan.Password = @password";
            return new SqlCommand(sql, cnn);
        }

        /// <summary>
        /// Hàm Connect() để mở kết nối, nếu có lỗi xảy ra thì sẽ ném ra lỗi
        /// </summary>
        public void Connect()
        {
            try
            {
                if (cnn != null && cnn.State == ConnectionState.Closed)
                    cnn.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Hàm DisConnect() để đóng kết nối, nếu có lỗi xảy ra thì sẽ ném ra lỗi
        /// </summary>
        public void DisConnect()
        {
            try
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ExecuteReader(String sql)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                return (cmd.ExecuteReader());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ExcuteNonQuery(string sql, CommandType type, List<SqlParameter> paras)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = type;
                if (paras != null)
                {
                    foreach (SqlParameter para in paras)
                    {
                        cmd.Parameters.Add(para);
                    }
                }
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


    }
}
