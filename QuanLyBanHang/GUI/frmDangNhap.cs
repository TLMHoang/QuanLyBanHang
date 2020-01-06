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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (await new TaiKhoanBAL().DangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
