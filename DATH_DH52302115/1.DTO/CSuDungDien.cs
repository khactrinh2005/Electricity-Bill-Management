using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    [Serializable]
    public class CSuDungDien
    {
        private string m_maSD;
        private CDienKe m_dienKe;
        private CKySuDungDien m_ky;
        private CNhanVien m_nhanVien;
        private DateTime m_ngayGhi;
        private int m_chiSoCu;
        private int m_chiSoMoi;
        public string MaSD
        {
            get { return m_maSD; }
            set { m_maSD = value; }
        }
        public CDienKe DienKe
        {
            get { return m_dienKe; }
            set { m_dienKe = value; }
        }
        public CKySuDungDien KySuDung
        {
            get { return m_ky; }
            set { m_ky = value; }
        }
        public CNhanVien NhanVien
        {
            get { return m_nhanVien; }
            set { m_nhanVien = value; }
        }
        public DateTime NgayGhi
        {
            get { return m_ngayGhi; }
            set { m_ngayGhi = value; }
        }
        public int ChiSoCu
        {
            get { return m_chiSoCu; }
            set { m_chiSoCu = value; }
        }
        public int ChiSoMoi
        {
            get { return m_chiSoMoi; }
            set { m_chiSoMoi = value; }
        }
        public int SoDien
        {
            get { return m_chiSoMoi - m_chiSoCu; }
        }
        public CSuDungDien()
        {
            m_maSD = "";
            m_dienKe = null;
            m_ky = null;
            m_nhanVien = null;
            m_ngayGhi = DateTime.Now;
            m_chiSoCu = 0;
            m_chiSoMoi = 0;
        }
    }
}
