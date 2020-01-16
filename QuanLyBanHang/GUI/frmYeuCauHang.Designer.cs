﻿namespace GUI
{
    partial class frmYeuCauHang
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
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpWrapper
            // 
            this.tlpWrapper.ColumnCount = 4;
            this.tlpWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.01F));
            this.tlpWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tlpWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tlpWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tlpWrapper.Controls.Add(this.numSL, 1, 1);
            this.tlpWrapper.Controls.Add(this.label2, 0, 1);
            this.tlpWrapper.Controls.Add(this.btnXacNhan, 0, 3);
            this.tlpWrapper.Controls.Add(this.btnTroLai, 1, 3);
            this.tlpWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWrapper.Location = new System.Drawing.Point(0, 0);
            this.tlpWrapper.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tlpWrapper.Name = "tlpWrapper";
            this.tlpWrapper.RowCount = 4;
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWrapper.Size = new System.Drawing.Size(358, 106);
            this.tlpWrapper.TabIndex = 0;
            // 
            // btnTroLai
            // 
            this.tlpWrapper.SetColumnSpan(this.btnTroLai, 3);
            this.btnTroLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTroLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTroLai.Location = new System.Drawing.Point(187, 50);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(163, 51);
            this.btnTroLai.TabIndex = 2;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnXacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXacNhan.Location = new System.Drawing.Point(8, 50);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(163, 51);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // numSL
            // 
            this.tlpWrapper.SetColumnSpan(this.numSL, 3);
            this.numSL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSL.Location = new System.Drawing.Point(187, 5);
            this.numSL.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.numSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(163, 35);
            this.numSL.TabIndex = 0;
            this.numSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(8, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmYeuCauHang
            // 
            this.AcceptButton = this.btnXacNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTroLai;
            this.ClientSize = new System.Drawing.Size(358, 106);
            this.Controls.Add(this.tlpWrapper);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmYeuCauHang";
            this.Text = "Yêu cầu hàng";
            this.tlpWrapper.ResumeLayout(false);
            this.tlpWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpWrapper;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Label label2;
    }
}