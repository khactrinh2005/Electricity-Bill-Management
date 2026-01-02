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
    public partial class frmDangNhap : Form
    {
        BLL_NhanVien bllNV;
        public frmDangNhap()
        {
            InitializeComponent();
            bllNV = new BLL_NhanVien();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (bllNV.getDanhSachNhanVien().Count == 0)
            {
                this.Hide();
                frmTaoAdmin f = new frmTaoAdmin();
                DialogResult kq = f.ShowDialog();
                if (kq == DialogResult.OK)
                {
                    this.Show();
                    bllNV = new BLL_NhanVien();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;

            if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            CNhanVien nv = bllNV.KiemTraDangNhap(tk, mk);

            if (nv != null)
            {
                MessageBox.Show("Đăng nhập thành công! Xin chào " + nv.HoTen);
                frmMain f = new frmMain(nv);
                this.Hide();
                f.ShowDialog();
                this.Show();
                txtMatKhau.Clear();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
