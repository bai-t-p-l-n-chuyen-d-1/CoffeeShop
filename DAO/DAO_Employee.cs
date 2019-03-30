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
    public class DAO_Employee
    {
        private DataProvider dp;
        public DAO_Employee()
        {
            dp = new DataProvider();
        }
        public List<DTO_Employee> GetEmployee()
        {
            List<DTO_Employee> list = new List<DTO_Employee> ();
            int manv;
            string honv, tennv, gioitinh, sdt, cmnd, diachithuongtru, chucvu;
            DateTime ngaysinh;
            //dp.Connect();     
            try
            {
                string sql = "SELECT * FROM NhanVien";
                SqlDataReader dr = dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    manv = dr.GetInt32(0);
                    honv = dr.GetString(1);
                    tennv = dr.GetString(2);
                    gioitinh = dr.GetString(3);
                    sdt = dr.GetString(4);
                    ngaysinh = dr.GetDateTime(5);
                    cmnd = dr.GetString(6);
                    diachithuongtru = dr.GetString(7);
                    chucvu = dr.GetString(8);
                    
                    DTO_Employee emp = new DTO_Employee (manv, honv, tennv, gioitinh, sdt, ngaysinh, cmnd, diachithuongtru, chucvu);
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
                // dp.DisConnect();
            }
        }


        public int Add(DTO_Employee emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            //string sql = " INSERT INTO NhanVien( MaNV, HoNV, TenNV, GioiTinh, SDT, NgaySinh, DiaChiThuongTru, ChucVu)" +
            //    " VALUES (@MaNV, @HoNV, @TenNV, @GioiTinh, @SDT, @NgaySinh, @DiaChiThuongTru, @ChucVu)";

            paras.Add(new SqlParameter("@MaNV", emp.MaNV));
            paras.Add(new SqlParameter("@HoNV", emp.HoNV));
            paras.Add(new SqlParameter("@TenNV", emp.TenNV));
            paras.Add(new SqlParameter("@GioiTinh", emp.GioiTinh));
            paras.Add(new SqlParameter("@SDT", emp.SDT));
            paras.Add(new SqlParameter("@NgaySinh", emp.NgaySinh));
            paras.Add(new SqlParameter("@CMND", emp.CMND));
            paras.Add(new SqlParameter("@DiaChiThuongTru", emp.DiaChiThuongTru));
            paras.Add(new SqlParameter("@ChucVu", emp.ChucVu));

            try
            {
                return (dp.ExcuteNonQuery("sp_ThemNhanVien", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateEmployee(DTO_Employee emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaNV", emp.MaNV));
            paras.Add(new SqlParameter("@HoNV", emp.HoNV));
            paras.Add(new SqlParameter("@TenNV", emp.TenNV));
            paras.Add(new SqlParameter("@GioiTinh", emp.GioiTinh));
            paras.Add(new SqlParameter("@SDT", emp.SDT));
            paras.Add(new SqlParameter("@NgaySinh", emp.NgaySinh));
            paras.Add(new SqlParameter("@CMND", emp.CMND));
            paras.Add(new SqlParameter("@DiaChiThuongTru", emp.DiaChiThuongTru));
            paras.Add(new SqlParameter("@ChucVu", emp.ChucVu));       
            try
            {
                return (dp.ExcuteNonQuery("sp_SuaNhanVien", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Delete(DTO_Employee emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaNV", emp.MaNV));
            try
            {
                return (dp.ExcuteNonQuery("sp_XoaNhanVien", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable SearchByMaNV(DTO_Employee emp)
        {
            SqlConnection cnn = dp.getConnect();
            List<SqlParameter> paras = new List<SqlParameter>();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_TimTheoMaNhanVien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNV", emp.MaNV));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dp.DisConnect();
            return dt;
        }

        public DataTable SearchByChucVu(DTO_Employee emp)
        {
            SqlConnection cnn = dp.getConnect();
            List<SqlParameter> paras = new List<SqlParameter>();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_TimTheoChucVuNhanVien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ChucVu", emp.ChucVu));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dp.DisConnect();
            return dt;
        }

    }
}
