namespace GUI
{
    partial class frmDoanhThu
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
            this.tlpWrapper = new System.Windows.Forms.TableLayoutPanel();
            this.grTimeline = new System.Windows.Forms.GroupBox();
            this.tlpThangNam = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.tlpChonThoiGian = new System.Windows.Forms.TableLayoutPanel();
            this.lblToTimeLbl = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblFromTimeLbl = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radThang = new System.Windows.Forms.RadioButton();
            this.radTuan = new System.Windows.Forms.RadioButton();
            this.radThoiGian = new System.Windows.Forms.RadioButton();
            this.lvDanhSach = new System.Windows.Forms.ListView();
            this.collIDHoaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTongChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotalAfterLbl = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoiNhuan = new System.Windows.Forms.Label();
            this.tlpWrapper.SuspendLayout();
            this.grTimeline.SuspendLayout();
            this.tlpThangNam.SuspendLayout();
            this.tlpChonThoiGian.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpWrapper
            // 
            this.tlpWrapper.ColumnCount = 2;
            this.tlpWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWrapper.Controls.Add(this.grTimeline, 0, 0);
            this.tlpWrapper.Controls.Add(this.lvDanhSach, 0, 1);
            this.tlpWrapper.Controls.Add(this.lblTotalAfterLbl, 0, 3);
            this.tlpWrapper.Controls.Add(this.lblTong, 1, 3);
            this.tlpWrapper.Controls.Add(this.label1, 0, 4);
            this.tlpWrapper.Controls.Add(this.lblLoiNhuan, 1, 4);
            this.tlpWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWrapper.Location = new System.Drawing.Point(0, 0);
            this.tlpWrapper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpWrapper.Name = "tlpWrapper";
            this.tlpWrapper.RowCount = 5;
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWrapper.Size = new System.Drawing.Size(716, 752);
            this.tlpWrapper.TabIndex = 6;
            // 
            // grTimeline
            // 
            this.tlpWrapper.SetColumnSpan(this.grTimeline, 2);
            this.grTimeline.Controls.Add(this.tlpThangNam);
            this.grTimeline.Controls.Add(this.btnViewReport);
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
            this.grTimeline.Size = new System.Drawing.Size(708, 131);
            this.grTimeline.TabIndex = 0;
            this.grTimeline.TabStop = false;
            this.grTimeline.Text = "Chọn thời gian";
            // 
            // tlpThangNam
            // 
            this.tlpThangNam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpThangNam.ColumnCount = 4;
            this.tlpThangNam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpThangNam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpThangNam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpThangNam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpThangNam.Controls.Add(this.label2, 2, 0);
            this.tlpThangNam.Controls.Add(this.label3, 0, 0);
            this.tlpThangNam.Controls.Add(this.cbxNam, 1, 0);
            this.tlpThangNam.Controls.Add(this.cbxThang, 3, 0);
            this.tlpThangNam.Location = new System.Drawing.Point(8, 78);
            this.tlpThangNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpThangNam.Name = "tlpThangNam";
            this.tlpThangNam.RowCount = 1;
            this.tlpThangNam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpThangNam.Size = new System.Drawing.Size(690, 43);
            this.tlpThangNam.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(343, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tháng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 43);
            this.label3.TabIndex = 7;
            this.label3.Text = "Năm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxNam
            // 
            this.cbxNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Location = new System.Drawing.Point(53, 3);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(283, 28);
            this.cbxNam.TabIndex = 9;
            // 
            // cbxThang
            // 
            this.cbxThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxThang.FormattingEnabled = true;
            this.cbxThang.Location = new System.Drawing.Point(404, 3);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(283, 28);
            this.cbxThang.TabIndex = 9;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewReport.Location = new System.Drawing.Point(572, 29);
            this.btnViewReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(128, 35);
            this.btnViewReport.TabIndex = 7;
            this.btnViewReport.Text = "Xem";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
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
            this.tlpChonThoiGian.Size = new System.Drawing.Size(690, 43);
            this.tlpChonThoiGian.TabIndex = 6;
            // 
            // lblToTimeLbl
            // 
            this.lblToTimeLbl.AutoSize = true;
            this.lblToTimeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToTimeLbl.Location = new System.Drawing.Point(343, 0);
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
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(432, 5);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(254, 26);
            this.dtpNgayKetThuc.TabIndex = 5;
            this.dtpNgayKetThuc.Value = new System.DateTime(2019, 12, 25, 0, 0, 0, 0);
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
            this.dtpNgayBD.Size = new System.Drawing.Size(254, 26);
            this.dtpNgayBD.TabIndex = 4;
            this.dtpNgayBD.Value = new System.DateTime(2019, 12, 24, 0, 0, 0, 0);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(465, 34);
            this.radNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(98, 24);
            this.radNam.TabIndex = 3;
            this.radNam.Text = "Theo năm";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radThoiGian_CheckedChanged);
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Location = new System.Drawing.Point(336, 34);
            this.radThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(108, 24);
            this.radThang.TabIndex = 2;
            this.radThang.Text = "Theo tháng";
            this.radThang.UseVisualStyleBackColor = true;
            this.radThang.CheckedChanged += new System.EventHandler(this.radThoiGian_CheckedChanged);
            // 
            // radTuan
            // 
            this.radTuan.AutoSize = true;
            this.radTuan.Location = new System.Drawing.Point(216, 34);
            this.radTuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radTuan.Name = "radTuan";
            this.radTuan.Size = new System.Drawing.Size(99, 24);
            this.radTuan.TabIndex = 1;
            this.radTuan.Text = "Theo tuần";
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
            this.radThoiGian.Size = new System.Drawing.Size(184, 24);
            this.radThoiGian.TabIndex = 0;
            this.radThoiGian.TabStop = true;
            this.radThoiGian.Text = "Theo khoảng thời gian";
            this.radThoiGian.UseVisualStyleBackColor = true;
            this.radThoiGian.CheckedChanged += new System.EventHandler(this.radThoiGian_CheckedChanged);
            // 
            // lvDanhSach
            // 
            this.lvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.collIDHoaDon,
            this.colNV,
            this.colTenKH,
            this.colTongChi,
            this.colTong});
            this.tlpWrapper.SetColumnSpan(this.lvDanhSach, 2);
            this.lvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSach.FullRowSelect = true;
            this.lvDanhSach.GridLines = true;
            this.lvDanhSach.HideSelection = false;
            this.lvDanhSach.Location = new System.Drawing.Point(4, 146);
            this.lvDanhSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvDanhSach.MultiSelect = false;
            this.lvDanhSach.Name = "lvDanhSach";
            this.lvDanhSach.Size = new System.Drawing.Size(708, 561);
            this.lvDanhSach.TabIndex = 3;
            this.lvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lvDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // collIDHoaDon
            // 
            this.collIDHoaDon.Text = "Mã HĐ";
            // 
            // colNV
            // 
            this.colNV.Text = "Acc Bán";
            this.colNV.Width = 145;
            // 
            // colTenKH
            // 
            this.colTenKH.Text = "Khách hàng";
            this.colTenKH.Width = 162;
            // 
            // colTongChi
            // 
            this.colTongChi.Text = "Vốn";
            this.colTongChi.Width = 160;
            // 
            // colTong
            // 
            this.colTong.Text = "Tổng";
            this.colTong.Width = 165;
            // 
            // lblTotalAfterLbl
            // 
            this.lblTotalAfterLbl.AutoSize = true;
            this.lblTotalAfterLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAfterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalAfterLbl.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAfterLbl.Location = new System.Drawing.Point(4, 712);
            this.lblTotalAfterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAfterLbl.Name = "lblTotalAfterLbl";
            this.lblTotalAfterLbl.Size = new System.Drawing.Size(350, 20);
            this.lblTotalAfterLbl.TabIndex = 6;
            this.lblTotalAfterLbl.Text = "Tổng doanh thu nhận được:";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTong.ForeColor = System.Drawing.Color.Red;
            this.lblTong.Location = new System.Drawing.Point(362, 712);
            this.lblTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(350, 20);
            this.lblTong.TabIndex = 9;
            this.lblTong.Text = "lblTotal";
            this.lblTong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 732);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tổng lợi nhuận :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblLoiNhuan
            // 
            this.lblLoiNhuan.AutoSize = true;
            this.lblLoiNhuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoiNhuan.ForeColor = System.Drawing.Color.Red;
            this.lblLoiNhuan.Location = new System.Drawing.Point(361, 732);
            this.lblLoiNhuan.Name = "lblLoiNhuan";
            this.lblLoiNhuan.Size = new System.Drawing.Size(352, 20);
            this.lblLoiNhuan.TabIndex = 10;
            this.lblLoiNhuan.Text = "lblloiNhuan";
            this.lblLoiNhuan.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 752);
            this.Controls.Add(this.tlpWrapper);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDoanhThu";
            this.Text = "frmDoanhThu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            this.tlpWrapper.ResumeLayout(false);
            this.tlpWrapper.PerformLayout();
            this.grTimeline.ResumeLayout(false);
            this.grTimeline.PerformLayout();
            this.tlpThangNam.ResumeLayout(false);
            this.tlpThangNam.PerformLayout();
            this.tlpChonThoiGian.ResumeLayout(false);
            this.tlpChonThoiGian.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel tlpWrapper;
        internal System.Windows.Forms.GroupBox grTimeline;
        internal System.Windows.Forms.Button btnViewReport;
        internal System.Windows.Forms.TableLayoutPanel tlpChonThoiGian;
        internal System.Windows.Forms.Label lblToTimeLbl;
        internal System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        internal System.Windows.Forms.Label lblFromTimeLbl;
        internal System.Windows.Forms.DateTimePicker dtpNgayBD;
        internal System.Windows.Forms.RadioButton radNam;
        internal System.Windows.Forms.RadioButton radThang;
        internal System.Windows.Forms.RadioButton radTuan;
        internal System.Windows.Forms.RadioButton radThoiGian;
        internal System.Windows.Forms.ListView lvDanhSach;
        internal System.Windows.Forms.ColumnHeader collIDHoaDon;
        internal System.Windows.Forms.ColumnHeader colNV;
        private System.Windows.Forms.ColumnHeader colTenKH;
        internal System.Windows.Forms.Label lblTotalAfterLbl;
        internal System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoiNhuan;
        internal System.Windows.Forms.TableLayoutPanel tlpThangNam;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.ComboBox cbxThang;
        private System.Windows.Forms.ColumnHeader colTongChi;
        private System.Windows.Forms.ColumnHeader colTong;
    }
}