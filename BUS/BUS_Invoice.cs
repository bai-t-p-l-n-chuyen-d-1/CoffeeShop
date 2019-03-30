using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using DAO;
using DTO;

namespace BUS
{
    public class BUS_Invoice
    {
        public List<DTO_Invoice> GetInvoiceBUS(string sql)
        {
            try
            {
                return new DAO_Invoice().GetInvoiceDAO(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        

        public void Add_MonNuoc(int mamonnuoc, int maban)
        {
            DAO_Invoice mon = new DAO_Invoice();
            mon.Add_MonNuoc(mamonnuoc, maban);
        }

        public DataTable GetTheoSoBan(string sql)
        {
            DAO_Invoice mon = new DAO_Invoice();
            return mon.GetTheoSoBan(sql);
        }
    }
}
