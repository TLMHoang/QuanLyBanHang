namespace GUI
{
    partial class frmTimThongtin
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.bsHang = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(0, 0);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(344, 26);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "Nhập thông tin cần tìm......";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            this.txtTimKiem.MouseEnter += new System.EventHandler(this.frmTimThongtin_Enter);
            this.txtTimKiem.MouseLeave += new System.EventHandler(this.frmTimThongtin_Leave);
            // 
            // dgvHang
            // 
            this.dgvHang.AllowUserToAddRows = false;
            this.dgvHang.AllowUserToDeleteRows = false;
            this.dgvHang.AutoGenerateColumns = false;
            this.dgvHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.ColumnHeadersVisible = false;
            this.dgvHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenHangDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
            this.dgvHang.DataSource = this.bsHang;
            this.dgvHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHang.GridColor = System.Drawing.Color.White;
            this.dgvHang.Location = new System.Drawing.Point(0, 26);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.ReadOnly = true;
            this.dgvHang.RowHeadersVisible = false;
            this.dgvHang.Size = new System.Drawing.Size(344, 195);
            this.dgvHang.TabIndex = 1;
            // 
            // bsHang
            // 
            this.bsHang.DataSource = typeof(DTO.Hang);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            this.tenHangDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenHangDataGridViewTextBoxColumn.Width = 230;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SL";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Width = 50;
            // 
            // frmTimThongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 221);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.txtTimKiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimThongtin";
            this.Opacity = 0.05D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tra Thông Tin";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimThongtin_FormClosing);
            this.Load += new System.EventHandler(this.frmTimThongtin_Load);
            this.MouseEnter += new System.EventHandler(this.frmTimThongtin_Enter);
            this.MouseLeave += new System.EventHandler(this.frmTimThongtin_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsHang;
    }
}