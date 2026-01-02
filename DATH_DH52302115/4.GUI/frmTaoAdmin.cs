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
    public partial class frmTaoAdmin : Form
    {
        private BLL_NhanVien bllNV;
        public frmTaoAdmin()
        {
            InitializeComponent();
            bllNV = new BLL_NhanVien();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text) ||
                string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập, Mật khẩu và Họ tên!");
                return;
            }
            CNhanVien admin = new CNhanVien();
            admin.MaNV = txtTenDangNhap.Text;
            admin.MatKhau = txtMatKhau.Text;
            admin.HoTen = txtHoTen.Text;
            admin.ChucVu = "Quản trị hệ thống";
            admin.QuyenHan = "Admin";
            admin.TrangThai = true;
            admin.SoDienThoai = txtSDT.Text;
            admin.DiaChi = txtDiaChi.Text;
            if (bllNV.ThemNhanVien(admin))
            {
                if (TruyCapDuLieu.LuuDuLieu("QuanLyDien_Data.dat"))
                {
                    MessageBox.Show("Khởi tạo tài khoản Quản trị viên thành công!\nHãy đăng nhập bằng tài khoản vừa tạo.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi ghi file dữ liệu!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
