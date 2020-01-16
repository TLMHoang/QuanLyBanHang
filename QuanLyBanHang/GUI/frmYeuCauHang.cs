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
        public frmYeuCauHang()
        {
            InitializeComponent();
        }

        public frmYeuCauHang(CTHD ct)
        {
            InitializeComponent();

            c.IDHang = ct.IDHang;
            c.IDHoaDon = ct.IDHoaDon;
            c.SoLuong = ct.SoLuong;
            c.Tang = ct.Tang;
            c.GiaSi = ct.GiaSi;
        }

        private async Task<bool> Check()
        {
            DataTable dt = (await new CTHDBAL().LayID(c.IDHang, c.IDHoaDon));
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
    }
}
