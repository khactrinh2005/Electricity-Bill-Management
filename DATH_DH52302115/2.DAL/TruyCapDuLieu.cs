using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    [Serializable]
    public class TruyCapDuLieu
    {
        public List<CKhachHang> dsKhachHang;
        public List<CNhanVien> dsNhanVien;
        public List<CKySuDungDien> dsKy;
        public List<CDienKe> dsDienKe;
        public List<CSuDungDien> dsSuDungDien;
        public List<CHoaDon> dsHoaDon;
        private static TruyCapDuLieu m_instance = null;
        private TruyCapDuLieu()
        {
            dsKhachHang = new List<CKhachHang>();
            dsNhanVien = new List<CNhanVien>();
            dsKy = new List<CKySuDungDien>();
            dsDienKe = new List<CDienKe>();
            dsSuDungDien = new List<CSuDungDien>();
            dsHoaDon = new List<CHoaDon>();
        }
        public static TruyCapDuLieu khoiTao()
        {
            if (m_instance == null)
            {
                if (!DocDuLieu("QuanLyDien_Data.dat"))
                {
                    m_instance = new TruyCapDuLieu();
                }
            }
            return m_instance;
        }
        public List<CKhachHang> getDanhSachKhachHang()
        {
            return dsKhachHang;
        }
        public List<CNhanVien> getDanhSachNhanVien()
        {
            return dsNhanVien;
        }
        public List<CKySuDungDien> getDanhSachKy()
        {
            return dsKy;
        }
        public List<CDienKe> getDanhSachDienKe()
        {
            return dsDienKe;
        }
        public List<CSuDungDien> getDanhSachSuDungDien()
        {
            return dsSuDungDien;
        }
        public List<CHoaDon> getDanhSachHoaDon()
        {
            return dsHoaDon;
        }
        public static bool LuuDuLieu(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, m_instance);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool DocDuLieu(string tenFile)
        {
            try
            {
                if (!File.Exists(tenFile)) return false;

                FileStream fs = new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_instance = (TruyCapDuLieu)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
