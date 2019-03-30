using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        public int MaKH { get; set; }
        public string HoKH { get; set; }
        public string TenKH { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChiThuongTru { get; set; }
        public string Email { get; set; }

        public DTO_Customer(int makh, string hokh, string tenkh, string gioitinh, string sdt, DateTime ngaysinh, string diachithuongtru, string email)
        {
            MaKH = makh;
            HoKH = hokh;
            TenKH = tenkh;
            GioiTinh = gioitinh;
            SDT = sdt;
            NgaySinh = ngaysinh;
            DiaChiThuongTru = diachithuongtru;
            Email = email;
        }
        public DTO_Customer(int makh)
        {
            MaKH = makh;
        }
    }
}

