using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    [Serializable]
    public class CHoaDon
    {
        private string m_maHoaDon;
        private CSuDungDien m_suDungDien;
        private DateTime m_ngayLap;
        private bool m_trangThai;
        private double m_donGia;

        public string MaHoaDon
        {
            get { return m_maHoaDon; }
            set { m_maHoaDon = value; }
        }
        public CSuDungDien SuDungDien
        {
            get { return m_suDungDien; }
            set { m_suDungDien = value; }
        }
        public DateTime NgayLap
        {
            get { return m_ngayLap; }
            set { m_ngayLap = value; }
        }
        public bool TrangThai
        {
            get { return m_trangThai; }
            set { m_trangThai = value; }
        }
        public double DonGia
        {
            get { return m_donGia; }
            set { m_donGia = value; }
        }
        public double ThanhTien
        {
            get
            {
                if (m_suDungDien != null)
                    return m_suDungDien.SoDien * m_donGia;
                return 0;
            }
        }
        public CHoaDon()
        {
            m_maHoaDon = "";
            m_suDungDien = null;
            m_ngayLap = DateTime.Now;
            m_trangThai = false;
            m_donGia = 2000;
        }
    }
}
