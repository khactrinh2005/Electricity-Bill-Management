namespace DATH_DH52302115
{
    partial class frmNhanVien
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
            this.label12 = new System.Windows.Forms.Label();
            this.cboQuyenHanNV = new System.Windows.Forms.ComboBox();
            this.btnTaiLaiNV = new System.Windows.Forms.Button();
            this.btnTimKiemNV = new System.Windows.Forms.Button();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboChucVuNV = new System.Windows.Forms.ComboBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.chkTrangThaiNV = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Quyền hạn";
            // 
            // cboQuyenHanNV
            // 
            this.cboQuyenHanNV.FormattingEnabled = true;
            this.cboQuyenHanNV.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.cboQuyenHanNV.Location = new System.Drawing.Point(178, 133);
            this.cboQuyenHanNV.Name = "cboQuyenHanNV";
            this.cboQuyenHanNV.Size = new System.Drawing.Size(219, 21);
            this.cboQuyenHanNV.TabIndex = 69;
            // 
            // btnTaiLaiNV
            // 
            this.btnTaiLaiNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaiLaiNV.Location = new System.Drawing.Point(441, 208);
            this.btnTaiLaiNV.Name = "btnTaiLaiNV";
            this.btnTaiLaiNV.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLaiNV.TabIndex = 68;
            this.btnTaiLaiNV.Text = "Tải lại";
            this.btnTaiLaiNV.UseVisualStyleBackColor = true;
            this.btnTaiLaiNV.Click += new System.EventHandler(this.btnTaiLaiNV_Click);
            // 
            // btnTimKiemNV
            // 
            this.btnTimKiemNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemNV.Location = new System.Drawing.Point(522, 208);
            this.btnTimKiemNV.Name = "btnTimKiemNV";
            this.btnTimKiemNV.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemNV.TabIndex = 67;
            this.btnTimKiemNV.Text = "Tìm";
            this.btnTimKiemNV.UseVisualStyleBackColor = true;
            this.btnTimKiemNV.Click += new System.EventHandler(this.btnTimKiemNV_Click);
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemNV.Location = new System.Drawing.Point(603, 211);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(188, 20);
            this.txtTimKiemNV.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Chức vụ";
            // 
            // cboChucVuNV
            // 
            this.cboChucVuNV.FormattingEnabled = true;
            this.cboChucVuNV.Items.AddRange(new object[] {
            "Người ghi điện",
            "Thu ngân"});
            this.cboChucVuNV.Location = new System.Drawing.Point(178, 106);
            this.cboChucVuNV.Name = "cboChucVuNV";
            this.cboChucVuNV.Size = new System.Drawing.Size(219, 21);
            this.cboChucVuNV.TabIndex = 64;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.ChucVu,
            this.QuyenHan,
            this.TrangThai});
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 237);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(794, 210);
            this.dgvNhanVien.TabIndex = 63;
            this.dgvNhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_RowEnter);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 200F;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.FillWeight = 150F;
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // QuyenHan
            // 
            this.QuyenHan.DataPropertyName = "QuyenHan";
            this.QuyenHan.FillWeight = 150F;
            this.QuyenHan.HeaderText = "Quyền Hạn";
            this.QuyenHan.Name = "QuyenHan";
            this.QuyenHan.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.FillWeight = 50F;
            this.TrangThai.HeaderText = "Đang làm việc";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNV.Location = new System.Drawing.Point(603, 130);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(85, 32);
            this.btnXoaNV.TabIndex = 62;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaNV.Location = new System.Drawing.Point(603, 92);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(85, 32);
            this.btnSuaNV.TabIndex = 61;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNV.Location = new System.Drawing.Point(603, 54);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(85, 32);
            this.btnThemNV.TabIndex = 60;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // chkTrangThaiNV
            // 
            this.chkTrangThaiNV.AutoSize = true;
            this.chkTrangThaiNV.Checked = true;
            this.chkTrangThaiNV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThaiNV.Location = new System.Drawing.Point(178, 160);
            this.chkTrangThaiNV.Name = "chkTrangThaiNV";
            this.chkTrangThaiNV.Size = new System.Drawing.Size(94, 17);
            this.chkTrangThaiNV.TabIndex = 59;
            this.chkTrangThaiNV.Text = "Đang làm việc";
            this.chkTrangThaiNV.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Trạng thái";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(178, 80);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(219, 20);
            this.txtHoTenNV.TabIndex = 57;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(178, 54);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(219, 20);
            this.txtMaNV.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Tên nhân viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Mã nhân viên";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboQuyenHanNV);
            this.Controls.Add(this.btnTaiLaiNV);
            this.Controls.Add(this.btnTimKiemNV);
            this.Controls.Add(this.txtTimKiemNV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboChucVuNV);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.chkTrangThaiNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboQuyenHanNV;
        private System.Windows.Forms.Button btnTaiLaiNV;
        private System.Windows.Forms.Button btnTimKiemNV;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboChucVuNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.CheckBox chkTrangThaiNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyenHan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
    }
}