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
    public partial class frmKySuDung : Form
    {
        BLL_KySuDung bll = new BLL_KySuDung();
        public frmKySuDung()
        {
            InitializeComponent();
        }

        private void frmKySuDung_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bll.getDanhSachKy();
            dgvKySuDungDien.AutoGenerateColumns = false;
            dgvKySuDungDien.DataSource = bs;
            dgvKySuDungDien.Refresh();
        }

        private void dgvKySuDungDien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKySuDungDien.SelectedRows.Count > 0 && e.RowIndex >= 0 && e.RowIndex < dgvKySuDungDien.Rows.Count)
            {
                try
                {
                    string maKy = dgvKySuDungDien.Rows[e.RowIndex].Cells["MaKy"].Value.ToString();
                    CKySuDungDien ky = bll.TimKySuDung(maKy);
                    if (ky != null)
                    {
                        txtMaKy.Text = ky.MaKy;
                        txtTenKy.Text = ky.TenKy;
                        dtpNgayBatDau.Value = ky.NgayBatDauGhi;
                        dtpNgayKetThuc.Value = ky.NgayKetThucGhi;
                    }
                }
                catch
                {
                    
                }
            }
        }

        private void btnThemKy_Click(object sender, EventArgs e)
        {
            CKySuDungDien kyMoi = new CKySuDungDien
            {
                MaKy = txtMaKy.Text,
                TenKy = txtTenKy.Text,
                NgayBatDauGhi = dtpNgayBatDau.Value,
                NgayKetThucGhi = dtpNgayKetThuc.Value
            };

            if (bll.ThemKy(kyMoi))
            {
                HienThiDanhSach();
                MessageBox.Show("Thêm kỳ thành công.");
            }
            else
            {
                MessageBox.Show("Mã kỳ này đã tồn tại.");
            }
        }

        private void btnSuaKy_Click(object sender, EventArgs e)
        {
            CKySuDungDien kySua = new CKySuDungDien
            {
                MaKy = txtMaKy.Text,
                TenKy = txtTenKy.Text,
                NgayBatDauGhi = dtpNgayBatDau.Value,
                NgayKetThucGhi = dtpNgayKetThuc.Value
            };
            bll.SuaKy(kySua);
            HienThiDanhSach();
            MessageBox.Show("Cập nhật thành công.");
        }

        private void btnXoaKy_Click(object sender, EventArgs e)
        {
            string maKy = txtMaKy.Text;
            if (string.IsNullOrEmpty(maKy))
            {
                MessageBox.Show("Vui lòng chọn một kỳ để xóa.");
                return;
            }
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc muốn xóa vĩnh viễn kỳ '" + maKy + "' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                bll.XoaKy(maKy);
                HienThiDanhSach();
                MessageBox.Show("Đã xóa kỳ thành công.");
            }
        }

        private void btnTimKiemKy_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemKy.Text;
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }
            List<CKySuDungDien> ketQuaTimKiem = bll.TimKiem(tuKhoa);
            if (ketQuaTimKiem.Count > 0)
            {
                dgvKySuDungDien.DataSource = null;
                dgvKySuDungDien.DataSource = ketQuaTimKiem;
                dgvKySuDungDien.Refresh();
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp.");
            }
        }

        private void btnTaiLaiKy_Click(object sender, EventArgs e)
        {
            txtTimKiemKy.Text = "";
            HienThiDanhSach();
        }
    }
}
