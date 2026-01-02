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
    public partial class frmDienKe : Form
    {
        BLL_DienKe bllDK = new BLL_DienKe();
        BLL_KhachHang bllKH = new BLL_KhachHang();
        public frmDienKe()
        {
            InitializeComponent();
        }
        public void TaiLaiDanhSachKhachHang()
        {
            LoadCboKhachHangChoDienKe();
        }
        private void LoadCboKhachHangChoDienKe()
        {
            List<CKhachHang> dsGoc = bllKH.getDanhSachKhachHang();
            List<CKhachHang> dsHoatDong = new List<CKhachHang>();
            CKhachHang khMacDinh = new CKhachHang();
            khMacDinh.MaKH = "";
            khMacDinh.HoTen = "--- Chọn khách hàng ---";
            dsHoatDong.Add(khMacDinh);
            foreach (CKhachHang kh in dsGoc)
            {
                if (kh.TrangThai == true)
                {
                    dsHoatDong.Add(kh);
                }
            }
            string maDaChon = null;
            if (cboKhachHangDK.SelectedValue != null)
            {
                maDaChon = cboKhachHangDK.SelectedValue.ToString();
            }
            cboKhachHangDK.DataSource = dsHoatDong;
            cboKhachHangDK.DisplayMember = "HoTen";
            cboKhachHangDK.ValueMember = "MaKH";
            if (maDaChon != null)
            {
                cboKhachHangDK.SelectedValue = maDaChon;
            }
            else
            {
                cboKhachHangDK.SelectedIndex = 0;
            }
        }
        private void HienThiDanhSach()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bllDK.getDanhSachDienKe();
            dgvDienKe.AutoGenerateColumns = false;
            dgvDienKe.DataSource = bs;
            if (dgvDienKe.Columns["NgayLapDat"] != null)
                dgvDienKe.Columns["NgayLapDat"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDienKe.Refresh();
        }

        private void frmDienKe_Load(object sender, EventArgs e)
        {
            LoadCboKhachHangChoDienKe();
            HienThiDanhSach();
            if (cboTrangThaiDK.Items.Count > 0) cboTrangThaiDK.SelectedIndex = 0;
            dgvDienKe.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvDienKe_CellFormatting);
        }

        private void dgvDienKe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDienKe.Columns[e.ColumnIndex].Name == "KhachHang" && e.Value != null)
            {
                if (e.Value is CKhachHang)
                {
                    CKhachHang kh = (CKhachHang)e.Value;

                    if (string.IsNullOrEmpty(kh.MaKH))
                    {
                        e.Value = "--- Chưa gán ---";
                    }
                    else
                    {
                        e.Value = kh.HoTen;
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvDienKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDienKe.SelectedRows.Count > 0 && e.RowIndex < dgvDienKe.Rows.Count)
            {
                try
                {
                    string maDK = dgvDienKe.Rows[e.RowIndex].Cells["MaDienKe"].Value.ToString();
                    CDienKe dk = bllDK.TimDienKe(maDK);

                    if (dk != null)
                    {
                        txtMaDK.Text = dk.MaDienKe;
                        dtpNgayLapDatDK.Value = dk.NgayLapDat;
                        cboTrangThaiDK.Text = dk.TrangThai;
                        if (dk.KhachHang != null && !string.IsNullOrEmpty(dk.KhachHang.MaKH))
                        {
                            cboKhachHangDK.SelectedValue = dk.KhachHang.MaKH;
                        }
                        else
                        {
                            cboKhachHangDK.SelectedIndex = 0;
                        }
                    }
                }
                catch
                {
                    
                }
            }
        }

        private void btnThemDK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDK.Text))
            {
                MessageBox.Show("Vui lòng nhập mã điện kế");
                return;
            }
            CDienKe dkMoi = new CDienKe();

            dkMoi.MaDienKe = txtMaDK.Text;
            if (cboKhachHangDK.SelectedItem != null)
            {
                CKhachHang khChon = (CKhachHang)cboKhachHangDK.SelectedItem;
                if (string.IsNullOrEmpty(khChon.MaKH))
                {
                    dkMoi.KhachHang = null;
                }
                else
                {
                    dkMoi.KhachHang = khChon;
                }
            }
            dkMoi.NgayLapDat = dtpNgayLapDatDK.Value;
            dkMoi.TrangThai = cboTrangThaiDK.Text;
            if (bllDK.ThemDienKe(dkMoi))
            {
                HienThiDanhSach();
                MessageBox.Show("Thêm điện kế thành công.");
            }
            else
            {
                MessageBox.Show("Mã điện kế này đã tồn tại.");
            }
        }

        private void btnSuaDK_Click(object sender, EventArgs e)
        {
            if (cboKhachHangDK.SelectedValue == null) return;

            CDienKe dkSua = new CDienKe();
            dkSua.MaDienKe = txtMaDK.Text;
            if (cboKhachHangDK.SelectedItem != null)
            {
                CKhachHang khChon = (CKhachHang)cboKhachHangDK.SelectedItem;
                if (string.IsNullOrEmpty(khChon.MaKH))
                {
                    dkSua.KhachHang = null;
                }
                else
                {
                    dkSua.KhachHang = khChon;
                }
            }
            dkSua.NgayLapDat = dtpNgayLapDatDK.Value;
            dkSua.TrangThai = cboTrangThaiDK.Text;
            bllDK.SuaDienKe(dkSua);
            HienThiDanhSach();
            MessageBox.Show("Cập nhật thông tin điện kế thành công.");
        }

        private void btnXoaDK_Click(object sender, EventArgs e)
        {
            string maDK = txtMaDK.Text;
            if (string.IsNullOrEmpty(maDK))
            {
                MessageBox.Show("Vui lòng chọn điện kế để xóa.");
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa điện kế " + maDK + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bllDK.XoaDienKe(maDK))
                {
                    HienThiDanhSach();
                    MessageBox.Show("Đã xóa điện kế.");
                    txtMaDK.Clear();
                    cboKhachHangDK.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy điện kế để xóa.");
                }
            }
        }

        private void btnTimKiemDK_Click(object sender, EventArgs e)
        {
            List<CDienKe> ketQua = bllDK.TimKiem(txtTimKiemDK.Text, radDienKe_TheoMa.Checked);
            if (ketQua.Count > 0)
            {
                dgvDienKe.DataSource = null;
                dgvDienKe.DataSource = ketQua;
                dgvDienKe.Refresh();
            }
            else
            {
                dgvDienKe.DataSource = null;
                MessageBox.Show("Không tìm thấy điện kế nào phù hợp.");
            }
        }

        private void btnTaiLaiDK_Click(object sender, EventArgs e)
        {
            txtTimKiemDK.Clear();
            HienThiDanhSach();
        }
    }
}
