using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    public class BLL_DienKe
    {
        private List<CDienKe> dsDienKe;
        private List<CKhachHang> dsKhachHang;
        public BLL_DienKe()
        {
            TruyCapDuLieu dulieu = TruyCapDuLieu.khoiTao();
            this.dsDienKe = dulieu.getDanhSachDienKe();
            this.dsKhachHang = dulieu.getDanhSachKhachHang();
        }
        public List<CDienKe> getDanhSachDienKe()
        {
            return this.dsDienKe;
        }
        public List<CKhachHang> getDanhSachKhachHang()
        {
            return this.dsKhachHang;
        }
        public CDienKe TimDienKe(string maDK)
        {
            foreach (CDienKe dk in dsDienKe)
            {
                if (dk.MaDienKe == maDK) return dk;
            }
            return null;
        }
        public bool ThemDienKe(CDienKe dk)
        {
            if (TimDienKe(dk.MaDienKe) != null) return false;
            dsDienKe.Add(dk);
            return true;
        }
        public bool XoaDienKe(string maDK)
        {
            CDienKe dk = TimDienKe(maDK);
            if (dk != null)
            {
                dsDienKe.Remove(dk);
                return true;
            }
            return false;
        }
        public bool SuaDienKe(CDienKe dkMoi)
        {
            CDienKe dkCu = TimDienKe(dkMoi.MaDienKe);
            if (dkCu != null)
            {
                dkCu.KhachHang = dkMoi.KhachHang;
                dkCu.NgayLapDat = dkMoi.NgayLapDat;
                dkCu.TrangThai = dkMoi.TrangThai;
                return true;
            }
            return false;
        }
        
        public List<CDienKe> TimKiem(string tuKhoa, bool timTheoMa)
        {
            List<CDienKe> ketQua = new List<CDienKe>();
            string key = tuKhoa.ToLower();
            foreach (CDienKe dk in dsDienKe)
            {
                if (timTheoMa == true)
                {
                    if (dk.MaDienKe.ToLower().Contains(key))
                    {
                        ketQua.Add(dk);
                    }
                }
                else
                {
                    string tenKH = "";
                    if (dk.KhachHang != null)
                    {
                        tenKH = dk.KhachHang.HoTen.ToLower();
                    }
                    else
                    {
                        tenKH = "chưa gán";
                    }
                    if (tenKH.Contains(key))
                    {
                        ketQua.Add(dk);
                    }
                }
            }
            return ketQua;
        }
    }
}
