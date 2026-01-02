using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    public class BLL_KySuDung
    {
        private List<CKySuDungDien> dsKy;
        public BLL_KySuDung()
        {
            TruyCapDuLieu dulieu = TruyCapDuLieu.khoiTao();
            this.dsKy = dulieu.getDanhSachKy();
        }
        public List<CKySuDungDien> getDanhSachKy()
        {
            return this.dsKy;
        }
        public CKySuDungDien TimKySuDung(string maKy)
        {
            foreach (CKySuDungDien ky in dsKy)
            {
                if (ky.MaKy == maKy) return ky;
            }
            return null;
        }

        public bool ThemKy(CKySuDungDien ky)
        {
            if (TimKySuDung(ky.MaKy) != null) return false;
            dsKy.Add(ky);
            return true;
        }

        public bool XoaKy(string maKy)
        {
            CKySuDungDien ky = TimKySuDung(maKy);
            if (ky != null)
            {
                dsKy.Remove(ky);
                return true;
            }
            return false;
        }

        public bool SuaKy(CKySuDungDien kyMoi)
        {
            CKySuDungDien kyCu = TimKySuDung(kyMoi.MaKy);
            if (kyCu != null)
            {
                kyCu.TenKy = kyMoi.TenKy;
                kyCu.NgayBatDauGhi = kyMoi.NgayBatDauGhi;
                kyCu.NgayKetThucGhi = kyMoi.NgayKetThucGhi;
                return true;
            }
            return false;
        }

        public List<CKySuDungDien> TimKiem(string tuKhoa)
        {
            List<CKySuDungDien> ketQua = new List<CKySuDungDien>();
            foreach (CKySuDungDien ky in dsKy)
            {
                if (ky.MaKy.ToLower().Contains(tuKhoa.ToLower()) ||
                    ky.TenKy.ToLower().Contains(tuKhoa.ToLower()))
                {
                    ketQua.Add(ky);
                }
            }
            return ketQua;
        }
    }
}
