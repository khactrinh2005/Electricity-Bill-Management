namespace DATH_DH52302115
{
    partial class frmSuDungDien
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
            this.grpTimKiemSD = new System.Windows.Forms.GroupBox();
            this.radSD_TheoKH = new System.Windows.Forms.RadioButton();
            this.radSD_TheoDK = new System.Windows.Forms.RadioButton();
            this.btnTimKiemSD = new System.Windows.Forms.Button();
            this.btnTaiLaiSD = new System.Windows.Forms.Button();
            this.txtTimKiemSD = new System.Windows.Forms.TextBox();
            this.dtpNgayGhiSD = new System.Windows.Forms.DateTimePicker();
            this.cboKySD = new System.Windows.Forms.ComboBox();
            this.dgvSuDung = new System.Windows.Forms.DataGridView();
            this.MaSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KySuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaSD = new System.Windows.Forms.Button();
            this.btnSuaSD = new System.Windows.Forms.Button();
            this.btnThemSD = new System.Windows.Forms.Button();
            this.txtMaSuDung = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhanVienSD = new System.Windows.Forms.TextBox();
            this.pnlNhapLieu = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuuDK = new System.Windows.Forms.Button();
            this.dgvNhapLieu = new System.Windows.Forms.DataGridView();
            this.colChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMaDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChiSoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChiSoMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoMoiSD = new System.Windows.Forms.TextBox();
            this.lblChiSoMoi = new System.Windows.Forms.Label();
            this.grpTimKiemSD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuDung)).BeginInit();
            this.pnlNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTimKiemSD
            // 
            this.grpTimKiemSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiemSD.Controls.Add(this.radSD_TheoKH);
            this.grpTimKiemSD.Controls.Add(this.radSD_TheoDK);
            this.grpTimKiemSD.Controls.Add(this.btnTimKiemSD);
            this.grpTimKiemSD.Controls.Add(this.btnTaiLaiSD);
            this.grpTimKiemSD.Controls.Add(this.txtTimKiemSD);
            this.grpTimKiemSD.Location = new System.Drawing.Point(527, 39);
            this.grpTimKiemSD.Name = "grpTimKiemSD";
            this.grpTimKiemSD.Size = new System.Drawing.Size(267, 81);
            this.grpTimKiemSD.TabIndex = 77;
            this.grpTimKiemSD.TabStop = false;
            this.grpTimKiemSD.Text = "Tìm kiếm";
            // 
            // radSD_TheoKH
            // 
            this.radSD_TheoKH.AutoSize = true;
            this.radSD_TheoKH.Location = new System.Drawing.Point(150, 51);
            this.radSD_TheoKH.Name = "radSD_TheoKH";
            this.radSD_TheoKH.Size = new System.Drawing.Size(111, 17);
            this.radSD_TheoKH.TabIndex = 36;
            this.radSD_TheoKH.Text = "Theo Khách hàng";
            this.radSD_TheoKH.UseVisualStyleBackColor = true;
            // 
            // radSD_TheoDK
            // 
            this.radSD_TheoDK.AutoSize = true;
            this.radSD_TheoDK.Checked = true;
            this.radSD_TheoDK.Location = new System.Drawing.Point(57, 51);
            this.radSD_TheoDK.Name = "radSD_TheoDK";
            this.radSD_TheoDK.Size = new System.Drawing.Size(90, 17);
            this.radSD_TheoDK.TabIndex = 35;
            this.radSD_TheoDK.TabStop = true;
            this.radSD_TheoDK.Text = "Theo Điện kế";
            this.radSD_TheoDK.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemSD
            // 
            this.btnTimKiemSD.AutoSize = true;
            this.btnTimKiemSD.Location = new System.Drawing.Point(6, 23);
            this.btnTimKiemSD.Name = "btnTimKiemSD";
            this.btnTimKiemSD.Size = new System.Drawing.Size(45, 23);
            this.btnTimKiemSD.TabIndex = 33;
            this.btnTimKiemSD.Text = "Tìm";
            this.btnTimKiemSD.UseVisualStyleBackColor = true;
            this.btnTimKiemSD.Click += new System.EventHandler(this.btnTimKiemSD_Click);
            // 
            // btnTaiLaiSD
            // 
            this.btnTaiLaiSD.AutoSize = true;
            this.btnTaiLaiSD.Location = new System.Drawing.Point(6, 48);
            this.btnTaiLaiSD.Name = "btnTaiLaiSD";
            this.btnTaiLaiSD.Size = new System.Drawing.Size(45, 23);
            this.btnTaiLaiSD.TabIndex = 34;
            this.btnTaiLaiSD.Text = "Tải lại";
            this.btnTaiLaiSD.UseVisualStyleBackColor = true;
            this.btnTaiLaiSD.Click += new System.EventHandler(this.btnTaiLaiSD_Click);
            // 
            // txtTimKiemSD
            // 
            this.txtTimKiemSD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemSD.Location = new System.Drawing.Point(67, 25);
            this.txtTimKiemSD.Name = "txtTimKiemSD";
            this.txtTimKiemSD.Size = new System.Drawing.Size(194, 20);
            this.txtTimKiemSD.TabIndex = 32;
            // 
            // dtpNgayGhiSD
            // 
            this.dtpNgayGhiSD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayGhiSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGhiSD.Location = new System.Drawing.Point(159, 130);
            this.dtpNgayGhiSD.MaxDate = new System.DateTime(9998, 12, 30, 0, 0, 0, 0);
            this.dtpNgayGhiSD.MinDate = new System.DateTime(1753, 1, 2, 0, 0, 0, 0);
            this.dtpNgayGhiSD.Name = "dtpNgayGhiSD";
            this.dtpNgayGhiSD.Size = new System.Drawing.Size(167, 20);
            this.dtpNgayGhiSD.TabIndex = 75;
            this.dtpNgayGhiSD.Value = new System.DateTime(2025, 11, 17, 0, 0, 0, 0);
            // 
            // cboKySD
            // 
            this.cboKySD.FormattingEnabled = true;
            this.cboKySD.Location = new System.Drawing.Point(159, 77);
            this.cboKySD.Name = "cboKySD";
            this.cboKySD.Size = new System.Drawing.Size(167, 21);
            this.cboKySD.TabIndex = 74;
            this.cboKySD.SelectedIndexChanged += new System.EventHandler(this.cboKySD_SelectedIndexChanged);
            // 
            // dgvSuDung
            // 
            this.dgvSuDung.AllowUserToAddRows = false;
            this.dgvSuDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSD,
            this.DienKe,
            this.KySuDung,
            this.NhanVien,
            this.NgayGhi,
            this.SoDien});
            this.dgvSuDung.Location = new System.Drawing.Point(3, 188);
            this.dgvSuDung.Name = "dgvSuDung";
            this.dgvSuDung.ReadOnly = true;
            this.dgvSuDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuDung.Size = new System.Drawing.Size(794, 259);
            this.dgvSuDung.TabIndex = 73;
            this.dgvSuDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuDung_CellClick);
            this.dgvSuDung.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSuDung_CellFormatting);
            // 
            // MaSD
            // 
            this.MaSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaSD.DataPropertyName = "MaSD";
            this.MaSD.HeaderText = "Mã sử dụng";
            this.MaSD.Name = "MaSD";
            this.MaSD.ReadOnly = true;
            this.MaSD.Width = 88;
            // 
            // DienKe
            // 
            this.DienKe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DienKe.DataPropertyName = "DienKe";
            this.DienKe.HeaderText = "Điện kế";
            this.DienKe.MinimumWidth = 150;
            this.DienKe.Name = "DienKe";
            this.DienKe.ReadOnly = true;
            // 
            // KySuDung
            // 
            this.KySuDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KySuDung.DataPropertyName = "KySuDung";
            this.KySuDung.HeaderText = "Kỳ sử dụng";
            this.KySuDung.Name = "KySuDung";
            this.KySuDung.ReadOnly = true;
            this.KySuDung.Width = 85;
            // 
            // NhanVien
            // 
            this.NhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NhanVien.DataPropertyName = "NhanVien";
            this.NhanVien.HeaderText = "Nhân viên";
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.ReadOnly = true;
            // 
            // NgayGhi
            // 
            this.NgayGhi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayGhi.DataPropertyName = "NgayGhi";
            this.NgayGhi.HeaderText = "Ngày ghi điện";
            this.NgayGhi.Name = "NgayGhi";
            this.NgayGhi.ReadOnly = true;
            // 
            // SoDien
            // 
            this.SoDien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDien.DataPropertyName = "SoDien";
            this.SoDien.FillWeight = 70F;
            this.SoDien.HeaderText = "Số điện";
            this.SoDien.Name = "SoDien";
            this.SoDien.ReadOnly = true;
            // 
            // btnXoaSD
            // 
            this.btnXoaSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaSD.AutoSize = true;
            this.btnXoaSD.Location = new System.Drawing.Point(393, 92);
            this.btnXoaSD.Name = "btnXoaSD";
            this.btnXoaSD.Size = new System.Drawing.Size(64, 35);
            this.btnXoaSD.TabIndex = 72;
            this.btnXoaSD.Text = "Xóa";
            this.btnXoaSD.UseVisualStyleBackColor = true;
            this.btnXoaSD.Click += new System.EventHandler(this.btnXoaSD_Click);
            // 
            // btnSuaSD
            // 
            this.btnSuaSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaSD.AutoSize = true;
            this.btnSuaSD.Location = new System.Drawing.Point(393, 133);
            this.btnSuaSD.Name = "btnSuaSD";
            this.btnSuaSD.Size = new System.Drawing.Size(64, 35);
            this.btnSuaSD.TabIndex = 71;
            this.btnSuaSD.Text = "Sửa";
            this.btnSuaSD.UseVisualStyleBackColor = true;
            this.btnSuaSD.Click += new System.EventHandler(this.btnSuaSD_Click);
            // 
            // btnThemSD
            // 
            this.btnThemSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemSD.AutoSize = true;
            this.btnThemSD.Location = new System.Drawing.Point(393, 51);
            this.btnThemSD.Name = "btnThemSD";
            this.btnThemSD.Size = new System.Drawing.Size(64, 35);
            this.btnThemSD.TabIndex = 70;
            this.btnThemSD.Text = "Thêm";
            this.btnThemSD.UseVisualStyleBackColor = true;
            this.btnThemSD.Click += new System.EventHandler(this.btnThemSD_Click);
            // 
            // txtMaSuDung
            // 
            this.txtMaSuDung.Enabled = false;
            this.txtMaSuDung.Location = new System.Drawing.Point(159, 51);
            this.txtMaSuDung.Name = "txtMaSuDung";
            this.txtMaSuDung.ReadOnly = true;
            this.txtMaSuDung.Size = new System.Drawing.Size(167, 20);
            this.txtMaSuDung.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Ngày ghi điện";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 66;
            this.label18.Text = "Kỳ sử dụng";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 65;
            this.label19.Text = "Mã sử dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Nhân viên ghi điện";
            // 
            // txtNhanVienSD
            // 
            this.txtNhanVienSD.Enabled = false;
            this.txtNhanVienSD.Location = new System.Drawing.Point(159, 104);
            this.txtNhanVienSD.Name = "txtNhanVienSD";
            this.txtNhanVienSD.ReadOnly = true;
            this.txtNhanVienSD.Size = new System.Drawing.Size(167, 20);
            this.txtNhanVienSD.TabIndex = 87;
            // 
            // pnlNhapLieu
            // 
            this.pnlNhapLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNhapLieu.Controls.Add(this.btnHuy);
            this.pnlNhapLieu.Controls.Add(this.btnLuuDK);
            this.pnlNhapLieu.Controls.Add(this.dgvNhapLieu);
            this.pnlNhapLieu.Location = new System.Drawing.Point(3, 185);
            this.pnlNhapLieu.Name = "pnlNhapLieu";
            this.pnlNhapLieu.Size = new System.Drawing.Size(794, 262);
            this.pnlNhapLieu.TabIndex = 88;
            this.pnlNhapLieu.Visible = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.AutoSize = true;
            this.btnHuy.Location = new System.Drawing.Point(727, 230);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(64, 29);
            this.btnHuy.TabIndex = 90;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuuDK
            // 
            this.btnLuuDK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuDK.AutoSize = true;
            this.btnLuuDK.Location = new System.Drawing.Point(656, 230);
            this.btnLuuDK.Name = "btnLuuDK";
            this.btnLuuDK.Size = new System.Drawing.Size(65, 29);
            this.btnLuuDK.TabIndex = 89;
            this.btnLuuDK.Text = "Lưu tất cả";
            this.btnLuuDK.UseVisualStyleBackColor = true;
            this.btnLuuDK.Click += new System.EventHandler(this.btnLuuDK_Click);
            // 
            // dgvNhapLieu
            // 
            this.dgvNhapLieu.AllowUserToAddRows = false;
            this.dgvNhapLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhapLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChon,
            this.colMaDK,
            this.colTenKH,
            this.colChiSoCu,
            this.colChiSoMoi});
            this.dgvNhapLieu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNhapLieu.Location = new System.Drawing.Point(3, 3);
            this.dgvNhapLieu.Name = "dgvNhapLieu";
            this.dgvNhapLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapLieu.Size = new System.Drawing.Size(788, 221);
            this.dgvNhapLieu.TabIndex = 74;
            this.dgvNhapLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapLieu_CellContentClick);
            this.dgvNhapLieu.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapLieu_CellValueChanged);
            // 
            // colChon
            // 
            this.colChon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colChon.FillWeight = 30F;
            this.colChon.HeaderText = "Chọn";
            this.colChon.Name = "colChon";
            this.colChon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colChon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colMaDK
            // 
            this.colMaDK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaDK.FillWeight = 70F;
            this.colMaDK.HeaderText = "Mã điện kế";
            this.colMaDK.MinimumWidth = 150;
            this.colMaDK.Name = "colMaDK";
            this.colMaDK.ReadOnly = true;
            // 
            // colTenKH
            // 
            this.colTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenKH.HeaderText = "Tên khách hàng";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.ReadOnly = true;
            // 
            // colChiSoCu
            // 
            this.colChiSoCu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colChiSoCu.FillWeight = 50F;
            this.colChiSoCu.HeaderText = "Chỉ số cũ";
            this.colChiSoCu.Name = "colChiSoCu";
            this.colChiSoCu.ReadOnly = true;
            // 
            // colChiSoMoi
            // 
            this.colChiSoMoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colChiSoMoi.FillWeight = 50F;
            this.colChiSoMoi.HeaderText = "Chỉ số mới";
            this.colChiSoMoi.Name = "colChiSoMoi";
            // 
            // txtSoMoiSD
            // 
            this.txtSoMoiSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoMoiSD.Location = new System.Drawing.Point(463, 148);
            this.txtSoMoiSD.Name = "txtSoMoiSD";
            this.txtSoMoiSD.Size = new System.Drawing.Size(126, 20);
            this.txtSoMoiSD.TabIndex = 89;
            // 
            // lblChiSoMoi
            // 
            this.lblChiSoMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChiSoMoi.AutoSize = true;
            this.lblChiSoMoi.Location = new System.Drawing.Point(463, 132);
            this.lblChiSoMoi.Name = "lblChiSoMoi";
            this.lblChiSoMoi.Size = new System.Drawing.Size(55, 13);
            this.lblChiSoMoi.TabIndex = 90;
            this.lblChiSoMoi.Text = "Chỉ số mới";
            // 
            // frmSuDungDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChiSoMoi);
            this.Controls.Add(this.txtSoMoiSD);
            this.Controls.Add(this.txtNhanVienSD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpTimKiemSD);
            this.Controls.Add(this.dtpNgayGhiSD);
            this.Controls.Add(this.cboKySD);
            this.Controls.Add(this.btnXoaSD);
            this.Controls.Add(this.btnSuaSD);
            this.Controls.Add(this.btnThemSD);
            this.Controls.Add(this.txtMaSuDung);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pnlNhapLieu);
            this.Controls.Add(this.dgvSuDung);
            this.Name = "frmSuDungDien";
            this.Text = "frmSuDungDien";
            this.Load += new System.EventHandler(this.frmSuDungDien_Load);
            this.grpTimKiemSD.ResumeLayout(false);
            this.grpTimKiemSD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuDung)).EndInit();
            this.pnlNhapLieu.ResumeLayout(false);
            this.pnlNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTimKiemSD;
        private System.Windows.Forms.RadioButton radSD_TheoKH;
        private System.Windows.Forms.RadioButton radSD_TheoDK;
        private System.Windows.Forms.Button btnTimKiemSD;
        private System.Windows.Forms.Button btnTaiLaiSD;
        private System.Windows.Forms.TextBox txtTimKiemSD;
        private System.Windows.Forms.DateTimePicker dtpNgayGhiSD;
        private System.Windows.Forms.ComboBox cboKySD;
        private System.Windows.Forms.DataGridView dgvSuDung;
        private System.Windows.Forms.Button btnXoaSD;
        private System.Windows.Forms.Button btnSuaSD;
        private System.Windows.Forms.Button btnThemSD;
        private System.Windows.Forms.TextBox txtMaSuDung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn KySuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDien;
        private System.Windows.Forms.TextBox txtNhanVienSD;
        private System.Windows.Forms.Panel pnlNhapLieu;
        private System.Windows.Forms.DataGridView dgvNhapLieu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuDK;
        private System.Windows.Forms.TextBox txtSoMoiSD;
        private System.Windows.Forms.Label lblChiSoMoi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiSoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiSoMoi;
    }
}