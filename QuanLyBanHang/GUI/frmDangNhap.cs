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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmDangNhap_FormClosing;
            
            if (txtTaiKhoan.TextLength == 0)
            {
                MessageBox.Show("Nhập Tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtMatKhau.TextLength == 0)
                {
                    MessageBox.Show("Nhập Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<TaiKhoan> lst = new List<TaiKhoan>();
                    lst = await new TaiKhoanBAL().DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
                    if (lst.Count == 1)
                    {
                        DialogResult = DialogResult.OK;
                        Program.TK = lst[0];

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc Mật khẩu không chính xác.\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.FormClosing += frmDangNhap_FormClosing;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !(MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes);
            this.FormClosing -= frmDangNhap_FormClosing;
        }
    }
}
