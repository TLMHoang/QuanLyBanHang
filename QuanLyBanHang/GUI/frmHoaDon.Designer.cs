namespace GUI
{
    partial class frmHoaDon
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChuaHT = new System.Windows.Forms.TabPage();
            this.tabHoanThanh = new System.Windows.Forms.TabPage();
            this.btnXoaTXT = new System.Windows.Forms.Button();
            this.dgvHoan = new System.Windows.Forms.DataGridView();
            this.dgvHuy = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabChuaHT.SuspendLayout();
            this.tabHoanThanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.51303F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.486969F));
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnXoaTXT, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.51145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.48855F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(729, 524);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Location = new System.Drawing.Point(3, 493);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(682, 26);
            this.txtTimKiem.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tabChuaHT);
            this.tabControl1.Controls.Add(this.tabHoanThanh);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 484);
            this.tabControl1.TabIndex = 1;
            // 
            // tabChuaHT
            // 
            this.tabChuaHT.Controls.Add(this.dgvHoan);
            this.tabChuaHT.Location = new System.Drawing.Point(4, 29);
            this.tabChuaHT.Name = "tabChuaHT";
            this.tabChuaHT.Padding = new System.Windows.Forms.Padding(3);
            this.tabChuaHT.Size = new System.Drawing.Size(715, 451);
            this.tabChuaHT.TabIndex = 0;
            this.tabChuaHT.Text = "Đơn đợi chốt";
            this.tabChuaHT.UseVisualStyleBackColor = true;
            // 
            // tabHoanThanh
            // 
            this.tabHoanThanh.Controls.Add(this.dgvHuy);
            this.tabHoanThanh.Location = new System.Drawing.Point(4, 29);
            this.tabHoanThanh.Name = "tabHoanThanh";
            this.tabHoanThanh.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoanThanh.Size = new System.Drawing.Size(715, 451);
            this.tabHoanThanh.TabIndex = 1;
            this.tabHoanThanh.Text = "Đơn đã hoàn thành";
            this.tabHoanThanh.UseVisualStyleBackColor = true;
            // 
            // btnXoaTXT
            // 
            this.btnXoaTXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaTXT.Location = new System.Drawing.Point(691, 493);
            this.btnXoaTXT.Name = "btnXoaTXT";
            this.btnXoaTXT.Size = new System.Drawing.Size(35, 28);
            this.btnXoaTXT.TabIndex = 2;
            this.btnXoaTXT.Text = "X";
            this.btnXoaTXT.UseVisualStyleBackColor = true;
            // 
            // dgvHoan
            // 
            this.dgvHoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoan.Location = new System.Drawing.Point(3, 3);
            this.dgvHoan.Name = "dgvHoan";
            this.dgvHoan.Size = new System.Drawing.Size(709, 445);
            this.dgvHoan.TabIndex = 0;
            // 
            // dgvHuy
            // 
            this.dgvHuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHuy.Location = new System.Drawing.Point(3, 3);
            this.dgvHuy.Name = "dgvHuy";
            this.dgvHuy.Size = new System.Drawing.Size(709, 445);
            this.dgvHuy.TabIndex = 0;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabChuaHT.ResumeLayout(false);
            this.tabHoanThanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChuaHT;
        private System.Windows.Forms.DataGridView dgvHoan;
        private System.Windows.Forms.TabPage tabHoanThanh;
        private System.Windows.Forms.Button btnXoaTXT;
        private System.Windows.Forms.DataGridView dgvHuy;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}