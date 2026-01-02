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
    public partial class frmNhanVien : Form
    {
        BLL_NhanVien bll = new BLL_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bll.getDanhSachNhanVien();
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = bs;
            dgvNhanVien.Refresh();
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0 && e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                try
                {
                    string maNV = dgvNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                    CNhanVien nv = bll.TimNhanVien(maNV);
                    if (nv != null)
                    {
                        txtMaNV.Text = nv.MaNV;
                        txtHoTenNV.Text = nv.HoTen;
                        cboChucVuNV.Text = nv.ChucVu;
                        cboQuyenHanNV.Text = nv.QuyenHan;
                        chkTrangThaiNV.Checked = nv.TrangThai;
                    }
                }
                catch
                {
                    
                }
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            CNhanVien nvMoi = new CNhanVien
            {
                MaNV = txtMaNV.Text,
                HoTen = txtHoTenNV.Text,
                ChucVu = cboChucVuNV.Text,
                QuyenHan = cboQuyenHanNV.Text,
                TrangThai = chkTrangThaiNV.Checked,
                MatKhau = "123"
            };

            if (bll.ThemNhanVien(nvMoi))
            {
                HienThiDanhSach();
                MessageBox.Show("Thêm nhân viên thành công.");
            }
            else
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại.");
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            CNhanVien nvSua = new CNhanVien
            {
                MaNV = txtMaNV.Text,
                HoTen = txtHoTenNV.Text,
                ChucVu = cboChucVuNV.Text,
                QuyenHan = cboQuyenHanNV.Text,
                TrangThai = chkTrangThaiNV.Checked
            };
            bll.SuaNhanVien(nvSua);
            HienThiDanhSach();
            MessageBox.Show("Cập nhật thành công.");
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            chkTrangThaiNV.Checked = false;
            btnSuaNV_Click(sender, e);
            MessageBox.Show("Đã vô hiệu hóa nhân viên.");
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemNV.Text;
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }
            List<CNhanVien> ketQuaTimKiem = bll.TimKiem(tuKhoa);
            if (ketQuaTimKiem.Count > 0)
            {
                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = ketQuaTimKiem;
                dgvNhanVien.Refresh();
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp.");
            }
        }

        private void btnTaiLaiNV_Click(object sender, EventArgs e)
        {
            txtTimKiemNV.Text = "";
            HienThiDanhSach();
        }
    }
}
