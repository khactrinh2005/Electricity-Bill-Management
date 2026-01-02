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
    public partial class frmDoiMatKhau : Form
    {
        private CNhanVien nguoiDung;
        private BLL_NhanVien bllNV;
        public frmDoiMatKhau(CNhanVien nv)
        {
            InitializeComponent();
            this.nguoiDung = nv;
            bllNV = new BLL_NhanVien();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhauCu.Text) ||
                string.IsNullOrEmpty(txtMatKhauMoi.Text) ||
                string.IsNullOrEmpty(txtNhapLai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (txtMatKhauMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                return;
            }

            if (bllNV.DoiMatKhau(nguoiDung.MaNV, txtMatKhauCu.Text, txtMatKhauMoi.Text))
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
