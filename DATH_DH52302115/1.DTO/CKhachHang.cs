using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    [Serializable]
    public class CKhachHang
    {
        private string m_maKH;
        private string m_hoTen;
        private string m_diaChi;
        private string m_soDT;
        private bool m_trangThai;

        public string MaKH
        {
            get { return m_maKH; }
            set { m_maKH = value; }
        }

        public string HoTen
        {
            get { return m_hoTen; }
            set { m_hoTen = value; }
        }

        public string DiaChi
        {
            get { return m_diaChi; }
            set { m_diaChi = value; }
        }

        public string SoDT
        {
            get { return m_soDT; }
            set { m_soDT = value; }
        }

        public bool TrangThai
        {
            get { return m_trangThai; }
            set { m_trangThai = value; }
        }

        public CKhachHang()
        {
            m_maKH = "";
            m_hoTen = "";
            m_diaChi = "";
            m_soDT = "";
            m_trangThai = true;
        }
    }
}