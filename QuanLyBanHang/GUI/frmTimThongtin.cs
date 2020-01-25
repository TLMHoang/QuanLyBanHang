using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTimThongtin : Form
    {

        private Size sizeH = new Size(360, 65);
        private Size sizeS = new Size(360, 260);
        public frmTimThongtin()
        {
            InitializeComponent();
        }

        

        private void frmTimThongtin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        

        private async void frmTimThongtin_Load(object sender, EventArgs e)
        {
            frmTimThongtin_Leave(null, null);
            bsHang.SuspendBinding();
            dgvHang.SuspendLayout();

            bsHang.DataSource = await new HangBAL().LayDT();

            dgvHang.ResumeLayout();
            bsHang.ResumeBinding();
        }


        #region Tìm kiếm

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Nhập thông tin cần tìm......";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập thông tin cần tìm......")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength == 0 || txtTimKiem.Text == "Nhập thông tin cần tìm......")
            {
                bsHang.RemoveFilter();
            }
            else
            {
                bsHang.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [TenHang] LIKE '%{0}%'", txtTimKiem.Text);
            }
        }

        #endregion


        #region Hiệu ứng bóng mờ

        private void frmTimThongtin_Leave(object sender, EventArgs e)
        {
            this.Opacity = 0.05;
            this.Size = sizeH;
        }

        private void frmTimThongtin_Enter(object sender, EventArgs e)
        {
            this.Opacity = 1;
            this.Size = sizeS;
        }

        #endregion

        
    }
}
