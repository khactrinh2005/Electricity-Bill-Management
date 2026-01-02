namespace DATH_DH52302115
{
    partial class frmKhachHang
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
            this.btnTaiLaiKH = new System.Windows.Forms.Button();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.chkTrangThaiKH = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDTKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaiLaiKH
            // 
            this.btnTaiLaiKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaiLaiKH.Location = new System.Drawing.Point(441, 211);
            this.btnTaiLaiKH.Name = "btnTaiLaiKH";
            this.btnTaiLaiKH.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLaiKH.TabIndex = 72;
            this.btnTaiLaiKH.Text = "Tải lại";
            this.btnTaiLaiKH.UseVisualStyleBackColor = true;
            this.btnTaiLaiKH.Click += new System.EventHandler(this.btnTaiLaiKH_Click);
            // 
            // btnTimKH
            // 
            this.btnTimKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKH.Location = new System.Drawing.Point(522, 211);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(75, 23);
            this.btnTimKH.TabIndex = 71;
            this.btnTimKH.Text = "Tìm";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // txtTimKH
            // 
            this.txtTimKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKH.Location = new System.Drawing.Point(603, 213);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(165, 20);
            this.txtTimKH.TabIndex = 70;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTen,
            this.DiaChi,
            this.SoDT,
            this.TrangThai});
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 239);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(794, 211);
            this.dgvKhachHang.TabIndex = 69;
            this.dgvKhachHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_RowEnter);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 200F;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.FillWeight = 150F;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.FillWeight = 150F;
            this.SoDT.HeaderText = "Số ĐT";
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Hoạt động";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaKH.Location = new System.Drawing.Point(647, 128);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(85, 32);
            this.btnXoaKH.TabIndex = 68;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaKH.Location = new System.Drawing.Point(647, 90);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(85, 32);
            this.btnSuaKH.TabIndex = 67;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKH.Location = new System.Drawing.Point(647, 52);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(85, 32);
            this.btnThemKH.TabIndex = 66;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // chkTrangThaiKH
            // 
            this.chkTrangThaiKH.AutoSize = true;
            this.chkTrangThaiKH.Checked = true;
            this.chkTrangThaiKH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThaiKH.Location = new System.Drawing.Point(181, 168);
            this.chkTrangThaiKH.Name = "chkTrangThaiKH";
            this.chkTrangThaiKH.Size = new System.Drawing.Size(104, 17);
            this.chkTrangThaiKH.TabIndex = 65;
            this.chkTrangThaiKH.Text = "Đang hoạt động";
            this.chkTrangThaiKH.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Trạng thái";
            // 
            // txtSoDTKH
            // 
            this.txtSoDTKH.Location = new System.Drawing.Point(181, 135);
            this.txtSoDTKH.Name = "txtSoDTKH";
            this.txtSoDTKH.Size = new System.Drawing.Size(219, 20);
            this.txtSoDTKH.TabIndex = 63;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(181, 109);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(219, 20);
            this.txtDiaChiKH.TabIndex = 62;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(181, 81);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(219, 20);
            this.txtHoTenKH.TabIndex = 61;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(181, 52);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(219, 20);
            this.txtMaKH.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mã khách hàng";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTaiLaiKH);
            this.Controls.Add(this.btnTimKH);
            this.Controls.Add(this.txtTimKH);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnSuaKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.chkTrangThaiKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoDTKH);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.txtHoTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTaiLaiKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.CheckBox chkTrangThaiKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoDTKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
    }
}