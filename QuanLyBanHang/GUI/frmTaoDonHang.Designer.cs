﻿namespace GUI
{
    partial class frmTaoDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsHang = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaSiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDanhSachHang = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaSiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhapDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.btnChonDon = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chbGiaSi = new System.Windows.Forms.CheckBox();
            this.txtGiaSi = new System.Windows.Forms.TextBox();
            this.btnNhapGiaSi = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsHang)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHang)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsNhanVien)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsHang
            // 
            this.bsHang.DataSource = typeof(DTO.Hang);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.88253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.751234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.txtHang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvHang, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvDanhSachHang, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnChonDon, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnKhachHang, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHoaDon, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblKhachHang, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNhapGiaSi, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnTroLai, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnHoanThanh, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnHuy, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.132743F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.026548F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.734513F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.548673F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 565);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtHang
            // 
            this.txtHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHang.Location = new System.Drawing.Point(3, 3);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(631, 26);
            this.txtHang.TabIndex = 4;
            // 
            // dgvHang
            // 
            this.dgvHang.AutoGenerateColumns = false;
            this.dgvHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.ColumnHeadersVisible = false;
            this.dgvHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.giaBanDataGridViewTextBoxColumn,
            this.giaSiDataGridViewTextBoxColumn,
            this.giaNhapDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvHang, 2);
            this.dgvHang.DataSource = this.bsHang;
            this.dgvHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHang.Location = new System.Drawing.Point(0, 28);
            this.dgvHang.Margin = new System.Windows.Forms.Padding(0);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dgvHang, 3);
            this.dgvHang.Size = new System.Drawing.Size(675, 208);
            this.dgvHang.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenHang";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenHang";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            // 
            // giaSiDataGridViewTextBoxColumn
            // 
            this.giaSiDataGridViewTextBoxColumn.DataPropertyName = "GiaSi";
            this.giaSiDataGridViewTextBoxColumn.HeaderText = "GiaSi";
            this.giaSiDataGridViewTextBoxColumn.Name = "giaSiDataGridViewTextBoxColumn";
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            this.giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.HeaderText = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // dgvDanhSachHang
            // 
            this.dgvDanhSachHang.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten,
            this.SoLuong,
            this.ThanhTien,
            this.Sua,
            this.Xoa,
            this.iDDataGridViewTextBoxColumn,
            this.tenHangDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn1,
            this.giaSiDataGridViewTextBoxColumn1,
            this.giaNhapDataGridViewTextBoxColumn1,
            this.soLuongDataGridViewTextBoxColumn1});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDanhSachHang, 2);
            this.dgvDanhSachHang.DataSource = this.bsHang;
            this.dgvDanhSachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHang.GridColor = System.Drawing.Color.White;
            this.dgvDanhSachHang.Location = new System.Drawing.Point(3, 239);
            this.dgvDanhSachHang.Name = "dgvDanhSachHang";
            this.dgvDanhSachHang.ReadOnly = true;
            this.dgvDanhSachHang.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dgvDanhSachHang, 4);
            this.dgvDanhSachHang.Size = new System.Drawing.Size(669, 284);
            this.dgvDanhSachHang.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "TenHang";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 300;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 60;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 150;
            // 
            // Sua
            // 
            this.Sua.HeaderText = "Sửa";
            this.Sua.Name = "Sua";
            this.Sua.ReadOnly = true;
            this.Sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sua.Text = "Sửa";
            this.Sua.Width = 55;
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Text = "Xóa";
            this.Xoa.Width = 55;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            this.tenHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaBanDataGridViewTextBoxColumn1
            // 
            this.giaBanDataGridViewTextBoxColumn1.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn1.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn1.Name = "giaBanDataGridViewTextBoxColumn1";
            this.giaBanDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // giaSiDataGridViewTextBoxColumn1
            // 
            this.giaSiDataGridViewTextBoxColumn1.DataPropertyName = "GiaSi";
            this.giaSiDataGridViewTextBoxColumn1.HeaderText = "GiaSi";
            this.giaSiDataGridViewTextBoxColumn1.Name = "giaSiDataGridViewTextBoxColumn1";
            this.giaSiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // giaNhapDataGridViewTextBoxColumn1
            // 
            this.giaNhapDataGridViewTextBoxColumn1.DataPropertyName = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn1.HeaderText = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn1.Name = "giaNhapDataGridViewTextBoxColumn1";
            this.giaNhapDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn1
            // 
            this.soLuongDataGridViewTextBoxColumn1.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn1.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn1.Name = "soLuongDataGridViewTextBoxColumn1";
            this.soLuongDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(637, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 28);
            this.button7.TabIndex = 8;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.97309F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.02691F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblThanhTien, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 526);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(669, 33);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng Tiền : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThanhTien.Location = new System.Drawing.Point(149, 0);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(517, 33);
            this.lblThanhTien.TabIndex = 1;
            this.lblThanhTien.Text = "0";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnChonDon
            // 
            this.btnChonDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChonDon.Location = new System.Drawing.Point(846, 81);
            this.btnChonDon.Name = "btnChonDon";
            this.btnChonDon.Size = new System.Drawing.Size(164, 73);
            this.btnChonDon.TabIndex = 3;
            this.btnChonDon.Text = "&Chọn Đơn";
            this.btnChonDon.UseVisualStyleBackColor = true;
            this.btnChonDon.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKhachHang.Location = new System.Drawing.Point(846, 160);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(164, 73);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "&Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoaDon.Location = new System.Drawing.Point(678, 78);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(162, 79);
            this.lblHoaDon.TabIndex = 11;
            this.lblHoaDon.Text = "Mã Hóa Đơn: ";
            this.lblHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKhachHang.Location = new System.Drawing.Point(678, 157);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(162, 79);
            this.lblKhachHang.TabIndex = 11;
            this.lblKhachHang.Text = "Tên Khách Hàng: ";
            this.lblKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox1, 2);
            this.comboBox1.DataSource = this.bsNhanVien;
            this.comboBox1.DisplayMember = "Ten";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(678, 41);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "Ten";
            // 
            // bsNhanVien
            // 
            this.bsNhanVien.DataSource = typeof(DTO.NhanVien);
            // 
            // label2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(678, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Người bán";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.chbGiaSi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtGiaSi, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(675, 236);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(168, 79);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // chbGiaSi
            // 
            this.chbGiaSi.Location = new System.Drawing.Point(30, 3);
            this.chbGiaSi.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.chbGiaSi.Name = "chbGiaSi";
            this.chbGiaSi.Size = new System.Drawing.Size(135, 33);
            this.chbGiaSi.TabIndex = 0;
            this.chbGiaSi.Text = "Bán Giá &Sỉ";
            this.chbGiaSi.UseVisualStyleBackColor = true;
            // 
            // txtGiaSi
            // 
            this.txtGiaSi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaSi.Location = new System.Drawing.Point(3, 42);
            this.txtGiaSi.Name = "txtGiaSi";
            this.txtGiaSi.Size = new System.Drawing.Size(162, 26);
            this.txtGiaSi.TabIndex = 1;
            // 
            // btnNhapGiaSi
            // 
            this.btnNhapGiaSi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNhapGiaSi.Location = new System.Drawing.Point(846, 239);
            this.btnNhapGiaSi.Name = "btnNhapGiaSi";
            this.btnNhapGiaSi.Size = new System.Drawing.Size(164, 73);
            this.btnNhapGiaSi.TabIndex = 1;
            this.btnNhapGiaSi.Text = "Lưu Giá Sỉ";
            this.btnNhapGiaSi.UseVisualStyleBackColor = true;
            // 
            // btnTroLai
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnTroLai, 2);
            this.btnTroLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTroLai.Location = new System.Drawing.Point(685, 404);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(10);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(318, 59);
            this.btnTroLai.TabIndex = 1;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            // 
            // btnHoanThanh
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnHoanThanh, 2);
            this.btnHoanThanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHoanThanh.Location = new System.Drawing.Point(685, 483);
            this.btnHoanThanh.Margin = new System.Windows.Forms.Padding(10);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.tableLayoutPanel1.SetRowSpan(this.btnHoanThanh, 2);
            this.btnHoanThanh.Size = new System.Drawing.Size(318, 72);
            this.btnHoanThanh.TabIndex = 2;
            this.btnHoanThanh.Text = "&Hoàn Thành";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnHuy, 2);
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuy.Location = new System.Drawing.Point(685, 325);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(10);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(318, 59);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // frmTaoDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 565);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTaoDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaoDonHang";
            this.Load += new System.EventHandler(this.frmTaoDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsHang)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHang)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsNhanVien)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.DataGridView dgvDanhSachHang;
        private System.Windows.Forms.Button btnNhapGiaSi;
        private System.Windows.Forms.Button btnChonDon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bsNhanVien;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox chbGiaSi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtGiaSi;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaSiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaSiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn1;
    }
}