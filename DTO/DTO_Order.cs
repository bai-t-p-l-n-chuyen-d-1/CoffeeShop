using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Order
    {
        public int MaMonNuoc { get; set; }
        public string TenMonNuoc { get; set; }
        public decimal GiaTien { get; set; }
        public string DonVi { get; set; }

        public DTO_Order(int mamonnuoc, string tenmonnuoc, decimal giatien, string donvi)
        { 
            MaMonNuoc = mamonnuoc;
            TenMonNuoc = tenmonnuoc;
            GiaTien = giatien;
            DonVi = donvi;
            
        }
        public DTO_Order(int mamonnuoc)
        {
            MaMonNuoc = mamonnuoc;
        }
        
    }
}
