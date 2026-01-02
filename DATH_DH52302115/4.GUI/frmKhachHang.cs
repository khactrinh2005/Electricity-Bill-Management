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
    public partial class frmKhachHang : Form
    {
        BLL_KhachHang bll = new BLL_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bll.getDanhSachKhachHang();
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = bs;
            dgvKhachHang.Refresh();
        }
        private void dgvKhachHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0 && e.RowIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count)
            {
                try
                {
                    
                    string maKH = dgvKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                    CKhachHang kh = bll.TimKhachHang(maKH);
                    if (kh != null)
                    {
                        txtMaKH.Text = kh.MaKH;
                        txtHoTenKH.Text = kh.HoTen;
                        txtDiaChiKH.Text = kh.DiaChi;
                        txtSoDTKH.Text = kh.SoDT;
                        chkTrangThaiKH.Checked = kh.TrangThai;
                    }
                }
                catch
                {

                }
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            CKhachHang kh = new CKhachHang();
            kh.MaKH = txtMaKH.Text;
            kh.HoTen = txtHoTenKH.Text;
            kh.DiaChi = txtDiaChiKH.Text;
            kh.SoDT = txtSoDTKH.Text;
            kh.TrangThai = chkTrangThaiKH.Checked;
            if (bll.ThemKhachHang(kh))
            {
                HienThiDanhSach();
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!", "Lỗi");
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            CKhachHang khSua = new CKhachHang
            {
                MaKH = txtMaKH.Text,
                HoTen = txtHoTenKH.Text,
                DiaChi = txtDiaChiKH.Text,
                SoDT = txtSoDTKH.Text,
                TrangThai = chkTrangThaiKH.Checked
            };
            if (bll.SuaKhachHang(khSua))
            {
                HienThiDanhSach();
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã KH để sửa!");
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            chkTrangThaiKH.Checked = false;
            btnSuaKH_Click(sender, e);
            MessageBox.Show("Đã vô hiệu hóa khách hàng.");
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKH.Text;

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }
            List<CKhachHang> ketQuaTimKiem = bll.TimKiem(tuKhoa);
            if (ketQuaTimKiem.Count > 0)
            {
                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = ketQuaTimKiem;
                dgvKhachHang.Refresh();
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp.");
            }
        }

        private void btnTaiLaiKH_Click(object sender, EventArgs e)
        {
            txtTimKH.Text = "";
            HienThiDanhSach();
        }

        
    }
}
