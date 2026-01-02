using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    [Serializable]
    public class CDienKe
    {
        private string m_maDienKe;
        private CKhachHang m_khachHang;
        private DateTime m_ngayLapDat;
        private string m_trangThai;

        public string MaDienKe
        {
            get { return m_maDienKe; }
            set { m_maDienKe = value; }
        }
        public CKhachHang KhachHang
        {
            get { return m_khachHang; }
            set { m_khachHang = value; }
        }

        public DateTime NgayLapDat
        {
            get { return m_ngayLapDat; }
            set { m_ngayLapDat = value; }
        }

        public string TrangThai
        {
            get { return m_trangThai; }
            set { m_trangThai = value; }
        }

        public CDienKe()
        {
            m_maDienKe = "";
            m_khachHang = null;
            m_ngayLapDat = DateTime.Now;
            m_trangThai = "Đang hoạt động";
        }
    }
}
