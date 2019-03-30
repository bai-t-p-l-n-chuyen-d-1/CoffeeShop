using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //public class DTO_Employee
    //{
    //    private int maNV;
    //    private string hoNV, tenNV, gioiTinh, sDT, soCMND, diaChiThuongTru, chucVu;
    //    private DateTime ngaySinh;

    //    public int MaNV
    //    {
    //        get
    //        {
    //            return maNV;
    //        }

    //        set
    //        {
    //            maNV = value;
    //        }
    //    }

    //    public string HoNV
    //    {
    //        get
    //        {
    //            return hoNV;
    //        }

    //        set
    //        {
    //            hoNV = value;
    //        }
    //    }

    //    public string TenNV
    //    {
    //        get
    //        {
    //            return tenNV;
    //        }

    //        set
    //        {
    //            tenNV = value;
    //        }
    //    }

    //    public string GioiTinh
    //    {
    //        get
    //        {
    //            return gioiTinh;
    //        }

    //        set
    //        {
    //            gioiTinh = value;
    //        }
    //    }

    //    public string SDT
    //    {
    //        get
    //        {
    //            return sDT;
    //        }

    //        set
    //        {
    //            sDT = value;
    //        }
    //    }

    //    public string SoCMND
    //    {
    //        get
    //        {
    //            return soCMND;
    //        }

    //        set
    //        {
    //            soCMND = value;
    //        }
    //    }

    //    public string DiaChiThuongTru
    //    {
    //        get
    //        {
    //            return diaChiThuongTru;
    //        }

    //        set
    //        {
    //            diaChiThuongTru = value;
    //        }
    //    }

    //    public string ChucVu
    //    {
    //        get
    //        {
    //            return chucVu;
    //        }

    //        set
    //        {
    //            chucVu = value;
    //        }
    //    }

    //    public DateTime NgaySinh
    //    {
    //        get
    //        {
    //            return ngaySinh;
    //        }

    //        set
    //        {
    //            ngaySinh = value;
    //        }
    //    }

    //    public DTO_Employee(int pMaNV, string pHoNV, string pTenNV, string pGioiTinh, string pSoDienThoai, DateTime pNgaySinh, string pSoCMND, string pDiaChiThuongTru, string pChucVu)
    //    {
    //        MaNV = pMaNV;
    //        HoNV = pHoNV;
    //        TenNV = pTenNV;
    //        GioiTinh = pGioiTinh;
    //        SDT = pSoDienThoai;
    //        NgaySinh = pNgaySinh;
    //        SoCMND = pSoCMND;
    //        DiaChiThuongTru = pDiaChiThuongTru;
    //        ChucVu = pChucVu;
    //    }
    //    public DTO_Employee(string pHoNV, string pTenNV, string pGioiTinh, string pSoDienThoai, DateTime pNgaySinh, string pSoCMND, string pDiaChiThuongTru, string pChucVu)
    //    {
    //        HoNV = pHoNV;
    //        TenNV = pTenNV;
    //        GioiTinh = pGioiTinh;
    //        SDT = pSoDienThoai;
    //        NgaySinh = pNgaySinh;
    //        SoCMND = pSoCMND;
    //        DiaChiThuongTru = pDiaChiThuongTru;
    //        ChucVu = pChucVu;
    //    }
    //    public DTO_Employee(int pMaNV)
    //    {
    //        MaNV = pMaNV;
    //    }
    //}

    public class DTO_Employee
    {

        public int MaNV { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public string DiaChiThuongTru { get; set; }
        public string ChucVu { get; set; }

        public DTO_Employee(int manv, string honv, string tennv, string gioitinh, string sdt, DateTime ngaysinh, string cmnd, string diachithuongtru, string chucvu)
        {
            MaNV = manv;
            HoNV = honv;
            TenNV = tennv;
            GioiTinh = gioitinh;
            SDT = sdt;
            NgaySinh = ngaysinh;
            CMND = cmnd;
            DiaChiThuongTru = diachithuongtru;
            ChucVu = chucvu;
        }

        public DTO_Employee(int manv)
        {
            MaNV = manv;
        }

    }
}
