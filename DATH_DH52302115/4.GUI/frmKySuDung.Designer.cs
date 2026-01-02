namespace DATH_DH52302115
{
    partial class frmKySuDung
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
            this.btnTaiLaiKy = new System.Windows.Forms.Button();
            this.btnTimKiemKy = new System.Windows.Forms.Button();
            this.txtTimKiemKy = new System.Windows.Forms.TextBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnXoaKy = new System.Windows.Forms.Button();
            this.btnSuaKy = new System.Windows.Forms.Button();
            this.btnThemKy = new System.Windows.Forms.Button();
            this.txtTenKy = new System.Windows.Forms.TextBox();
            this.txtMaKy = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvKySuDungDien = new System.Windows.Forms.DataGridView();
            this.MaKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDauGhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThucGhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKySuDungDien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaiLaiKy
            // 
            this.btnTaiLaiKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaiLaiKy.Location = new System.Drawing.Point(441, 208);
            this.btnTaiLaiKy.Name = "btnTaiLaiKy";
            this.btnTaiLaiKy.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLaiKy.TabIndex = 66;
            this.btnTaiLaiKy.Text = "Tải lại";
            this.btnTaiLaiKy.UseVisualStyleBackColor = true;
            this.btnTaiLaiKy.Click += new System.EventHandler(this.btnTaiLaiKy_Click);
            // 
            // btnTimKiemKy
            // 
            this.btnTimKiemKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemKy.Location = new System.Drawing.Point(522, 208);
            this.btnTimKiemKy.Name = "btnTimKiemKy";
            this.btnTimKiemKy.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemKy.TabIndex = 65;
            this.btnTimKiemKy.Text = "Tìm";
            this.btnTimKiemKy.UseVisualStyleBackColor = true;
            this.btnTimKiemKy.Click += new System.EventHandler(this.btnTimKiemKy_Click);
            // 
            // txtTimKiemKy
            // 
            this.txtTimKiemKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemKy.Location = new System.Drawing.Point(603, 211);
            this.txtTimKiemKy.Name = "txtTimKiemKy";
            this.txtTimKiemKy.Size = new System.Drawing.Size(188, 20);
            this.txtTimKiemKy.TabIndex = 64;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(172, 162);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(219, 20);
            this.dtpNgayKetThuc.TabIndex = 63;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(172, 127);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(219, 20);
            this.dtpNgayBatDau.TabIndex = 62;
            // 
            // btnXoaKy
            // 
            this.btnXoaKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaKy.Location = new System.Drawing.Point(657, 133);
            this.btnXoaKy.Name = "btnXoaKy";
            this.btnXoaKy.Size = new System.Drawing.Size(85, 32);
            this.btnXoaKy.TabIndex = 60;
            this.btnXoaKy.Text = "Xóa";
            this.btnXoaKy.UseVisualStyleBackColor = true;
            this.btnXoaKy.Click += new System.EventHandler(this.btnXoaKy_Click);
            // 
            // btnSuaKy
            // 
            this.btnSuaKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaKy.Location = new System.Drawing.Point(657, 95);
            this.btnSuaKy.Name = "btnSuaKy";
            this.btnSuaKy.Size = new System.Drawing.Size(85, 32);
            this.btnSuaKy.TabIndex = 59;
            this.btnSuaKy.Text = "Sửa";
            this.btnSuaKy.UseVisualStyleBackColor = true;
            this.btnSuaKy.Click += new System.EventHandler(this.btnSuaKy_Click);
            // 
            // btnThemKy
            // 
            this.btnThemKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKy.AutoSize = true;
            this.btnThemKy.Location = new System.Drawing.Point(657, 57);
            this.btnThemKy.Name = "btnThemKy";
            this.btnThemKy.Size = new System.Drawing.Size(85, 32);
            this.btnThemKy.TabIndex = 58;
            this.btnThemKy.Text = "Thêm";
            this.btnThemKy.UseVisualStyleBackColor = true;
            this.btnThemKy.Click += new System.EventHandler(this.btnThemKy_Click);
            // 
            // txtTenKy
            // 
            this.txtTenKy.Location = new System.Drawing.Point(172, 92);
            this.txtTenKy.Name = "txtTenKy";
            this.txtTenKy.Size = new System.Drawing.Size(219, 20);
            this.txtTenKy.TabIndex = 57;
            // 
            // txtMaKy
            // 
            this.txtMaKy.Location = new System.Drawing.Point(172, 57);
            this.txtMaKy.Name = "txtMaKy";
            this.txtMaKy.Size = new System.Drawing.Size(219, 20);
            this.txtMaKy.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Ngày kết thúc ghi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(52, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Ngày bắt đầu ghi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Tên kỳ sử dụng";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "Mã kỳ sử dụng";
            // 
            // dgvKySuDungDien
            // 
            this.dgvKySuDungDien.AllowUserToAddRows = false;
            this.dgvKySuDungDien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKySuDungDien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKySuDungDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKySuDungDien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKy,
            this.TenKy,
            this.NgayBatDauGhi,
            this.NgayKetThucGhi});
            this.dgvKySuDungDien.Location = new System.Drawing.Point(3, 237);
            this.dgvKySuDungDien.Name = "dgvKySuDungDien";
            this.dgvKySuDungDien.ReadOnly = true;
            this.dgvKySuDungDien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKySuDungDien.Size = new System.Drawing.Size(794, 211);
            this.dgvKySuDungDien.TabIndex = 61;
            this.dgvKySuDungDien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKySuDungDien_CellClick);
            // 
            // MaKy
            // 
            this.MaKy.DataPropertyName = "MaKy";
            this.MaKy.HeaderText = "Mã kỳ";
            this.MaKy.Name = "MaKy";
            this.MaKy.ReadOnly = true;
            // 
            // TenKy
            // 
            this.TenKy.DataPropertyName = "TenKy";
            this.TenKy.FillWeight = 200F;
            this.TenKy.HeaderText = "Tên kỳ";
            this.TenKy.Name = "TenKy";
            this.TenKy.ReadOnly = true;
            // 
            // NgayBatDauGhi
            // 
            this.NgayBatDauGhi.DataPropertyName = "NgayBatDauGhi";
            this.NgayBatDauGhi.FillWeight = 150F;
            this.NgayBatDauGhi.HeaderText = "Ngày bắt đầu";
            this.NgayBatDauGhi.Name = "NgayBatDauGhi";
            this.NgayBatDauGhi.ReadOnly = true;
            this.NgayBatDauGhi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NgayKetThucGhi
            // 
            this.NgayKetThucGhi.DataPropertyName = "NgayKetThucGhi";
            this.NgayKetThucGhi.FillWeight = 150F;
            this.NgayKetThucGhi.HeaderText = "Ngày kết thúc";
            this.NgayKetThucGhi.Name = "NgayKetThucGhi";
            this.NgayKetThucGhi.ReadOnly = true;
            // 
            // frmKySuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTaiLaiKy);
            this.Controls.Add(this.btnTimKiemKy);
            this.Controls.Add(this.txtTimKiemKy);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.btnXoaKy);
            this.Controls.Add(this.btnSuaKy);
            this.Controls.Add(this.btnThemKy);
            this.Controls.Add(this.txtTenKy);
            this.Controls.Add(this.txtMaKy);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgvKySuDungDien);
            this.Name = "frmKySuDung";
            this.Text = "frmKySuDung";
            this.Load += new System.EventHandler(this.frmKySuDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKySuDungDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTaiLaiKy;
        private System.Windows.Forms.Button btnTimKiemKy;
        private System.Windows.Forms.TextBox txtTimKiemKy;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Button btnXoaKy;
        private System.Windows.Forms.Button btnSuaKy;
        private System.Windows.Forms.Button btnThemKy;
        private System.Windows.Forms.TextBox txtTenKy;
        private System.Windows.Forms.TextBox txtMaKy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvKySuDungDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDauGhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThucGhi;
    }
}