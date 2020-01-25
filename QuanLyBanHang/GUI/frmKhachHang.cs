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
    public partial class frmKhachHang : Form
    {
        private HoaDon HD = new HoaDon();
        public frmKhachHang(HoaDon hd)
        {
            InitializeComponent();
            HD = hd;
        }



        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txt_Leave(null, null);

            bsKH.SuspendBinding();
            dgvKH.SuspendLayout();

            bsKH.DataSource = Program.dtKhachHang;

            dgvKH.ResumeLayout();
            bsKH.ResumeBinding();
        }
        #region textBox

        private void txt_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Nhập để tìm kiếm";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập để tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;

            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "" || txtTimKiem.Text == "Nhập để tìm kiếm")
            {
                bsKH.RemoveFilter();
            }
            else
            {
                bsKH.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [TenKH] LIKE '%{0}%' OR [SDT] LIKE '%{0}%'", txtTimKiem.Text);
            }
        }

        #endregion

        private async void btnThem_Click(object sender, EventArgs e)
        {
            frmThemKhachHang f = new frmThemKhachHang(HD);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Program.lstKhachHang = await new KhachHangBAL().LayLst();
                HD.IDKhachHang = (Program.lstKhachHang.OrderBy(p => p.ID).Last()).ID;
                await new HoaDonBAL().CapNhap(HD);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            txt_Leave(null, null);
        }

        private async void btnHuy_Click(object sender, EventArgs e)
        {
            HD.IDKhachHang = -1;
            await new HoaDonBAL().CapNhap(HD);
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dgvKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HD.IDKhachHang = Convert.ToInt32(dgvKH.Rows[dgvKH.CurrentCell.RowIndex].Cells["ID"].Value);
                await new HoaDonBAL().CapNhap(HD);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private async void dgvKH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HD.IDKhachHang = Convert.ToInt32(dgvKH.Rows[dgvKH.CurrentCell.RowIndex].Cells["ID"].Value);
            await new HoaDonBAL().CapNhap(HD);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvKH_KeyDown(null, null);
            }
            else
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    dgvKH.Focus();
                }
            }
        }
    }
}