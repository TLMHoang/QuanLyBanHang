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
    public partial class frmNhapHang : Form
    {
        public Hang hang = new Hang();
        public frmNhapHang()
        {
            InitializeComponent();
            dgvDanhSach.ColumnHeadersVisible = false;
            dgvDanhSach.RowHeadersVisible = false;
        }

        private async void frmNhapHang_Load(object sender, EventArgs e)
        {
            dgvDanhSach.SuspendLayout();
            bsHang.SuspendBinding();

            bsHang.DataSource = await new HangBAL().LayDT();

            bsHang.ResumeBinding();
            dgvDanhSach.ResumeLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.TextLength > 0)
            {
                bsHang.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [TenHang] LIKE '%{0}%'", txtFind.Text);
            }
            else
            {
                btnCapNhap.Enabled = false;
                this.AcceptButton = null;
                bsHang.RemoveFilter();
            }
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dgvDanhSach.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtFind.Text = dgvDanhSach.Rows[0].Cells[1].Value.ToString();
                hang = Program.lstHang.FirstOrDefault(p => p.ID == Convert.ToInt32(dgvDanhSach.Rows[0].Cells["ID"].Value));
                numSoLuong.Focus();
                this.AcceptButton = btnCapNhap;
                btnCapNhap.Enabled = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                button1_Click_1(null, null);
            }
        }

        private void dgvDanhSach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFind.Text = dgvDanhSach.Rows[dgvDanhSach.CurrentCell.RowIndex].Cells[1].Value.ToString();
                hang = Program.lstHang.FirstOrDefault(p => p.ID == Convert.ToInt32(dgvDanhSach.Rows[0].Cells["ID"].Value));
                numSoLuong.Focus();
                btnCapNhap.Enabled = true;
                this.AcceptButton = btnCapNhap;
            }
            else
            {
                if (e.KeyCode == Keys.Space)
                {
                    txtFind.Focus();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                button1_Click_1(null, null);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (numSoLuong.TextLength == 0)
            {
                numSoLuong.Text = "0";
            }
            hang.SoLuong += int.Parse(numSoLuong.Text);
            if (await new HangBAL().CapNhap(hang) != -1)
            {
                numSoLuong.Text = "";
                txtFind.Text = "";
                this.AcceptButton = null;
                txtFind.Focus();
                btnCapNhap.Enabled = false;

            }
            else
            {
                MessageBox.Show("Nhập hàng mới không thành công thử lại");
                numSoLuong.Text = "";
                txtFind.Text = "";
                btnCapNhap.Enabled = false;
                this.AcceptButton = null;
                txtFind.Focus();
            }

        }

        private void numSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                button1_Click_1(null, null);
            }

        }

        private void dgvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            txtFind.Text = dgvDanhSach.Rows[dgvDanhSach.CurrentCell.RowIndex].Cells["TenHang"].Value.ToString();
            hang = Program.lstHang.FirstOrDefault(p => p.ID == Convert.ToInt32(dgvDanhSach.Rows[0].Cells["ID"].Value));
            numSoLuong.Focus();
            btnCapNhap.Enabled = true;
            this.AcceptButton = btnCapNhap;
        }

        private void frmNhapHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtFind.Text = "";
                txtFind.Focus();
                numSoLuong.Text = "";
                btnCapNhap.Enabled = false;
                this.AcceptButton = null;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            numSoLuong.Text = "";
            txtFind.Text = "";
            this.AcceptButton = null;
            txtFind.Focus();
            btnCapNhap.Enabled = false;
        }
    }
}
