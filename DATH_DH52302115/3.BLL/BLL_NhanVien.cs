using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    public class BLL_NhanVien
    {
        private List<CNhanVien> dsNhanVien;
        public BLL_NhanVien()
        {
            TruyCapDuLieu dulieu = TruyCapDuLieu.khoiTao();
            this.dsNhanVien = dulieu.getDanhSachNhanVien();
        }
        public List<CNhanVien> getDanhSachNhanVien()
        {
            return dsNhanVien;
        }
        public CNhanVien TimNhanVien(string maNV)
        {
            foreach (CNhanVien nv in dsNhanVien)
            {
                if (nv.MaNV == maNV) return nv;
            }
            return null;
        }
        public CNhanVien KiemTraDangNhap(string maNV, string matKhau)
        {
            foreach (CNhanVien nv in dsNhanVien)
            {
                if (nv.MaNV == maNV && nv.MatKhau == matKhau && nv.TrangThai == true)
                {
                    return nv;
                }
            }
            return null;
        }

        public bool ThemNhanVien(CNhanVien nv)
        {
            if (TimNhanVien(nv.MaNV) != null) return false;
            dsNhanVien.Add(nv);
            return true;
        }

        public bool XoaNhanVien(string maNV)
        {
            CNhanVien nv = TimNhanVien(maNV);
            if (nv != null)
            {
                dsNhanVien.Remove(nv);
                return true;
            }
            return false;
        }

        public bool SuaNhanVien(CNhanVien nvMoi)
        {
            CNhanVien nvCu = TimNhanVien(nvMoi.MaNV);
            if (nvCu != null)
            {
                nvCu.HoTen = nvMoi.HoTen;
                nvCu.ChucVu = nvMoi.ChucVu;
                nvCu.QuyenHan = nvMoi.QuyenHan;
                nvCu.TrangThai = nvMoi.TrangThai;
                nvCu.SoDienThoai = nvMoi.SoDienThoai;
                nvCu.DiaChi = nvMoi.DiaChi;
                return true;
            }
            return false;
        }

        public List<CNhanVien> TimKiem(string tuKhoa)
        {
            List<CNhanVien> ketQua = new List<CNhanVien>();
            foreach (CNhanVien nv in dsNhanVien)
            {
                if (nv.MaNV.ToLower().Contains(tuKhoa.ToLower()) ||
                    nv.HoTen.ToLower().Contains(tuKhoa.ToLower()))
                {
                    ketQua.Add(nv);
                }
            }
            return ketQua;
        }

        public bool CapNhatThongTin(string maNV, string sdt, string diaChi)
        {
            CNhanVien nv = TimNhanVien(maNV);
            if (nv != null)
            {
                nv.SoDienThoai = sdt;
                nv.DiaChi = diaChi;
                return true;
            }
            return false;
        }

        public bool DoiMatKhau(string maNV, string matKhauCu, string matKhauMoi)
        {
            CNhanVien nv = TimNhanVien(maNV);
            if (nv != null)
            {
                if (nv.MatKhau == matKhauCu)
                {
                    nv.MatKhau = matKhauMoi;
                    return true;
                }
            }
            return false;
        }
    }
}
