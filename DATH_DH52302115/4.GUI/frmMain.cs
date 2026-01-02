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
    public partial class frmMain : Form
    {
        private frmKhachHang fKhachHang = null;
        private frmNhanVien fNhanVien = null;
        private frmKySuDung fKySuDung = null;
        private frmDienKe fDienKe = null;
        private frmSuDungDien fSuDung = null;
        private frmHoaDon fHoaDon= null;
        private CNhanVien nguoiDungHienTai = null;
        private frmCapNhatTaiKhoan fCapNhat = null;
        private Form currentFormChild = null;

        public frmMain(CNhanVien nv)
        {
            InitializeComponent();
            this.nguoiDungHienTai = nv;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "QUẢN LÝ THU TIỀN ĐIỆN";
            if (nguoiDungHienTai != null)
            {
                this.Text = "QUẢN LÝ THU TIỀN ĐIỆN - User: " + nguoiDungHienTai.HoTen;
                if (nguoiDungHienTai.QuyenHan == "Admin")
                {
                    btnQLNhanVien.Visible = true;
                }
                else
                {
                    btnQLNhanVien.Visible = false;
                }
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null && !currentFormChild.IsDisposed)
            {
                currentFormChild.Hide();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            if (pnlBody.Controls.Contains(childForm) == false)
            {
                pnlBody.Controls.Add(childForm);
            }

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            if (fKhachHang == null || fKhachHang.IsDisposed)
            {
                fKhachHang = new frmKhachHang();
            }
            OpenChildForm(fKhachHang);
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            if (fNhanVien == null || fNhanVien.IsDisposed)
            {
                fNhanVien = new frmNhanVien();
            }
            OpenChildForm(fNhanVien);
        }

        private void btnQLKy_Click(object sender, EventArgs e)
        {
            if (fKySuDung == null || fKySuDung.IsDisposed)
            {
                fKySuDung = new frmKySuDung();
            }
            OpenChildForm(fKySuDung);
        }
        

        private void btnQLDienKe_Click(object sender, EventArgs e)
        {
            if (fDienKe == null || fDienKe.IsDisposed)
            {
                fDienKe = new frmDienKe();
            }
            fDienKe.TaiLaiDanhSachKhachHang();
            OpenChildForm(fDienKe);
        }
        private void btnQLSuDung_Click(object sender, EventArgs e)
        {
            if (fSuDung == null || fSuDung.IsDisposed)
            {
                fSuDung = new frmSuDungDien(this.nguoiDungHienTai);
            }
            fSuDung.TaiLaiDuLieu();
            OpenChildForm(fSuDung);
        }
        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            if (fHoaDon == null || fHoaDon.IsDisposed)
            {
                fHoaDon = new frmHoaDon();
            }
            fHoaDon.TaiLaiDuLieu();
            OpenChildForm(fHoaDon);
        }
        private void btnLuuDuLieu_Click(object sender, EventArgs e)
        {
            bool ketQua = TruyCapDuLieu.LuuDuLieu("QuanLyDien_Data.dat");
            if (ketQua == true)
            {
                MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thất bại!", "Lỗi");
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhatTK_Click(object sender, EventArgs e)
        {
            if (fCapNhat == null || fCapNhat.IsDisposed)
            {
                fCapNhat = new frmCapNhatTaiKhoan(this.nguoiDungHienTai);
            }
            OpenChildForm(fCapNhat);
        }
    }
}
