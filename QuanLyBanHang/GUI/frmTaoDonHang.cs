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
    public partial class frmTaoDonHang : Form
    {
        public frmTaoDonHang()
        {
            InitializeComponent();
        }

        private async void frmTaoDonHang_Load(object sender, EventArgs e)
        {
            //lstvHang.SuspendLayout();

            bsHang.SuspendBinding();

            bsHang.DataSource = await new HangBAL().LayDT();

            bsHang.ResumeBinding();

            //lstvHang.ResumeLayout();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đơn");
        }
    }
}
