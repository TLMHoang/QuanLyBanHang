namespace GUI
{
    partial class frmQuanLy
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
            this.components = new System.ComponentModel.Container();
            this.bsHang = new System.Windows.Forms.BindingSource(this.components);
            this.tcQuanLy = new System.Windows.Forms.TabControl();
            this.tpDanhSachHang = new System.Windows.Forms.TabPage();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpTaiKhoanBan = new System.Windows.Forms.TabPage();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.IDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.tpKhachHang = new System.Windows.Forms.TabPage();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.IDKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsKhachHang = new System.Windows.Forms.BindingSource(this.components);
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.IDTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTaiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.txtFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsHang)).BeginInit();
            this.tcQuanLy.SuspendLayout();
            this.tpDanhSachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.tpTaiKhoanBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNhanVien)).BeginInit();
            this.tpKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKhachHang)).BeginInit();
            this.tpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // bsHang
            // 
            this.bsHang.DataSource = typeof(DTO.Hang);
            // 
            // tcQuanLy
            // 
            this.tcQuanLy.Controls.Add(this.tpDanhSachHang);
            this.tcQuanLy.Controls.Add(this.tpTaiKhoanBan);
            this.tcQuanLy.Controls.Add(this.tpKhachHang);
            this.tcQuanLy.Controls.Add(this.tpAccount);
            this.tcQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQuanLy.Location = new System.Drawing.Point(0, 0);
            this.tcQuanLy.Margin = new System.Windows.Forms.Padding(4);
            this.tcQuanLy.Name = "tcQuanLy";
            this.tcQuanLy.SelectedIndex = 0;
            this.tcQuanLy.Size = new System.Drawing.Size(697, 571);
            this.tcQuanLy.TabIndex = 0;
            // 
            // tpDanhSachHang
            // 
            this.tpDanhSachHang.Controls.Add(this.dgvHang);
            this.tpDanhSachHang.Location = new System.Drawing.Point(4, 25);
            this.tpDanhSachHang.Margin = new System.Windows.Forms.Padding(4);
            this.tpDanhSachHang.Name = "tpDanhSachHang";
            this.tpDanhSachHang.Padding = new System.Windows.Forms.Padding(4);
            this.tpDanhSachHang.Size = new System.Drawing.Size(689, 542);
            this.tpDanhSachHang.TabIndex = 0;
            this.tpDanhSachHang.Text = "Danh sách hàng";
            this.tpDanhSachHang.UseVisualStyleBackColor = true;
            // 
            // dgvHang
            // 
            this.dgvHang.AutoGenerateColumns = false;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenHang,
            this.GiaBan,
            this.GiaNhap,
            this.SoLuong});
            this.dgvHang.DataSource = this.bsHang;
            this.dgvHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHang.Location = new System.Drawing.Point(4, 4);
            this.dgvHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.Size = new System.Drawing.Size(681, 517);
            this.dgvHang.TabIndex = 0;
            this.dgvHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHang_CellEndEdit);
            this.dgvHang.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvHang_DataError);
            this.dgvHang.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvHang_UserAddedRow);
            this.dgvHang.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvHang_UserDeletingRow);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 270;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 120;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Width = 120;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 90;
            // 
            // tpTaiKhoanBan
            // 
            this.tpTaiKhoanBan.Controls.Add(this.dgvNhanVien);
            this.tpTaiKhoanBan.Location = new System.Drawing.Point(4, 25);
            this.tpTaiKhoanBan.Margin = new System.Windows.Forms.Padding(4);
            this.tpTaiKhoanBan.Name = "tpTaiKhoanBan";
            this.tpTaiKhoanBan.Padding = new System.Windows.Forms.Padding(4);
            this.tpTaiKhoanBan.Size = new System.Drawing.Size(689, 542);
            this.tpTaiKhoanBan.TabIndex = 1;
            this.tpTaiKhoanBan.Text = "Tài Khoản Bán";
            this.tpTaiKhoanBan.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDNV,
            this.Ten});
            this.dgvNhanVien.DataSource = this.bsNhanVien;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNhanVien.Location = new System.Drawing.Point(4, 4);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(681, 520);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellEndEdit);
            this.dgvNhanVien.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvNhanVien_DataError);
            this.dgvNhanVien.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvNhanVien_UserAddedRow);
            this.dgvNhanVien.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvNhanVien_UserDeletingRow);
            // 
            // IDNV
            // 
            this.IDNV.DataPropertyName = "ID";
            this.IDNV.HeaderText = "Mã";
            this.IDNV.Name = "IDNV";
            this.IDNV.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.Width = 300;
            // 
            // bsNhanVien
            // 
            this.bsNhanVien.DataSource = typeof(DTO.NhanVien);
            // 
            // tpKhachHang
            // 
            this.tpKhachHang.Controls.Add(this.dgvKhachHang);
            this.tpKhachHang.Location = new System.Drawing.Point(4, 25);
            this.tpKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.tpKhachHang.Name = "tpKhachHang";
            this.tpKhachHang.Size = new System.Drawing.Size(689, 542);
            this.tpKhachHang.TabIndex = 2;
            this.tpKhachHang.Text = "Khách Hàng";
            this.tpKhachHang.UseVisualStyleBackColor = true;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoGenerateColumns = false;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKH,
            this.TenKH,
            this.SDT,
            this.DiaChi});
            this.dgvKhachHang.DataSource = this.bsKhachHang;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(689, 528);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellEndEdit);
            this.dgvKhachHang.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvKhachHang_DataError);
            this.dgvKhachHang.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvKhachHang_UserAddedRow);
            this.dgvKhachHang.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvKhachHang_UserDeletingRow);
            // 
            // IDKH
            // 
            this.IDKH.DataPropertyName = "ID";
            this.IDKH.HeaderText = "Mã";
            this.IDKH.Name = "IDKH";
            this.IDKH.ReadOnly = true;
            this.IDKH.Width = 40;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 200;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            this.SDT.Width = 140;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 260;
            // 
            // bsKhachHang
            // 
            this.bsKhachHang.DataSource = typeof(DTO.KhachHang);
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.dgvTaiKhoan);
            this.tpAccount.Location = new System.Drawing.Point(4, 25);
            this.tpAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Size = new System.Drawing.Size(689, 542);
            this.tpAccount.TabIndex = 3;
            this.tpAccount.Text = "Tài Khoản Đăng Nhập";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoGenerateColumns = false;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTK,
            this.TKhoan,
            this.Loai});
            this.dgvTaiKhoan.DataSource = this.bsTaiKhoan;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(689, 533);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellEndEdit);
            this.dgvTaiKhoan.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTaiKhoan_DataError);
            this.dgvTaiKhoan.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvTaiKhoan_UserAddedRow);
            this.dgvTaiKhoan.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTaiKhoan_UserDeletingRow);
            // 
            // IDTK
            // 
            this.IDTK.DataPropertyName = "ID";
            this.IDTK.HeaderText = "Mã";
            this.IDTK.Name = "IDTK";
            this.IDTK.ReadOnly = true;
            this.IDTK.Width = 50;
            // 
            // TKhoan
            // 
            this.TKhoan.DataPropertyName = "TKhoan";
            this.TKhoan.HeaderText = "Tên Tài Khoản";
            this.TKhoan.Name = "TKhoan";
            this.TKhoan.Width = 430;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loại";
            this.Loai.Name = "Loai";
            this.Loai.Width = 150;
            // 
            // bsTaiKhoan
            // 
            this.bsTaiKhoan.DataSource = typeof(DTO.TaiKhoan);
            // 
            // txtFind
            // 
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFind.Location = new System.Drawing.Point(0, 545);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(697, 26);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.Enter += new System.EventHandler(this.txtFind_Enter);
            this.txtFind.Leave += new System.EventHandler(this.txtFind_Leave);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 571);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.tcQuanLy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLy";
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsHang)).EndInit();
            this.tcQuanLy.ResumeLayout(false);
            this.tpDanhSachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.tpTaiKhoanBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNhanVien)).EndInit();
            this.tpKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKhachHang)).EndInit();
            this.tpAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsHang;
        private System.Windows.Forms.TabControl tcQuanLy;
        private System.Windows.Forms.TabPage tpDanhSachHang;
        private System.Windows.Forms.TabPage tpTaiKhoanBan;
        private System.Windows.Forms.TabPage tpKhachHang;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.BindingSource bsNhanVien;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.BindingSource bsKhachHang;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.BindingSource bsTaiKhoan;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
    }
}