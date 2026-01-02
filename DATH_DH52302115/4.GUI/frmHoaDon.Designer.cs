namespace DATH_DH52302115
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.grpTimKiemHD = new System.Windows.Forms.GroupBox();
            this.cboTimTrangThai = new System.Windows.Forms.ComboBox();
            this.radHD_TheoKH = new System.Windows.Forms.RadioButton();
            this.radHD_TheoKy = new System.Windows.Forms.RadioButton();
            this.btnTimKiemHD = new System.Windows.Forms.Button();
            this.btnTaiLaiHD = new System.Windows.Forms.Button();
            this.txtTimKiemHD = new System.Windows.Forms.TextBox();
            this.cboKyHD = new System.Windows.Forms.ComboBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDonGiaHD = new System.Windows.Forms.TextBox();
            this.txtThanhTienHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTrangThaiHD = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMaSuDungHD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhTienHD = new System.Windows.Forms.Button();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KySuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTimKiemHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Đơn giá";
            // 
            // grpTimKiemHD
            // 
            this.grpTimKiemHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiemHD.Controls.Add(this.cboTimTrangThai);
            this.grpTimKiemHD.Controls.Add(this.radHD_TheoKH);
            this.grpTimKiemHD.Controls.Add(this.radHD_TheoKy);
            this.grpTimKiemHD.Controls.Add(this.btnTimKiemHD);
            this.grpTimKiemHD.Controls.Add(this.btnTaiLaiHD);
            this.grpTimKiemHD.Controls.Add(this.txtTimKiemHD);
            this.grpTimKiemHD.Location = new System.Drawing.Point(549, 131);
            this.grpTimKiemHD.Name = "grpTimKiemHD";
            this.grpTimKiemHD.Size = new System.Drawing.Size(248, 100);
            this.grpTimKiemHD.TabIndex = 96;
            this.grpTimKiemHD.TabStop = false;
            this.grpTimKiemHD.Text = "Tìm kiếm";
            // 
            // cboTimTrangThai
            // 
            this.cboTimTrangThai.FormattingEnabled = true;
            this.cboTimTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cboTimTrangThai.Location = new System.Drawing.Point(57, 73);
            this.cboTimTrangThai.Name = "cboTimTrangThai";
            this.cboTimTrangThai.Size = new System.Drawing.Size(184, 21);
            this.cboTimTrangThai.TabIndex = 110;
            // 
            // radHD_TheoKH
            // 
            this.radHD_TheoKH.AutoSize = true;
            this.radHD_TheoKH.Location = new System.Drawing.Point(128, 51);
            this.radHD_TheoKH.Name = "radHD_TheoKH";
            this.radHD_TheoKH.Size = new System.Drawing.Size(111, 17);
            this.radHD_TheoKH.TabIndex = 36;
            this.radHD_TheoKH.Text = "Theo Khách hàng";
            this.radHD_TheoKH.UseVisualStyleBackColor = true;
            // 
            // radHD_TheoKy
            // 
            this.radHD_TheoKy.AutoSize = true;
            this.radHD_TheoKy.Checked = true;
            this.radHD_TheoKy.Location = new System.Drawing.Point(57, 51);
            this.radHD_TheoKy.Name = "radHD_TheoKy";
            this.radHD_TheoKy.Size = new System.Drawing.Size(65, 17);
            this.radHD_TheoKy.TabIndex = 35;
            this.radHD_TheoKy.TabStop = true;
            this.radHD_TheoKy.Text = "Theo Kỳ";
            this.radHD_TheoKy.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemHD
            // 
            this.btnTimKiemHD.AutoSize = true;
            this.btnTimKiemHD.Location = new System.Drawing.Point(6, 24);
            this.btnTimKiemHD.Name = "btnTimKiemHD";
            this.btnTimKiemHD.Size = new System.Drawing.Size(45, 23);
            this.btnTimKiemHD.TabIndex = 33;
            this.btnTimKiemHD.Text = "Tìm";
            this.btnTimKiemHD.UseVisualStyleBackColor = true;
            this.btnTimKiemHD.Click += new System.EventHandler(this.btnTimKiemHD_Click);
            // 
            // btnTaiLaiHD
            // 
            this.btnTaiLaiHD.AutoSize = true;
            this.btnTaiLaiHD.Location = new System.Drawing.Point(6, 48);
            this.btnTaiLaiHD.Name = "btnTaiLaiHD";
            this.btnTaiLaiHD.Size = new System.Drawing.Size(45, 23);
            this.btnTaiLaiHD.TabIndex = 34;
            this.btnTaiLaiHD.Text = "Tải lại";
            this.btnTaiLaiHD.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemHD
            // 
            this.txtTimKiemHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemHD.Location = new System.Drawing.Point(57, 26);
            this.txtTimKiemHD.Name = "txtTimKiemHD";
            this.txtTimKiemHD.Size = new System.Drawing.Size(182, 20);
            this.txtTimKiemHD.TabIndex = 32;
            // 
            // cboKyHD
            // 
            this.cboKyHD.FormattingEnabled = true;
            this.cboKyHD.Location = new System.Drawing.Point(173, 81);
            this.cboKyHD.Name = "cboKyHD";
            this.cboKyHD.Size = new System.Drawing.Size(167, 21);
            this.cboKyHD.TabIndex = 94;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.KhachHang,
            this.KySuDung,
            this.ThanhTien,
            this.TrangThai});
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 237);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(794, 211);
            this.dgvHoaDon.TabIndex = 93;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            this.dgvHoaDon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHoaDon_CellFormatting);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaHD.AutoSize = true;
            this.btnXoaHD.Location = new System.Drawing.Point(724, 89);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(64, 35);
            this.btnXoaHD.TabIndex = 92;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaHD.AutoSize = true;
            this.btnSuaHD.Location = new System.Drawing.Point(654, 89);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(64, 35);
            this.btnSuaHD.TabIndex = 91;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.UseVisualStyleBackColor = true;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemHD.AutoSize = true;
            this.btnThemHD.Location = new System.Drawing.Point(584, 89);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(64, 35);
            this.btnThemHD.TabIndex = 90;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(173, 55);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(167, 20);
            this.txtMaHD.TabIndex = 89;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(46, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 87;
            this.label18.Text = "Kỳ sử dụng";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(46, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 86;
            this.label19.Text = "Mã hóa đơn";
            // 
            // txtDonGiaHD
            // 
            this.txtDonGiaHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGiaHD.Location = new System.Drawing.Point(173, 135);
            this.txtDonGiaHD.Name = "txtDonGiaHD";
            this.txtDonGiaHD.Size = new System.Drawing.Size(167, 20);
            this.txtDonGiaHD.TabIndex = 105;
            // 
            // txtThanhTienHD
            // 
            this.txtThanhTienHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhTienHD.Location = new System.Drawing.Point(173, 161);
            this.txtThanhTienHD.Name = "txtThanhTienHD";
            this.txtThanhTienHD.ReadOnly = true;
            this.txtThanhTienHD.Size = new System.Drawing.Size(167, 20);
            this.txtThanhTienHD.TabIndex = 107;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "Thành tiền";
            // 
            // chkTrangThaiHD
            // 
            this.chkTrangThaiHD.AutoSize = true;
            this.chkTrangThaiHD.Checked = true;
            this.chkTrangThaiHD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThaiHD.Location = new System.Drawing.Point(173, 187);
            this.chkTrangThaiHD.Name = "chkTrangThaiHD";
            this.chkTrangThaiHD.Size = new System.Drawing.Size(94, 17);
            this.chkTrangThaiHD.TabIndex = 109;
            this.chkTrangThaiHD.Text = "Đã thanh toán";
            this.chkTrangThaiHD.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "Trạng thái";
            // 
            // cboMaSuDungHD
            // 
            this.cboMaSuDungHD.FormattingEnabled = true;
            this.cboMaSuDungHD.Location = new System.Drawing.Point(173, 108);
            this.cboMaSuDungHD.Name = "cboMaSuDungHD";
            this.cboMaSuDungHD.Size = new System.Drawing.Size(167, 21);
            this.cboMaSuDungHD.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "Mã sử dụng";
            // 
            // btnTinhTienHD
            // 
            this.btnTinhTienHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTinhTienHD.AutoSize = true;
            this.btnTinhTienHD.Location = new System.Drawing.Point(346, 159);
            this.btnTinhTienHD.Name = "btnTinhTienHD";
            this.btnTinhTienHD.Size = new System.Drawing.Size(60, 23);
            this.btnTinhTienHD.TabIndex = 112;
            this.btnTinhTienHD.Text = "Tính tiền";
            this.btnTinhTienHD.UseVisualStyleBackColor = true;
            this.btnTinhTienHD.Click += new System.EventHandler(this.btnTinhTienHD_Click);
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaHD.DataPropertyName = "MaHoaDon";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 90;
            // 
            // KhachHang
            // 
            this.KhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KhachHang.HeaderText = "Khách hàng";
            this.KhachHang.MinimumWidth = 150;
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.ReadOnly = true;
            // 
            // KySuDung
            // 
            this.KySuDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KySuDung.HeaderText = "Kỳ sử dụng";
            this.KySuDung.Name = "KySuDung";
            this.KySuDung.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.FillWeight = 50F;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.FillWeight = 50F;
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinhTienHD);
            this.Controls.Add(this.cboMaSuDungHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkTrangThaiHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtThanhTienHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDonGiaHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpTimKiemHD);
            this.Controls.Add(this.cboKyHD);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.btnSuaHD);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.grpTimKiemHD.ResumeLayout(false);
            this.grpTimKiemHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpTimKiemHD;
        private System.Windows.Forms.RadioButton radHD_TheoKH;
        private System.Windows.Forms.RadioButton radHD_TheoKy;
        private System.Windows.Forms.Button btnTimKiemHD;
        private System.Windows.Forms.Button btnTaiLaiHD;
        private System.Windows.Forms.TextBox txtTimKiemHD;
        private System.Windows.Forms.ComboBox cboKyHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDonGiaHD;
        private System.Windows.Forms.TextBox txtThanhTienHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTrangThaiHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTimTrangThai;
        private System.Windows.Forms.ComboBox cboMaSuDungHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhTienHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn KySuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}