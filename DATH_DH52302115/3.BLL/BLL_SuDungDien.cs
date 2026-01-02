using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    public class BLL_SuDungDien
    {
        private List<CSuDungDien> dsSuDung;
        private List<CDienKe> dsDienKe;
        private List<CKySuDungDien> dsKy;
        private List<CNhanVien> dsNhanVien;

        public BLL_SuDungDien()
        {
            TruyCapDuLieu dulieu = TruyCapDuLieu.khoiTao();
            this.dsSuDung = dulieu.getDanhSachSuDungDien();
            this.dsDienKe = dulieu.getDanhSachDienKe();
            this.dsKy = dulieu.getDanhSachKy();
            this.dsNhanVien = dulieu.getDanhSachNhanVien();
        }

        public List<CSuDungDien> getDanhSachSuDung()
        {
            return dsSuDung;
        }

        public List<CDienKe> getDanhSachDienKe() 
        { 
            return dsDienKe;
        }
        public List<CKySuDungDien> getDanhSachKy() 
        { 
            return dsKy; 
        }
        public List<CNhanVien> getDanhSachNhanVien() 
        { 
            return dsNhanVien; 
        }

        public CSuDungDien TimSuDung(string maSD)
        {
            foreach (CSuDungDien sd in dsSuDung)
            {
                if (sd.MaSD == maSD) return sd;
            }
            return null;
        }
        public CDienKe TimDienKeTheoMa(string ma)
        {
            foreach (CDienKe dk in dsDienKe)
            {
                if (dk.MaDienKe == ma) return dk;
            }
            return null;
        }

        public bool ThemSuDung(CSuDungDien sd)
        {
            if (TimSuDung(sd.MaSD) != null) return false;
            if (sd.ChiSoMoi < sd.ChiSoCu) return false;

            dsSuDung.Add(sd);
            return true;
        }

        public bool XoaSuDung(string maSD)
        {
            CSuDungDien sd = TimSuDung(maSD);
            if (sd != null)
            {
                dsSuDung.Remove(sd);
                return true;
            }
            return false;
        }

        public bool SuaSuDung(CSuDungDien sdMoi)
        {
            CSuDungDien sdCu = TimSuDung(sdMoi.MaSD);
            if (sdCu != null)
            {
                if (sdMoi.ChiSoMoi < sdMoi.ChiSoCu) return false;

                sdCu.DienKe = sdMoi.DienKe;
                sdCu.KySuDung = sdMoi.KySuDung;
                sdCu.NhanVien = sdMoi.NhanVien;
                sdCu.NgayGhi = sdMoi.NgayGhi;
                sdCu.ChiSoCu = sdMoi.ChiSoCu;
                sdCu.ChiSoMoi = sdMoi.ChiSoMoi;
                return true;
            }
            return false;
        }

        public List<CSuDungDien> TimKiem(string tuKhoa, bool timTheoDienKe)
        {
            List<CSuDungDien> ketQua = new List<CSuDungDien>();
            string key = tuKhoa.ToLower();
            foreach (CSuDungDien sd in dsSuDung)
            {
                if (timTheoDienKe)
                {
                    if (sd.DienKe != null && sd.DienKe.MaDienKe.ToLower().Contains(key))
                        ketQua.Add(sd);
                }
                else
                {
                    if (sd.DienKe != null && sd.DienKe.KhachHang != null &&
                        sd.DienKe.KhachHang.HoTen.ToLower().Contains(key))
                        ketQua.Add(sd);
                }
            }
            return ketQua;
        }
        public int LayChiSoCu(string maDK)
        {
            int maxChiSo = 0;
            foreach (CSuDungDien sd in dsSuDung)
            {
                if (sd.DienKe.MaDienKe == maDK)
                {
                    if (sd.ChiSoMoi > maxChiSo)
                    {
                        maxChiSo = sd.ChiSoMoi;
                    }
                }
            }
            return maxChiSo;
        }
    }
}
