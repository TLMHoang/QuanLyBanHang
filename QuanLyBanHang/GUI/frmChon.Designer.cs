namespace GUI
{
    partial class frmChon
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grTimeline = new System.Windows.Forms.GroupBox();
            this.tlpChonThoiGian = new System.Windows.Forms.TableLayoutPanel();
            this.lblToTimeLbl = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblFromTimeLbl = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radThang = new System.Windows.Forms.RadioButton();
            this.radTuan = new System.Windows.Forms.RadioButton();
            this.radThoiGian = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHoanThanh = new System.Windows.Forms.TabPage();
            this.dgvHoanThanh = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsHoanThanh = new System.Windows.Forms.BindingSource(this.components);
            this.tabHoanDon = new System.Windows.Forms.TabPage();
            this.dgvHoanDon = new System.Windows.Forms.DataGridView();
            this.tabHuyDon = new System.Windows.Forms.TabPage();
            this.dgvHuyDon = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.grTimeline.SuspendLayout();
            this.tlpChonThoiGian.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabHoanThanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoanThanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHoanThanh)).BeginInit();
            this.tabHoanDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoanDon)).BeginInit();
            this.tabHuyDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuyDon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.grTimeline, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.64165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.003752F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.3546F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 533);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grTimeline
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grTimeline, 3);
            this.grTimeline.Controls.Add(this.tlpChonThoiGian);
            this.grTimeline.Controls.Add(this.radNam);
            this.grTimeline.Controls.Add(this.radThang);
            this.grTimeline.Controls.Add(this.radTuan);
            this.grTimeline.Controls.Add(this.radThoiGian);
            this.grTimeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTimeline.Location = new System.Drawing.Point(4, 5);
            this.grTimeline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grTimeline.Name = "grTimeline";
            this.grTimeline.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grTimeline.Size = new System.Drawing.Size(565, 131);
            this.grTimeline.TabIndex = 2;
            this.grTimeline.TabStop = false;
            this.grTimeline.Text = "Chọn thời gian";
            // 
            // tlpChonThoiGian
            // 
            this.tlpChonThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpChonThoiGian.ColumnCount = 4;
            this.tlpChonThoiGian.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpChonThoiGian.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpChonThoiGian.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpChonThoiGian.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpChonThoiGian.Controls.Add(this.lblToTimeLbl, 2, 0);
            this.tlpChonThoiGian.Controls.Add(this.dtpNgayKetThuc, 3, 0);
            this.tlpChonThoiGian.Controls.Add(this.lblFromTimeLbl, 0, 0);
            this.tlpChonThoiGian.Controls.Add(this.dtpNgayBD, 1, 0);
            this.tlpChonThoiGian.Location = new System.Drawing.Point(8, 78);
            this.tlpChonThoiGian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpChonThoiGian.Name = "tlpChonThoiGian";
            this.tlpChonThoiGian.RowCount = 1;
            this.tlpChonThoiGian.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChonThoiGian.Size = new System.Drawing.Size(547, 43);
            this.tlpChonThoiGian.TabIndex = 6;
            // 
            // lblToTimeLbl
            // 
            this.lblToTimeLbl.AutoSize = true;
            this.lblToTimeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToTimeLbl.Location = new System.Drawing.Point(271, 0);
            this.lblToTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToTimeLbl.Name = "lblToTimeLbl";
            this.lblToTimeLbl.Size = new System.Drawing.Size(81, 43);
            this.lblToTimeLbl.TabIndex = 8;
            this.lblToTimeLbl.Text = "Đến ngày:";
            this.lblToTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(360, 5);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(183, 26);
            this.dtpNgayKetThuc.TabIndex = 5;
            this.dtpNgayKetThuc.Value = new System.DateTime(2019, 12, 25, 0, 0, 0, 0);
            this.dtpNgayKetThuc.ValueChanged += new System.EventHandler(this.dtpNgayKetThuc_ValueChanged);
            // 
            // lblFromTimeLbl
            // 
            this.lblFromTimeLbl.AutoSize = true;
            this.lblFromTimeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFromTimeLbl.Location = new System.Drawing.Point(4, 0);
            this.lblFromTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromTimeLbl.Name = "lblFromTimeLbl";
            this.lblFromTimeLbl.Size = new System.Drawing.Size(69, 43);
            this.lblFromTimeLbl.TabIndex = 7;
            this.lblFromTimeLbl.Text = "Từ ngày:";
            this.lblFromTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(81, 5);
            this.dtpNgayBD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(182, 26);
            this.dtpNgayBD.TabIndex = 4;
            this.dtpNgayBD.Value = new System.DateTime(2019, 12, 24, 0, 0, 0, 0);
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(434, 34);
            this.radNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(117, 24);
            this.radNam.TabIndex = 3;
            this.radNam.Text = "Khoảng năm";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radThoiGian_CheckedChanged);
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Location = new System.Drawing.Point(289, 34);
            this.radThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(127, 24);
            this.radThang.TabIndex = 2;
            this.radThang.Text = "Khoảng tháng";
            this.radThang.UseVisualStyleBackColor = true;
            this.radThang.CheckedChanged += new System.EventHandler(this.radThoiGian_CheckedChanged);
            // 
            // radTuan
            // 
            this.radTuan.AutoSize = true;
            this.radTuan.Location = new System.Drawing.Point(163, 34);
            this.radTuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radTuan.Name = "radTuan";
            this.radTuan.Size = new System.Drawing.Size(118, 24);
            this.radTuan.TabIndex = 1;
            this.radTuan.Text = "Khoảng tuần";
            this.radTuan.UseVisualStyleBackColor = true;
            this.radTuan.CheckedChanged += new System.EventHandler(this.radThoiGian_CheckedChanged);
            // 
            // radThoiGian
            // 
            this.radThoiGian.AutoSize = true;
            this.radThoiGian.Checked = true;
            this.radThoiGian.Location = new System.Drawing.Point(9, 34);
            this.radThoiGian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radThoiGian.Name = "radThoiGian";
            this.radThoiGian.Size = new System.Drawing.Size(146, 24);
            this.radThoiGian.TabIndex = 0;
            this.radThoiGian.TabStop = true;
            this.radThoiGian.Text = "Khoảng thời gian";
            this.radThoiGian.UseVisualStyleBackColor = true;
            this.radThoiGian.CheckedChanged += new System.EventHandler(this.radThoiGian_CheckedChanged);
            // 
            // txtTimKiem
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTimKiem, 3);
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Location = new System.Drawing.Point(3, 144);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(567, 26);
            this.txtTimKiem.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 3);
            this.tabControl1.Controls.Add(this.tabHoanThanh);
            this.tabControl1.Controls.Add(this.tabHoanDon);
            this.tabControl1.Controls.Add(this.tabHuyDon);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 175);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 355);
            this.tabControl1.TabIndex = 4;
            // 
            // tabHoanThanh
            // 
            this.tabHoanThanh.Controls.Add(this.dgvHoanThanh);
            this.tabHoanThanh.Location = new System.Drawing.Point(4, 29);
            this.tabHoanThanh.Name = "tabHoanThanh";
            this.tabHoanThanh.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoanThanh.Size = new System.Drawing.Size(559, 322);
            this.tabHoanThanh.TabIndex = 0;
            this.tabHoanThanh.Text = "Hoàn thành";
            this.tabHoanThanh.UseVisualStyleBackColor = true;
            // 
            // dgvHoanThanh
            // 
            this.dgvHoanThanh.AllowUserToAddRows = false;
            this.dgvHoanThanh.AllowUserToDeleteRows = false;
            this.dgvHoanThanh.AutoGenerateColumns = false;
            this.dgvHoanThanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoanThanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDKhachHangDataGridViewTextBoxColumn,
            this.iDNhanVienDataGridViewTextBoxColumn,
            this.ngayDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dgvHoanThanh.DataSource = this.bsHoanThanh;
            this.dgvHoanThanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoanThanh.Location = new System.Drawing.Point(3, 3);
            this.dgvHoanThanh.Name = "dgvHoanThanh";
            this.dgvHoanThanh.ReadOnly = true;
            this.dgvHoanThanh.RowHeadersVisible = false;
            this.dgvHoanThanh.Size = new System.Drawing.Size(553, 316);
            this.dgvHoanThanh.TabIndex = 0;
            this.dgvHoanThanh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoanThanh_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // iDKhachHangDataGridViewTextBoxColumn
            // 
            this.iDKhachHangDataGridViewTextBoxColumn.DataPropertyName = "IDKhachHang";
            this.iDKhachHangDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            this.iDKhachHangDataGridViewTextBoxColumn.Name = "iDKhachHangDataGridViewTextBoxColumn";
            this.iDKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDKhachHangDataGridViewTextBoxColumn.Width = 90;
            // 
            // iDNhanVienDataGridViewTextBoxColumn
            // 
            this.iDNhanVienDataGridViewTextBoxColumn.DataPropertyName = "IDNhanVien";
            this.iDNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.iDNhanVienDataGridViewTextBoxColumn.Name = "iDNhanVienDataGridViewTextBoxColumn";
            this.iDNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDNhanVienDataGridViewTextBoxColumn.Width = 90;
            // 
            // ngayDataGridViewTextBoxColumn
            // 
            this.ngayDataGridViewTextBoxColumn.DataPropertyName = "Ngay";
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.ngayDataGridViewTextBoxColumn.Name = "ngayDataGridViewTextBoxColumn";
            this.ngayDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayDataGridViewTextBoxColumn.Width = 180;
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Hoàn Thành";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.ReadOnly = true;
            this.tinhTrangDataGridViewTextBoxColumn.Width = 130;
            // 
            // bsHoanThanh
            // 
            this.bsHoanThanh.DataSource = typeof(DTO.HoaDon);
            // 
            // tabHoanDon
            // 
            this.tabHoanDon.Controls.Add(this.dgvHoanDon);
            this.tabHoanDon.Location = new System.Drawing.Point(4, 29);
            this.tabHoanDon.Name = "tabHoanDon";
            this.tabHoanDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoanDon.Size = new System.Drawing.Size(559, 322);
            this.tabHoanDon.TabIndex = 1;
            this.tabHoanDon.Text = "Hoàn Đơn";
            this.tabHoanDon.UseVisualStyleBackColor = true;
            // 
            // dgvHoanDon
            // 
            this.dgvHoanDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoanDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoanDon.Location = new System.Drawing.Point(3, 3);
            this.dgvHoanDon.Name = "dgvHoanDon";
            this.dgvHoanDon.Size = new System.Drawing.Size(553, 316);
            this.dgvHoanDon.TabIndex = 1;
            // 
            // tabHuyDon
            // 
            this.tabHuyDon.Controls.Add(this.dgvHuyDon);
            this.tabHuyDon.Location = new System.Drawing.Point(4, 29);
            this.tabHuyDon.Name = "tabHuyDon";
            this.tabHuyDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabHuyDon.Size = new System.Drawing.Size(559, 322);
            this.tabHuyDon.TabIndex = 2;
            this.tabHuyDon.Text = "Hủy đơn";
            this.tabHuyDon.UseVisualStyleBackColor = true;
            // 
            // dgvHuyDon
            // 
            this.dgvHuyDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuyDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHuyDon.Location = new System.Drawing.Point(3, 3);
            this.dgvHuyDon.Name = "dgvHuyDon";
            this.dgvHuyDon.Size = new System.Drawing.Size(553, 316);
            this.dgvHuyDon.TabIndex = 1;
            // 
            // frmChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 533);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.frmChon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grTimeline.ResumeLayout(false);
            this.grTimeline.PerformLayout();
            this.tlpChonThoiGian.ResumeLayout(false);
            this.tlpChonThoiGian.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabHoanThanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoanThanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHoanThanh)).EndInit();
            this.tabHoanDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoanDon)).EndInit();
            this.tabHuyDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuyDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.GroupBox grTimeline;
        internal System.Windows.Forms.TableLayoutPanel tlpChonThoiGian;
        internal System.Windows.Forms.Label lblToTimeLbl;
        internal System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        internal System.Windows.Forms.Label lblFromTimeLbl;
        internal System.Windows.Forms.DateTimePicker dtpNgayBD;
        internal System.Windows.Forms.RadioButton radNam;
        internal System.Windows.Forms.RadioButton radThang;
        internal System.Windows.Forms.RadioButton radTuan;
        internal System.Windows.Forms.RadioButton radThoiGian;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHoanThanh;
        private System.Windows.Forms.DataGridView dgvHoanThanh;
        private System.Windows.Forms.TabPage tabHoanDon;
        private System.Windows.Forms.DataGridView dgvHoanDon;
        private System.Windows.Forms.TabPage tabHuyDon;
        private System.Windows.Forms.DataGridView dgvHuyDon;
        private System.Windows.Forms.BindingSource bsHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
    }
}