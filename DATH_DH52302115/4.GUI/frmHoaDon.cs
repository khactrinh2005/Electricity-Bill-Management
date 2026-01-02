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
    public partial class frmHoaDon : Form
    {
        private BLL_HoaDon bllHD;
        public frmHoaDon()
        {
            bllHD = new BLL_HoaDon();
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadCboKy();
            LoadCboTimKiem();
            HienThiDanhSach();
            txtDonGiaHD.Text = "2000";
        }
        public void TaiLaiDuLieu()
        {
            LoadCboKy();
        }
        private void LoadCboKy()
        {
            List<CKySuDungDien> dsKy = bllHD.getDanhSachKy();
            List<CKySuDungDien> dsHienThi = new List<CKySuDungDien>();
            CKySuDungDien itemMacDinh = new CKySuDungDien();
            itemMacDinh.TenKy = "--- Chọn Kỳ sử dụng ---";
            itemMacDinh.MaKy = "";
            dsHienThi.Add(itemMacDinh);
            foreach (CKySuDungDien k in dsKy) dsHienThi.Add(k);
            cboKyHD.DataSource = dsHienThi;
            cboKyHD.DisplayMember = "TenKy";
            cboKyHD.ValueMember = "MaKy";
            cboKyHD.SelectedIndexChanged -= CboKyHD_SelectedIndexChanged;
            cboKyHD.SelectedIndexChanged += CboKyHD_SelectedIndexChanged;
            cboKyHD.SelectedIndex = 0;
        }
        private void CboKyHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKyHD.SelectedValue == null) return;

            string maKy = cboKyHD.SelectedValue.ToString();
            if (maKy == "")
            {
                cboMaSuDungHD.DataSource = null;
                return;
            }
            LoadCboMaSuDung(maKy);
        }

        private void LoadCboMaSuDung(string maKy)
        {
            List<CSuDungDien> dsSD = bllHD.getDanhSachSuDungTheoKy(maKy);
            List<CSuDungDien> dsHienThi = new List<CSuDungDien>();
            CSuDungDien itemMacDinh = new CSuDungDien();
            itemMacDinh.MaSD = "--- Chọn Phiếu SD ---";
            dsHienThi.Add(itemMacDinh);
            foreach (CSuDungDien sd in dsSD) dsHienThi.Add(sd);
            cboMaSuDungHD.DataSource = dsHienThi;
            cboMaSuDungHD.DisplayMember = "MaSD";
            cboMaSuDungHD.ValueMember = "MaSD";

            cboMaSuDungHD.SelectedIndexChanged -= cboMaSuDungHD_SelectedIndexChanged;
            cboMaSuDungHD.SelectedIndexChanged += cboMaSuDungHD_SelectedIndexChanged;

            if (dsHienThi.Count > 0) cboMaSuDungHD.SelectedIndex = 0;
        }

        private void cboMaSuDungHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThanhTienHD.Text = "";
        }
        private void btnTinhTienHD_Click(object sender, EventArgs e)
        {
            if (cboMaSuDungHD.SelectedItem == null ||
                cboMaSuDungHD.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn Phiếu sử dụng điện trước!");
                return;
            }
            CSuDungDien sd = (CSuDungDien)cboMaSuDungHD.SelectedItem;
            double donGia = 0;
            if (!double.TryParse(txtDonGiaHD.Text, out donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ! Vui lòng nhập số >= 0.");
                return;
            }
            double.TryParse(txtDonGiaHD.Text, out donGia);
            double thanhTien = sd.SoDien * donGia;
            txtThanhTienHD.Text = thanhTien.ToString("N0");
        }
        private void HienThiDanhSach()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bllHD.getDanhSachHoaDon();

            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.DataSource = bs;
            dgvHoaDon.Refresh();
        }

        private void dgvHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "KhachHang" && e.Value == null)
            {
                if (dgvHoaDon.Rows[e.RowIndex].DataBoundItem is CHoaDon)
                {
                    CHoaDon hd = (CHoaDon)dgvHoaDon.Rows[e.RowIndex].DataBoundItem;
                    if (hd.SuDungDien != null && hd.SuDungDien.DienKe != null && hd.SuDungDien.DienKe.KhachHang != null)
                    {
                        e.Value = hd.SuDungDien.DienKe.KhachHang.HoTen;
                        e.FormattingApplied = true;
                    }
                }
            }
            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "KySuDung" && e.Value == null)
            {
                if (dgvHoaDon.Rows[e.RowIndex].DataBoundItem is CHoaDon)
                {
                    CHoaDon hd = (CHoaDon)dgvHoaDon.Rows[e.RowIndex].DataBoundItem;
                    if (hd.SuDungDien != null && hd.SuDungDien.KySuDung != null)
                    {
                        e.Value = hd.SuDungDien.KySuDung.TenKy;
                        e.FormattingApplied = true;
                    }
                }
            }
            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value != null)
            {
                bool trangThai = (bool)e.Value;
                if (trangThai == true) e.Value = "Đã thanh toán";
                else e.Value = "Chưa thanh toán";
                e.FormattingApplied = true;
            }
            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "ThanhTien" && e.Value != null)
            {
                e.Value = double.Parse(e.Value.ToString()).ToString("N0");
                e.FormattingApplied = true;
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHoaDon.Rows.Count)
            {
                try
                {
                    if (dgvHoaDon.Rows[e.RowIndex].DataBoundItem is CHoaDon)
                    {
                        CHoaDon hd = (CHoaDon)dgvHoaDon.Rows[e.RowIndex].DataBoundItem;
                        if (hd != null)
                        {
                            txtMaHD.Text = hd.MaHoaDon;
                            txtDonGiaHD.Text = hd.DonGia.ToString();
                            txtThanhTienHD.Text = hd.ThanhTien.ToString("N0");
                            chkTrangThaiHD.Checked = hd.TrangThai;
                            if (hd.SuDungDien != null && hd.SuDungDien.KySuDung != null)
                            {
                                cboKyHD.SelectedValue = hd.SuDungDien.KySuDung.MaKy;
                                LoadCboMaSuDung(hd.SuDungDien.KySuDung.MaKy);
                                if (cboMaSuDungHD.DataSource == null)
                                {
                                    LoadCboMaSuDung(hd.SuDungDien.KySuDung.MaKy);
                                }
                                List<CSuDungDien> dsHienTai = (List<CSuDungDien>)cboMaSuDungHD.DataSource;
                                bool daCo = false;
                                if (dsHienTai != null)
                                    foreach (CSuDungDien s in dsHienTai) { if (s.MaSD == hd.SuDungDien.MaSD) daCo = true; }
                                if (!daCo)
                                {
                                    dsHienTai.Add(hd.SuDungDien);
                                    cboMaSuDungHD.DataSource = null;
                                    cboMaSuDungHD.DataSource = dsHienTai;
                                    cboMaSuDungHD.DisplayMember = "MaSD";
                                    cboMaSuDungHD.ValueMember = "MaSD";
                                }
                                cboMaSuDungHD.SelectedValue = hd.SuDungDien.MaSD;
                            }
                        }
                    }
                }
                catch 
                { 

                }
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text)) { MessageBox.Show("Vui lòng nhập mã hóa đơn!"); return; }
            if (cboMaSuDungHD.SelectedItem == null || cboMaSuDungHD.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn Phiếu sử dụng điện!"); return;
            }
            CSuDungDien sd = (CSuDungDien)cboMaSuDungHD.SelectedItem;
            double donGia = 0;
            double.TryParse(txtDonGiaHD.Text, out donGia);
            double thanhTien = sd.SoDien * donGia;
            txtThanhTienHD.Text = thanhTien.ToString("N0");
            CHoaDon hd = new CHoaDon();
            hd.MaHoaDon = txtMaHD.Text;
            hd.SuDungDien = sd;
            hd.DonGia = donGia;
            hd.TrangThai = chkTrangThaiHD.Checked;
            hd.NgayLap = DateTime.Now;
            if (bllHD.ThemHoaDon(hd))
            {
                HienThiDanhSach();
                if (cboKyHD.SelectedValue != null)
                    LoadCboMaSuDung(cboKyHD.SelectedValue.ToString());

                MessageBox.Show("Lập hóa đơn thành công!");
            }
            else
            {
                MessageBox.Show("Thất bại! Mã HĐ bị trùng hoặc Phiếu sử dụng này đã có hóa đơn rồi!");
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            CHoaDon hdMoi = new CHoaDon();
            hdMoi.MaHoaDon = maHD;
            hdMoi.TrangThai = chkTrangThaiHD.Checked;

            double donGia = 0;
            double.TryParse(txtDonGiaHD.Text, out donGia);
            hdMoi.DonGia = donGia;

            if (bllHD.SuaHoaDon(hdMoi))
            {
                HienThiDanhSach();
                MessageBox.Show("Cập nhật trạng thái thành công!");
            }
            else MessageBox.Show("Không tìm thấy mã hóa đơn để sửa!");
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            if (string.IsNullOrEmpty(maHD)) return;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bllHD.XoaHoaDon(maHD))
                {
                    HienThiDanhSach();
                    MessageBox.Show("Đã xóa thành công.");
                    txtMaHD.Clear();
                    txtThanhTienHD.Text = "";
                    txtDonGiaHD.Text = "2000";
                    chkTrangThaiHD.Checked = false;
                    if (cboMaSuDungHD.Items.Count > 0) cboMaSuDungHD.SelectedIndex = 0;
                    if (cboKyHD.SelectedValue != null)
                        LoadCboMaSuDung(cboKyHD.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hóa đơn.");
                }
            }
        }

        private void LoadCboTimKiem()
        {
            if (cboTimTrangThai.Items.Count > 0) 
                cboTimTrangThai.SelectedIndex = 0;
        }

        private void btnTimKiemHD_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemHD.Text.Trim();
            string timTenKH = "";
            string timTenKy = "";

            if (radHD_TheoKH.Checked)
            {
                timTenKH = tuKhoa;
                timTenKy = "";
            }
            else if (radHD_TheoKy.Checked)
            {
                timTenKH = "";
                timTenKy = tuKhoa;
            }
            int trangThai = -1;
            if (cboTimTrangThai.SelectedIndex == 1)
            {
                trangThai = 1;
            }
            else if (cboTimTrangThai.SelectedIndex == 2)
            {
                trangThai = 0;
            }
            List<CHoaDon> ketQua = bllHD.TimKiemNangCao(timTenKH, timTenKy, trangThai);
            if (ketQua.Count > 0)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = ketQua;
                dgvHoaDon.DataSource = bs;
                dgvHoaDon.Refresh();
            }
            else
            {
                dgvHoaDon.DataSource = null;
                MessageBox.Show("Không tìm thấy hóa đơn nào thỏa mãn điều kiện!");
            }
        }

        
    }
}
