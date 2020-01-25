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
    public partial class frmThemKhachHang : Form
    {
        private HoaDon hd = new HoaDon();
        public frmThemKhachHang(HoaDon h)
        {
            InitializeComponent();
            hd = h;
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            if (Program.lstKhachHang.Count == 0)
            {
                txtMa.Text = "1";
            }
            else
            {
                txtMa.Text = ((((Program.lstKhachHang.OrderBy(p => p.ID)).Last()).ID) + 1).ToString();
            }
        }

        private bool CheckNotNull()
        {
            if (txtTen.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên.\nVui lòng nhập đủ thông tin");
                return false;
            }
            if (txtSDT.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập SĐT.\nVui lòng nhập đủ thông tin");
                return false;
            }
            if (txtDiaChi.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ.\nVui lòng nhập đủ thông tin");
                return false;
            }

            return true;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckNotNull())
            {
                KhachHang kh = new KhachHang(-1, txtTen.Text, txtSDT.Text, txtDiaChi.Text);
                await new KhachHangBAL().Them(kh);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            string[] s = txtTen.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string Ten = "";
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = s[i].ToLower();
                char[] a = s[i].ToArray();
                a[0] = char.ToUpper(a[0]);
                Ten += new string(a) + " ";
            }
            txtTen.Text = Ten.Trim();
        }
    }
}
