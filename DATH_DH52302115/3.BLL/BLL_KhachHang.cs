using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    public class BLL_KhachHang
    {
        private List<CKhachHang> dsKhachHang;
        public BLL_KhachHang()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoiTao();
            this.dsKhachHang=duLieu.getDanhSachKhachHang();
        }
        public List<CKhachHang> getDanhSachKhachHang()
        {
            return dsKhachHang;
        }
        public CKhachHang TimKhachHang(string maKH)
        {
            foreach (CKhachHang kh in dsKhachHang)
            {
                if (kh.MaKH == maKH) return kh;
            }
            return null;
        }

        public bool ThemKhachHang(CKhachHang kh)
        {
            if (TimKhachHang(kh.MaKH) != null) return false;
            dsKhachHang.Add(kh);
            return true;
        }

        public bool XoaKhachHang(string maKH)
        {
            CKhachHang kh = TimKhachHang(maKH);
            if (kh != null)
            {
                dsKhachHang.Remove(kh);
                return true;
            }
            return false;
        }

        public bool SuaKhachHang(CKhachHang khMoi)
        {
            CKhachHang khCu = TimKhachHang(khMoi.MaKH);
            if (khCu != null)
            {
                khCu.HoTen = khMoi.HoTen;
                khCu.DiaChi = khMoi.DiaChi;
                khCu.SoDT = khMoi.SoDT;
                khCu.TrangThai = khMoi.TrangThai;
                return true;
            }
            return false;
        }

        public List<CKhachHang> TimKiem(string tuKhoa)
        {
            List<CKhachHang> ketQua = new List<CKhachHang>();
            foreach (CKhachHang kh in dsKhachHang)
            {
                if (kh.MaKH.ToLower().Contains(tuKhoa.ToLower()) ||
                    kh.HoTen.ToLower().Contains(tuKhoa.ToLower()))
                {
                    ketQua.Add(kh);
                }
            }
            return ketQua;
        }
    }
}
