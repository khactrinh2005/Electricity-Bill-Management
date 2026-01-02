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
    public partial class frmSuDungDien : Form
    {
        private BLL_SuDungDien bllSD;
        private CNhanVien m_nhanVienGhiDien;
        public frmSuDungDien(CNhanVien nv) 
        {
            InitializeComponent();
            bllSD = new BLL_SuDungDien();
            m_nhanVienGhiDien = nv;
            if (m_nhanVienGhiDien != null)
                txtNhanVienSD.Text = m_nhanVienGhiDien.HoTen;
        }
        public frmSuDungDien()
        {
            bllSD = new BLL_SuDungDien();
            InitializeComponent();
        }

        private void frmSuDungDien_Load(object sender, EventArgs e)
        {
            LoadCboKy();
            HienThiDanhSach();
        }
        public void TaiLaiDuLieu()
        {
            LoadCboKy();
        }
        
        private void LoadCboKy()
        {
            List<CKySuDungDien> dsGoc = bllSD.getDanhSachKy();
            List<CKySuDungDien> dsHienThi = new List<CKySuDungDien>();
            CKySuDungDien itemMacDinh = new CKySuDungDien();
            CKySuDungDien itemTatCa = new CKySuDungDien();
            itemTatCa.TenKy = "--- Xem Tất Cả ---";
            itemTatCa.MaKy = "";
            dsHienThi.Add(itemTatCa);
            foreach (CKySuDungDien ky in dsGoc)
            {
                dsHienThi.Add(ky);
            }
            cboKySD.DataSource = dsHienThi;
            cboKySD.DisplayMember = "TenKy";
            cboKySD.ValueMember = "MaKy";
            if (cboKySD.Items.Count > 0) cboKySD.SelectedIndex = 0;
        }

        private void HienThiDanhSach()
        {
            List<CSuDungDien> dsFull = bllSD.getDanhSachSuDung();
            List<CSuDungDien> dsHienThi = new List<CSuDungDien>();
            if (cboKySD.SelectedIndex > 0 && cboKySD.SelectedValue != null)
            {
                string maKyDangChon = cboKySD.SelectedValue.ToString();

                foreach (CSuDungDien sd in dsFull)
                {
                    if (sd.KySuDung != null && sd.KySuDung.MaKy == maKyDangChon)
                        dsHienThi.Add(sd);
                }
            }
            else dsHienThi = dsFull;
            BindingSource bs = new BindingSource();
            bs.DataSource = dsHienThi;

            dgvSuDung.AutoGenerateColumns = false;
            dgvSuDung.DataSource = bs;

            if (dgvSuDung.Columns["NgayGhi"] != null)
                dgvSuDung.Columns["NgayGhi"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSuDung.Refresh();
        }
        private void cboKySD_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void btnTaiLaiSD_Click(object sender, EventArgs e)
        {
            txtTimKiemSD.Clear();
            HienThiDanhSach();
        }

        

        private void dgvSuDung_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSuDung.Columns[e.ColumnIndex].Name == "DienKe" && e.Value != null)
            {
                if (e.Value is CDienKe)
                {
                    e.Value = ((CDienKe)e.Value).MaDienKe;
                    e.FormattingApplied = true;
                }
            }
            if (dgvSuDung.Columns[e.ColumnIndex].Name == "KySuDung" && e.Value != null)
            {
                if (e.Value is CKySuDungDien)
                {
                    e.Value = ((CKySuDungDien)e.Value).TenKy;
                    e.FormattingApplied = true;
                }
            }
            if (dgvSuDung.Columns[e.ColumnIndex].Name == "NhanVien" && e.Value != null)
            {
                if (e.Value is CNhanVien)
                {
                    e.Value = ((CNhanVien)e.Value).HoTen;
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvSuDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSuDung.SelectedRows.Count > 0 && e.RowIndex < dgvSuDung.Rows.Count)
            {
                try
                {
                    string maSD = dgvSuDung.Rows[e.RowIndex].Cells["MaSD"].Value.ToString();
                    CSuDungDien sd = bllSD.TimSuDung(maSD);

                    if (sd != null)
                    {
                        txtMaSuDung.Text = sd.MaSD;
                        dtpNgayGhiSD.Value = sd.NgayGhi;
                        if (sd.KySuDung != null) cboKySD.SelectedValue = sd.KySuDung.MaKy;
                        txtSoMoiSD.Text = sd.ChiSoMoi.ToString();
                    }
                }
                catch
                {
                    
                }
            }
        }
        private void LoadDanhSachNhapLieu()
        {
            dgvNhapLieu.Rows.Clear();
            List<CDienKe> dsDienKe = bllSD.getDanhSachDienKe();

            foreach (CDienKe dk in dsDienKe)
            {
                if (dk.TrangThai == "Đang hoạt động")
                {
                    int chiSoCu = bllSD.LayChiSoCu(dk.MaDienKe);
                    int index = dgvNhapLieu.Rows.Add();
                    dgvNhapLieu.Rows[index].Cells["colChon"].Value = false;
                    dgvNhapLieu.Rows[index].Cells["colMaDK"].Value = dk.MaDienKe;
                    if (dk.KhachHang != null)
                        dgvNhapLieu.Rows[index].Cells["colTenKH"].Value = dk.KhachHang.HoTen;
                    else
                        dgvNhapLieu.Rows[index].Cells["colTenKH"].Value = "Chưa gán";

                    dgvNhapLieu.Rows[index].Cells["colChiSoCu"].Value = chiSoCu;
                    dgvNhapLieu.Rows[index].Cells["colChiSoMoi"].Value = 0;
                    CapNhatTrangThaiDong(index, false);
                }
            }
            dgvNhapLieu.ClearSelection();
        }
        private void CapNhatTrangThaiDong(int rowIndex, bool duocChon)
        {
            DataGridViewRow row = dgvNhapLieu.Rows[rowIndex];

            if (duocChon)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
                row.Cells["colChiSoMoi"].ReadOnly = false;
                row.Cells["colChiSoMoi"].Style.BackColor = Color.White;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
                row.DefaultCellStyle.ForeColor = Color.Gray;
                row.Cells["colChiSoMoi"].ReadOnly = true;
                row.Cells["colChiSoMoi"].Style.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        private void btnThemSD_Click(object sender, EventArgs e)
        {
            if (cboKySD.SelectedItem == null || cboKySD.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn Kỳ sử dụng trước khi lập phiếu!");
                return;
            }
            pnlNhapLieu.Visible = true;
            pnlNhapLieu.BringToFront();
            LoadDanhSachNhapLieu();
        }

        private void btnSuaSD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSuDung.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu cần sửa!");
                return;
            }
            CSuDungDien sd = bllSD.TimSuDung(txtMaSuDung.Text);
            if (sd != null)
            {
                int soMoi = 0;
                if (!int.TryParse(txtSoMoiSD.Text, out soMoi))
                {
                    MessageBox.Show("Chỉ số mới phải là số nguyên!");
                    return;
                }
                if (soMoi < sd.ChiSoCu)
                {
                    MessageBox.Show("Chỉ số mới không được nhỏ hơn chỉ số cũ (" + sd.ChiSoCu + ")!");
                    return;
                }
                sd.ChiSoMoi = soMoi;
                sd.NhanVien = m_nhanVienGhiDien;
                sd.NgayGhi = DateTime.Now;
                if (bllSD.SuaSuDung(sd))
                {
                    HienThiDanhSach();
                    MessageBox.Show("Cập nhật thành công!");
                    txtSoMoiSD.Clear();
                    txtMaSuDung.Clear();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi lưu xuống CSDL!");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu sử dụng này!");
            }
        }

        private void btnXoaSD_Click(object sender, EventArgs e)
        {
            string maSD = txtMaSuDung.Text;
            if (string.IsNullOrEmpty(maSD)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bllSD.XoaSuDung(maSD))
                {
                    HienThiDanhSach();
                    MessageBox.Show("Đã xóa thành công.");
                    txtMaSuDung.Clear();
                }
                else MessageBox.Show("Không tìm thấy mã để xóa.");
            }
        }

        private void btnTimKiemSD_Click(object sender, EventArgs e)
        {

            List<CSuDungDien> ketQua = bllSD.TimKiem(txtTimKiemSD.Text, radSD_TheoDK.Checked);

            if (ketQua.Count > 0)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = ketQua;
                dgvSuDung.DataSource = bs;
                dgvSuDung.Refresh();
            }
            else
            {
                dgvSuDung.DataSource = null;
                MessageBox.Show("Không tìm thấy kết quả nào.");
            }
        }

        private void dgvNhapLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNhapLieu.Columns[e.ColumnIndex].Name == "colChon")
            {
                dgvNhapLieu.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvNhapLieu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNhapLieu.Columns[e.ColumnIndex].Name == "colChon")
            {
                bool isChecked = Convert.ToBoolean(dgvNhapLieu.Rows[e.RowIndex].Cells["colChon"].Value);
                CapNhatTrangThaiDong(e.RowIndex, isChecked);
                if (isChecked)
                {
                    dgvNhapLieu.CurrentCell = dgvNhapLieu.Rows[e.RowIndex].Cells["colChiSoMoi"];
                    dgvNhapLieu.BeginEdit(true);
                }
            }
        }

        private void btnLuuDK_Click(object sender, EventArgs e)
        {
            CKySuDungDien ky = (CKySuDungDien)cboKySD.SelectedItem;
            int demThanhCong = 0;
            foreach (DataGridViewRow row in dgvNhapLieu.Rows)
            {
                if (row.Cells["colChon"].Value == null) continue;

                bool duocChon = Convert.ToBoolean(row.Cells["colChon"].Value);
                if (duocChon)
                {
                    try
                    {
                        string maDK = row.Cells["colMaDK"].Value.ToString();
                        int chiSoCu = int.Parse(row.Cells["colChiSoCu"].Value.ToString());
                        int chiSoMoi = int.Parse(row.Cells["colChiSoMoi"].Value.ToString());
                        if (chiSoMoi < chiSoCu) continue;
                        CSuDungDien sd = new CSuDungDien();
                        sd.MaSD = "SD_" + ky.TenKy + "_" + maDK;
                        foreach (CDienKe dk in bllSD.getDanhSachDienKe())
                        {
                            if (dk.MaDienKe == maDK) { sd.DienKe = dk; break; }
                        }
                        sd.KySuDung = ky;
                        sd.NhanVien = m_nhanVienGhiDien;
                        sd.NgayGhi = dtpNgayGhiSD.Value;
                        sd.ChiSoCu = chiSoCu;
                        sd.ChiSoMoi = chiSoMoi;
                        if (bllSD.ThemSuDung(sd))
                        {
                            demThanhCong++;
                        }
                    }
                    catch { }
                }
            }

            MessageBox.Show("Đã lưu thành công " + demThanhCong + " phiếu!");
            pnlNhapLieu.Visible = false;
            HienThiDanhSach();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnlNhapLieu.Visible = false;
            dgvNhapLieu.Rows.Clear();
        }

        
    }
}
