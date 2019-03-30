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
    public class DAO_Customer
    {
        
        private DataProvider dp;
        public DAO_Customer()
        {
            dp = new DataProvider();
        }
        public List<DTO_Customer> GetCustomer()
        {
            List<DTO_Customer> list = new List<DTO_Customer>();
            int makh;
            string hokh, tenkh, sdt, gioitinh, diachithuongtru, email;
            DateTime ngaysinh;
            try
            {
                string sql = "SELECT * FROM KhachHang";
                SqlDataReader dr = dp.ExecuteReader(sql);

                while (dr.Read())
                {
                    makh = dr.GetInt32(0);
                    hokh = dr.GetString(1);
                    tenkh = dr.GetString(2);
                    gioitinh = dr.GetString(3);
                    sdt = dr.GetString(4);
                    ngaysinh = dr.GetDateTime(5);          
                    diachithuongtru = dr.GetString(6);
                    email = dr.GetString(7);

                    DTO_Customer emp = new DTO_Customer(makh, hokh, tenkh, gioitinh, sdt, ngaysinh, diachithuongtru, email);
                    list.Add(emp);

                }
                return list;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int AddCustomer(DTO_Customer emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            //string sql = " INSERT INTO KhachHang( MaKH, HoKH, TenKH, GioiTinh, SDT, NgaySinh, DiaChiThuongTru, Email)" +
            //    " VALUES (@MaKH, @HoKH, @TenKH, @GioiTinh, @SDT, @NgaySinh, @DiaChiThuongTru, @Email)";

            paras.Add(new SqlParameter("@MaKH", emp.MaKH));
            paras.Add(new SqlParameter("@HoKH", emp.HoKH));
            paras.Add(new SqlParameter("@TenKH", emp.TenKH));
            paras.Add(new SqlParameter("@GioiTinh", emp.GioiTinh));
            paras.Add(new SqlParameter("@SDT", emp.SDT));
            paras.Add(new SqlParameter("@NgaySinh", emp.NgaySinh));         
            paras.Add(new SqlParameter("@DiaChiThuongTru", emp.DiaChiThuongTru));
            paras.Add(new SqlParameter("@Email", emp.Email));
            try
            {
                return (dp.ExcuteNonQuery("sp_ThemKhachHang", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        public int DeleteCustomer(DTO_Customer emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaKH", emp.MaKH));
            try
            {
                return (dp.ExcuteNonQuery("sp_XoaKhachHang", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int UpdateCustomer(DTO_Customer emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaKH", emp.MaKH));
            paras.Add(new SqlParameter("@HoKH", emp.HoKH));
            paras.Add(new SqlParameter("@TenKH", emp.TenKH));
            paras.Add(new SqlParameter("@GioiTinh", emp.GioiTinh));
            paras.Add(new SqlParameter("@SDT", emp.SDT));
            paras.Add(new SqlParameter("@NgaySinh", emp.NgaySinh));         
            paras.Add(new SqlParameter("@DiaChiThuongTru", emp.DiaChiThuongTru));
            paras.Add(new SqlParameter("@Email", emp.Email));
            try
            {
                return (dp.ExcuteNonQuery("sp_SuaKhachHang", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable SearchByMaKH(DTO_Customer emp)
        {
            SqlConnection cnn = dp.getConnect();
            List<SqlParameter> paras = new List<SqlParameter>();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_TimTheoMaKhachHang", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKH", emp.MaKH));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dp.DisConnect();
            return dt;
        }

    }
}

