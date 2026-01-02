using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    [Serializable]
    public class CKySuDungDien
    {
        private string m_maKy;
        private string m_tenKy;
        private DateTime m_ngayBatDauGhi;
        private DateTime m_ngayKetThucGhi;

        public string MaKy
        {
            get { return m_maKy; }
            set { m_maKy = value; }
        }

        public string TenKy
        {
            get { return m_tenKy; }
            set { m_tenKy = value; }
        }

        public DateTime NgayBatDauGhi
        {
            get { return m_ngayBatDauGhi; }
            set { m_ngayBatDauGhi = value; }
        }

        public DateTime NgayKetThucGhi
        {
            get { return m_ngayKetThucGhi; }
            set { m_ngayKetThucGhi = value; }
        }

        public CKySuDungDien()
        {
            m_maKy = "";
            m_tenKy = "";
            m_ngayBatDauGhi = DateTime.Today;
            m_ngayKetThucGhi = DateTime.Today;
        }
    }
}