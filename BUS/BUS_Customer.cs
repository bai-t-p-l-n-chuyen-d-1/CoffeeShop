using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class BUS_Customer
    {
        public List<DTO_Customer> GetCustomer()
        {
            try
            {
                return new DAO_Customer().GetCustomer();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int AddCustomer(DTO_Customer emp)
        {
            if (emp.MaKH.ToString() == "" ||  emp.HoKH == "" || emp.TenKH == "" || emp.GioiTinh == "" || emp.SDT == "" || emp.NgaySinh.ToShortTimeString() == "" || emp.DiaChiThuongTru == "" || emp.Email == "")
                return -2;
            if (true)
            {

            }
            try
            {
                return (new DAO_Customer().AddCustomer(emp));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int DeleteCustomer(DTO_Customer emp)
        {
            if (emp.MaKH.ToString() == "")
                return -2;
            if (true)
            {

            }
            try
            {
                return (new DAO_Customer().DeleteCustomer(emp));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int UpdateCustomer(DTO_Customer emp)
        {
            if (emp.MaKH.ToString() == "" || emp.HoKH == "" || emp.TenKH == "" || emp.GioiTinh == "" || emp.SDT == "" || emp.NgaySinh.ToShortTimeString() == "" || emp.DiaChiThuongTru == "" || emp.Email == "")
                return -2;
            if (true)
            {

            }
            try
            {
                return (new DAO_Customer().UpdateCustomer(emp));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable SearchByMaKH(DTO_Customer emp)
        {
            DAO_Customer em = new DAO_Customer();
            return em.SearchByMaKH(emp);
        }
    }
}
