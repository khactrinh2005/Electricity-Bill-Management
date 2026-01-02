using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    public class BLL_HoaDon
    {
        private List<CHoaDon> dsHoaDon;
        private List<CSuDungDien> dsSuDung;
        private List<CKySuDungDien> dsKy;
        public BLL_HoaDon()
        {
            TruyCapDuLieu dulieu = TruyCapDuLieu.khoiTao();
            this.dsHoaDon = dulieu.getDanhSachHoaDon();
            this.dsSuDung = dulieu.getDanhSachSuDungDien();
            this.dsKy = dulieu.getDanhSachKy();
        }
        public List<CHoaDon> getDanhSachHoaDon() { return dsHoaDon; }
        public List<CKySuDungDien> getDanhSachKy() { return dsKy; }
        public List<CSuDungDien> getDanhSachSuDungTheoKy(string maKy)
        {
            List<CSuDungDien> ketQua = new List<CSuDungDien>();
            foreach (CSuDungDien sd in dsSuDung)
            {
                if (sd.KySuDung != null && sd.KySuDung.MaKy == maKy)
                {
                    if (TimHoaDonTheoMaSuDung(sd.MaSD) == null)
                        ketQua.Add(sd);
                }
            }
            return ketQua;
        }
        public CHoaDon TimHoaDon(string maHD)
        {
            foreach (CHoaDon hd in dsHoaDon)
                if (hd.MaHoaDon == maHD) return hd;
            return null;
        }
        public CHoaDon TimHoaDonTheoMaSuDung(string maSD)
        {
            foreach (CHoaDon hd in dsHoaDon)
                if (hd.SuDungDien != null && hd.SuDungDien.MaSD == maSD) return hd;
            return null;
        }
        public bool ThemHoaDon(CHoaDon hd)
        {
            if (TimHoaDon(hd.MaHoaDon) != null) return false;
            dsHoaDon.Add(hd);
            return true;
        }
        public bool XoaHoaDon(string maHD)
        {
            CHoaDon hd = TimHoaDon(maHD);
            if (hd != null) { dsHoaDon.Remove(hd); return true; }
            return false;
        }
        public bool SuaHoaDon(CHoaDon hdMoi)
        {
            CHoaDon hdCu = TimHoaDon(hdMoi.MaHoaDon);
            if (hdCu != null)
            {
                hdCu.DonGia = hdMoi.DonGia;
                hdCu.TrangThai = hdMoi.TrangThai;
                return true;
            }
            return false;
        }
        public List<CHoaDon> TimKiemNangCao(string tenKH, string tenKy, int trangThai)
        {
            List<CHoaDon> ketQua = new List<CHoaDon>();
            string keyKH = tenKH.ToLower();
            string keyKy = tenKy.ToLower();

            foreach (CHoaDon hd in dsHoaDon)
            {
                bool thoaTen = true;
                if (!string.IsNullOrEmpty(keyKH))
                {
                    string tenKHTongQuat = "";
                    if (hd.SuDungDien != null && hd.SuDungDien.DienKe != null && hd.SuDungDien.DienKe.KhachHang != null)
                    {
                        tenKHTongQuat = hd.SuDungDien.DienKe.KhachHang.HoTen.ToLower();
                    }
                    if (!tenKHTongQuat.Contains(keyKH)) thoaTen = false;
                }
                bool thoaKy = true;
                if (!string.IsNullOrEmpty(keyKy))
                {
                    string tenKyTongQuat = "";
                    if (hd.SuDungDien != null && hd.SuDungDien.KySuDung != null)
                    {
                        tenKyTongQuat = hd.SuDungDien.KySuDung.TenKy.ToLower();
                    }
                    if (!tenKyTongQuat.Contains(keyKy)) thoaKy = false;
                }
                bool thoaTrangThai = true;
                if (trangThai != -1)
                {
                    bool trangThaiCanTim = (trangThai == 1);
                    if (hd.TrangThai != trangThaiCanTim) thoaTrangThai = false;
                }
                if (thoaTen && thoaKy && thoaTrangThai)
                {
                    ketQua.Add(hd);
                }
            }
            return ketQua;
        }
    }
}
