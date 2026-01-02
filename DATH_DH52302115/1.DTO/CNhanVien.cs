using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH_DH52302115
{
    [Serializable]
    public class CNhanVien
    {
        private string m_maNV;
        private string m_hoTen;
        private string m_chucVu;
        private string m_quyenHan;
        private bool m_trangThai;
        private string m_matKhau;
        private string m_soDienThoai;
        private string m_diaChi;

        public string MaNV
        {
            get { return m_maNV; }
            set { m_maNV = value; }
        }

        public string HoTen
        {
            get { return m_hoTen; }
            set { m_hoTen = value; }
        }

        public string ChucVu
        {
            get { return m_chucVu; }
            set { m_chucVu = value; }
        }

        public string QuyenHan
        {
            get { return m_quyenHan; }
            set { m_quyenHan = value; }
        }

        public bool TrangThai
        {
            get { return m_trangThai; }
            set { m_trangThai = value; }
        }

        public string MatKhau
        {
            get { return m_matKhau; }
            set { m_matKhau = value; }
        }

        public string SoDienThoai
        {
            get { return m_soDienThoai; }
            set { m_soDienThoai = value; }
        }

        public string DiaChi
        {
            get { return m_diaChi; }
            set { m_diaChi = value; }
        }

        public CNhanVien()
        {
            m_maNV = "";
            m_hoTen = "";
            m_chucVu = "";
            m_quyenHan = "";
            m_trangThai = true;
            m_matKhau = "123";
            m_soDienThoai = "";
            m_diaChi = "";
        }
    }
}