using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATH_DH52302115
{
    public partial class frmCapNhatTaiKhoan : Form
    {
        private CNhanVien nguoiDung;
        private BLL_NhanVien bllNV = new BLL_NhanVien();
        public frmCapNhatTaiKhoan(CNhanVien nv)
        {
            InitializeComponent();
            this.nguoiDung = nv;
        }

        private void frmCapNhatTaiKhoan_Load(object sender, EventArgs e)
        {
            if (nguoiDung != null)
            {
                txtMaNV.Text = nguoiDung.MaNV;
                txtChucVu.Text = nguoiDung.ChucVu;
                txtHoTen.Text = nguoiDung.HoTen;
                txtSDT.Text = nguoiDung.SoDienThoai;
                txtDiaChi.Text = nguoiDung.DiaChi;
                chkTrangThaiNV.Checked = nguoiDung.TrangThai;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (bllNV.CapNhatThongTin(txtMaNV.Text, txtSDT.Text, txtDiaChi.Text))
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau(nguoiDung);
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
