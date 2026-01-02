namespace DATH_DH52302115
{
    partial class frmDienKe
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
            this.grpTimKiemDK = new System.Windows.Forms.GroupBox();
            this.radDK_TheoTenKH = new System.Windows.Forms.RadioButton();
            this.radDienKe_TheoMa = new System.Windows.Forms.RadioButton();
            this.btnTimKiemDK = new System.Windows.Forms.Button();
            this.btnTaiLaiDK = new System.Windows.Forms.Button();
            this.txtTimKiemDK = new System.Windows.Forms.TextBox();
            this.cboTrangThaiDK = new System.Windows.Forms.ComboBox();
            this.dtpNgayLapDatDK = new System.Windows.Forms.DateTimePicker();
            this.cboKhachHangDK = new System.Windows.Forms.ComboBox();
            this.dgvDienKe = new System.Windows.Forms.DataGridView();
            this.MaDienKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaDK = new System.Windows.Forms.Button();
            this.btnSuaDK = new System.Windows.Forms.Button();
            this.btnThemDK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaDK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.grpTimKiemDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienKe)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTimKiemDK
            // 
            this.grpTimKiemDK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiemDK.Controls.Add(this.radDK_TheoTenKH);
            this.grpTimKiemDK.Controls.Add(this.radDienKe_TheoMa);
            this.grpTimKiemDK.Controls.Add(this.btnTimKiemDK);
            this.grpTimKiemDK.Controls.Add(this.btnTaiLaiDK);
            this.grpTimKiemDK.Controls.Add(this.txtTimKiemDK);
            this.grpTimKiemDK.Location = new System.Drawing.Point(503, 47);
            this.grpTimKiemDK.Name = "grpTimKiemDK";
            this.grpTimKiemDK.Size = new System.Drawing.Size(285, 81);
            this.grpTimKiemDK.TabIndex = 64;
            this.grpTimKiemDK.TabStop = false;
            this.grpTimKiemDK.Text = "Tìm kiếm";
            // 
            // radDK_TheoTenKH
            // 
            this.radDK_TheoTenKH.AutoSize = true;
            this.radDK_TheoTenKH.Location = new System.Drawing.Point(160, 51);
            this.radDK_TheoTenKH.Name = "radDK_TheoTenKH";
            this.radDK_TheoTenKH.Size = new System.Drawing.Size(111, 17);
            this.radDK_TheoTenKH.TabIndex = 36;
            this.radDK_TheoTenKH.Text = "Theo Khách hàng";
            this.radDK_TheoTenKH.UseVisualStyleBackColor = true;
            // 
            // radDienKe_TheoMa
            // 
            this.radDienKe_TheoMa.AutoSize = true;
            this.radDienKe_TheoMa.Checked = true;
            this.radDienKe_TheoMa.Location = new System.Drawing.Point(86, 52);
            this.radDienKe_TheoMa.Name = "radDienKe_TheoMa";
            this.radDienKe_TheoMa.Size = new System.Drawing.Size(68, 17);
            this.radDienKe_TheoMa.TabIndex = 35;
            this.radDienKe_TheoMa.TabStop = true;
            this.radDienKe_TheoMa.Text = "Theo Mã";
            this.radDienKe_TheoMa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemDK
            // 
            this.btnTimKiemDK.AutoSize = true;
            this.btnTimKiemDK.Location = new System.Drawing.Point(16, 23);
            this.btnTimKiemDK.Name = "btnTimKiemDK";
            this.btnTimKiemDK.Size = new System.Drawing.Size(45, 23);
            this.btnTimKiemDK.TabIndex = 33;
            this.btnTimKiemDK.Text = "Tìm";
            this.btnTimKiemDK.UseVisualStyleBackColor = true;
            this.btnTimKiemDK.Click += new System.EventHandler(this.btnTimKiemDK_Click);
            // 
            // btnTaiLaiDK
            // 
            this.btnTaiLaiDK.AutoSize = true;
            this.btnTaiLaiDK.Location = new System.Drawing.Point(16, 48);
            this.btnTaiLaiDK.Name = "btnTaiLaiDK";
            this.btnTaiLaiDK.Size = new System.Drawing.Size(45, 23);
            this.btnTaiLaiDK.TabIndex = 34;
            this.btnTaiLaiDK.Text = "Tải lại";
            this.btnTaiLaiDK.UseVisualStyleBackColor = true;
            this.btnTaiLaiDK.Click += new System.EventHandler(this.btnTaiLaiDK_Click);
            // 
            // txtTimKiemDK
            // 
            this.txtTimKiemDK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemDK.Location = new System.Drawing.Point(67, 25);
            this.txtTimKiemDK.Name = "txtTimKiemDK";
            this.txtTimKiemDK.Size = new System.Drawing.Size(212, 20);
            this.txtTimKiemDK.TabIndex = 32;
            // 
            // cboTrangThaiDK
            // 
            this.cboTrangThaiDK.FormattingEnabled = true;
            this.cboTrangThaiDK.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Đang sửa chữa",
            "Hỏng"});
            this.cboTrangThaiDK.Location = new System.Drawing.Point(154, 161);
            this.cboTrangThaiDK.Name = "cboTrangThaiDK";
            this.cboTrangThaiDK.Size = new System.Drawing.Size(219, 21);
            this.cboTrangThaiDK.TabIndex = 63;
            // 
            // dtpNgayLapDatDK
            // 
            this.dtpNgayLapDatDK.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLapDatDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapDatDK.Location = new System.Drawing.Point(154, 131);
            this.dtpNgayLapDatDK.MaxDate = new System.DateTime(9998, 12, 30, 0, 0, 0, 0);
            this.dtpNgayLapDatDK.MinDate = new System.DateTime(1753, 1, 2, 0, 0, 0, 0);
            this.dtpNgayLapDatDK.Name = "dtpNgayLapDatDK";
            this.dtpNgayLapDatDK.Size = new System.Drawing.Size(219, 20);
            this.dtpNgayLapDatDK.TabIndex = 62;
            this.dtpNgayLapDatDK.Value = new System.DateTime(2025, 11, 17, 0, 0, 0, 0);
            // 
            // cboKhachHangDK
            // 
            this.cboKhachHangDK.DisplayMember = "HoTen";
            this.cboKhachHangDK.FormattingEnabled = true;
            this.cboKhachHangDK.Location = new System.Drawing.Point(154, 99);
            this.cboKhachHangDK.Name = "cboKhachHangDK";
            this.cboKhachHangDK.Size = new System.Drawing.Size(219, 21);
            this.cboKhachHangDK.TabIndex = 60;
            this.cboKhachHangDK.ValueMember = "MaKH";
            // 
            // dgvDienKe
            // 
            this.dgvDienKe.AllowUserToAddRows = false;
            this.dgvDienKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDienKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDienKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDienKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDienKe,
            this.KhachHang,
            this.NgayLapDat,
            this.TrangThai});
            this.dgvDienKe.Location = new System.Drawing.Point(3, 238);
            this.dgvDienKe.Name = "dgvDienKe";
            this.dgvDienKe.ReadOnly = true;
            this.dgvDienKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDienKe.Size = new System.Drawing.Size(794, 211);
            this.dgvDienKe.TabIndex = 59;
            this.dgvDienKe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDienKe_CellClick);
            this.dgvDienKe.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDienKe_CellFormatting);
            // 
            // MaDienKe
            // 
            this.MaDienKe.DataPropertyName = "MaDienKe";
            this.MaDienKe.FillWeight = 15F;
            this.MaDienKe.HeaderText = "Mã ĐK";
            this.MaDienKe.Name = "MaDienKe";
            this.MaDienKe.ReadOnly = true;
            // 
            // KhachHang
            // 
            this.KhachHang.DataPropertyName = "KhachHang";
            this.KhachHang.FillWeight = 30F;
            this.KhachHang.HeaderText = "Khách hàng";
            this.KhachHang.MinimumWidth = 150;
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.ReadOnly = true;
            // 
            // NgayLapDat
            // 
            this.NgayLapDat.DataPropertyName = "NgayLapDat";
            this.NgayLapDat.FillWeight = 20F;
            this.NgayLapDat.HeaderText = "Ngày Lắp";
            this.NgayLapDat.Name = "NgayLapDat";
            this.NgayLapDat.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.FillWeight = 20F;
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 100;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnXoaDK
            // 
            this.btnXoaDK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDK.AutoSize = true;
            this.btnXoaDK.Location = new System.Drawing.Point(710, 138);
            this.btnXoaDK.Name = "btnXoaDK";
            this.btnXoaDK.Size = new System.Drawing.Size(64, 35);
            this.btnXoaDK.TabIndex = 58;
            this.btnXoaDK.Text = "Xóa";
            this.btnXoaDK.UseVisualStyleBackColor = true;
            this.btnXoaDK.Click += new System.EventHandler(this.btnXoaDK_Click);
            // 
            // btnSuaDK
            // 
            this.btnSuaDK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaDK.AutoSize = true;
            this.btnSuaDK.Location = new System.Drawing.Point(640, 138);
            this.btnSuaDK.Name = "btnSuaDK";
            this.btnSuaDK.Size = new System.Drawing.Size(64, 35);
            this.btnSuaDK.TabIndex = 57;
            this.btnSuaDK.Text = "Sửa";
            this.btnSuaDK.UseVisualStyleBackColor = true;
            this.btnSuaDK.Click += new System.EventHandler(this.btnSuaDK_Click);
            // 
            // btnThemDK
            // 
            this.btnThemDK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemDK.AutoSize = true;
            this.btnThemDK.Location = new System.Drawing.Point(570, 138);
            this.btnThemDK.Name = "btnThemDK";
            this.btnThemDK.Size = new System.Drawing.Size(64, 35);
            this.btnThemDK.TabIndex = 56;
            this.btnThemDK.Text = "Thêm";
            this.btnThemDK.UseVisualStyleBackColor = true;
            this.btnThemDK.Click += new System.EventHandler(this.btnThemDK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Trạng thái";
            // 
            // txtMaDK
            // 
            this.txtMaDK.Location = new System.Drawing.Point(154, 70);
            this.txtMaDK.Name = "txtMaDK";
            this.txtMaDK.Size = new System.Drawing.Size(219, 20);
            this.txtMaDK.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ngày lắp đặt";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "Khách hàng sở hữu";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Mã điện kế";
            // 
            // frmDienKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpTimKiemDK);
            this.Controls.Add(this.cboTrangThaiDK);
            this.Controls.Add(this.dtpNgayLapDatDK);
            this.Controls.Add(this.cboKhachHangDK);
            this.Controls.Add(this.dgvDienKe);
            this.Controls.Add(this.btnXoaDK);
            this.Controls.Add(this.btnSuaDK);
            this.Controls.Add(this.btnThemDK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaDK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Name = "frmDienKe";
            this.Text = "frmDienKe";
            this.Load += new System.EventHandler(this.frmDienKe_Load);
            this.grpTimKiemDK.ResumeLayout(false);
            this.grpTimKiemDK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpTimKiemDK;
        private System.Windows.Forms.RadioButton radDK_TheoTenKH;
        private System.Windows.Forms.RadioButton radDienKe_TheoMa;
        private System.Windows.Forms.Button btnTimKiemDK;
        private System.Windows.Forms.Button btnTaiLaiDK;
        private System.Windows.Forms.TextBox txtTimKiemDK;
        private System.Windows.Forms.ComboBox cboTrangThaiDK;
        private System.Windows.Forms.DateTimePicker dtpNgayLapDatDK;
        private System.Windows.Forms.ComboBox cboKhachHangDK;
        private System.Windows.Forms.DataGridView dgvDienKe;
        private System.Windows.Forms.Button btnXoaDK;
        private System.Windows.Forms.Button btnSuaDK;
        private System.Windows.Forms.Button btnThemDK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaDK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDienKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}