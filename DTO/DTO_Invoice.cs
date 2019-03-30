using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Invoice
    {
        public int MaHoaDon { get; set; }
        public int MaMonNuoc { get; set; }
        public int MaBan { get; set; }     
        public DTO_Invoice(int mahoadon, int mamonnuoc, int maban)
        {
            this.MaHoaDon = mahoadon;
            this.MaMonNuoc = mamonnuoc;
            this.MaBan = maban;           
        }        
        public DTO_Invoice(int maban)
        {
            this.MaBan = maban;
        }
    }
}
