using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class BUS_Employee
    {
        public List<DTO_Employee> GetEmployee()
        {
            try
            {
                return new DAO_Employee().GetEmployee();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Add(DTO_Employee emp)
        {
            if (emp.MaNV.ToString() == "" || emp.HoNV == "" || emp.TenNV == "" || emp.GioiTinh == "" || emp.SDT == "" || emp.NgaySinh.ToShortTimeString() == "" || emp.CMND == "" || emp.DiaChiThuongTru == "" || emp.ChucVu == "")
                return -2;
            if (true)
            {

            }
            try
            {
                return (new DAO_Employee().Add(emp));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateEmployee(DTO_Employee emp)
        {
            if (emp.MaNV.ToString() == "" || emp.HoNV == "" || emp.TenNV == "" || emp.GioiTinh == "" || emp.SDT == "" || emp.CMND == "" || emp.DiaChiThuongTru == "" || emp.ChucVu == "")
                return -2;
            if (true)
            {

            }
            try
            {
                return (new DAO_Employee().UpdateEmployee(emp));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int Delete(DTO_Employee emp)
        {
            if (emp.MaNV.ToString() == "")
                return -2;

            if (true)
            {

            }
            try
            {
                return (new DAO_Employee().Delete(emp));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable SearchByMaNV(DTO_Employee emp)
        {
            DAO_Employee em = new DAO_Employee();
            return em.SearchByMaNV(emp);
        }

        public DataTable SearchByChucVu(DTO_Employee emp)
        {
            DAO_Employee em = new DAO_Employee();
            return em.SearchByChucVu(emp);
        }
    }
}
