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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           
        }

        private async void frmMenu_Load(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            if (f.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
            await LoadDataALL();
            bsHang.DataSource = Program.lstHang.Where(p => p.SoLuong <= 5);
        }

        public async Task<int> LoadDataALL()
        {
            Program.lstHang = await new HangBAL().LayLst();
            Program.DTHang = await new HangBAL().LayDT();

            return -1;
        }

        private void thoátỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormClosing += frmMain_FormClosing;
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !(MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes);
            this.FormClosing -= frmMain_FormClosing;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            this.Visible = false;
            if (f.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;

            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();

            f.ShowDialog();
        }

        private async void btnQuanLy_Click(object sender, EventArgs e)
        {
            frmQuanLy f = new frmQuanLy();
            f.ShowDialog();
            Program.lstHang = await new HangBAL().LayLst(Program.DTHang);
            bsHang.DataSource = Program.lstHang.Where(p => p.SoLuong <= 5);
        }

        private async void BtnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang f = new frmNhapHang();
            f.ShowDialog();
            Program.lstHang = await new HangBAL().LayLst(Program.DTHang);
            bsHang.DataSource = Program.lstHang.Where(p => p.SoLuong <= 5);
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            frmTaoDonHang f = new frmTaoDonHang();
            f.ShowDialog();
        }
    }
}
