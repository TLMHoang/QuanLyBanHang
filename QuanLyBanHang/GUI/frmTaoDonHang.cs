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
    public partial class frmTaoDonHang : Form
    {

        private class CTMon
        {
            public int IDHoaDon { get; set; }
            public int IDHang { get; set; }
            public string TenHang { get; set; }
            public string Gia { get; set; }
            public int SL { get; set; }
            public string ThanhTien { get; set; }
        }

        private HoaDon hd = new HoaDon();
        private BindingSource bs = new BindingSource();
        public frmTaoDonHang()
        {
            InitializeComponent();
            
        }

        private async void frmTaoDonHang_Load(object sender, EventArgs e)
        {
            dgvHang.SuspendLayout();
            bsHang.SuspendBinding();
            bsNhanVien.SuspendBinding();

            bsHang.DataSource = await new HangBAL().LayDT();
            bsNhanVien.DataSource = await new NhanVienBAL().LayDT();
            ThemHoaDon();

            bsNhanVien.ResumeBinding();
            bsHang.ResumeBinding();
            dgvHang.ResumeLayout();

            
        }

        private async void ThemHoaDon()
        {
            HoaDonBAL val = new HoaDonBAL();
            await val.Them(new HoaDon());
            hd = (await val.LayLst()).Last();
            lblHoaDon.Text += hd.ID.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đơn");
        }

        #region MyRegion



        private void txtHang_TextChanged(object sender, EventArgs e)
        {
            if (txtHang.Text != "Nhập chọn hàng")
            {
                if (txtHang.TextLength > 0)
                {
                    bsHang.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [TenHang] LIKE '%{0}%'", txtHang.Text);
                }
                else
                {
                    bsHang.RemoveFilter();
                }
            }
        }

        private void txtHang_Leave(object sender, EventArgs e)
        {
            if (txtHang.TextLength == 0)
            {
                txtHang.Text = "Nhập chọn hàng";
                txtHang.ForeColor = Color.Gray;
            }
        }

        private void txtHang_Enter(object sender, EventArgs e)
        {
            if (txtHang.Text == "Nhập chọn hàng")
            {
                txtHang.Text = "";
                txtHang.ForeColor = Color.Black;
            }
        }

        private void dgvHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CTHD c = new CTHD();
            c.IDHoaDon = hd.ID;
            c.IDHang = Convert.ToInt32(dgvHang.Rows[dgvHang.CurrentCell.RowIndex - 1].Cells["IDHang"].Value);
            frmYeuCauHang f = new frmYeuCauHang(c);
            f.ShowDialog();
        }

        private void dgvHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CTHD c = new CTHD();
                c.IDHoaDon = hd.ID;
                c.IDHang = Convert.ToInt32(dgvHang.Rows[dgvHang.CurrentCell.RowIndex - 1].Cells["IDHang"].Value);
                frmYeuCauHang f = new frmYeuCauHang(c);
                f.ShowDialog();
            }
        }

        #endregion

        // textbox chon hang


        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy đơn này không?","",MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //new HoaDonBAL().Xoa();
            }
        }

        
    }
}
