using BAL;
using DTO;
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
    public partial class frmYeuCauHang : Form
    {
        private CTHD c = new CTHD();
        private bool GS;
        public frmYeuCauHang()
        {
            InitializeComponent();
        }

        public frmYeuCauHang(CTHD ct, bool gs, int Gia, int SL)
        {
            InitializeComponent();

            c.IDHang = ct.IDHang;
            c.IDHoaDon = ct.IDHoaDon;
            c.SoLuong = ct.SoLuong;
            c.Tang = ct.Tang;
            c.GiaSi = ct.GiaSi;
            this.GS = gs;
            numSL.Maximum = SL;

            txtGiaSi.ReadOnly = !gs;
            if (gs)
            {
                txtGiaSi.Text = "";
            }
            else
            {
                txtGiaSi.Tag = txtGiaSi.Text = Program.FormatNumber(Gia.ToString());
            }
            
        }

        private async Task<bool> Check()
        {
            DataTable dt = (await new CTHDBAL().LayID(c.IDHoaDon, c.IDHang));
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            c.SoLuong = Convert.ToInt32(numSL.Value);
            if (await Check())
            {
                await new CTHDBAL().CapNhap(c);
            }
            else
            {
                await new CTHDBAL().Them(c);
            }
            this.Close();
        }

        private void chBTang_CheckedChanged(object sender, EventArgs e)
        {
            if (chBTang.Checked)
            {
                txtGiaSi.ReadOnly = true;
                txtGiaSi.Text = "0";
            }
            else
            {
                txtGiaSi.ReadOnly = !GS;
                if (GS)
                {
                    txtGiaSi.Text = "";
                }
                else
                {
                    txtGiaSi.Text = txtGiaSi.Tag.ToString();
                }
            }
            
        }

        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            if (numSL.Value == numSL.Maximum)
            {
                MessageBox.Show(this.Text + "\nCòn : " + numSL.Maximum + "\nKhông bán quá số lượng tồn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtGiaSi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtGiaSi_Leave(object sender, EventArgs e)
        {
            txtGiaSi.Text = Program.FormatNumber(txtGiaSi.Text);
        }
    }
}
