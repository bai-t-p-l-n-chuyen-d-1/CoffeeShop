using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DTO;
using DAO;

namespace BUS
{
    public class BUS_Order
    {
        public List<DTO_Order> GetMenu()
        {
            try
            {
                return new DAO_Order().GetMenu();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public decimal GetMoney(int id)
        {
            try
            {
                return new DAO_Order().GETMONEY(id);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public void XoaMon(DTO_Order ma, int maban)
        {
            DAO_Order mon = new DAO_Order();
            mon.XoaMon(ma, maban);
        }

    }
}
