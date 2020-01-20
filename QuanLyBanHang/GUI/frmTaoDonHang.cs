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
    public partial class frmTaoDonHange : Form
    {
        private class CTHang
        {
            public int IDHang { get; set; }
            public string TenHang { get; set; }
            public int SL { get; set; }
            public string ThanhTien { get; set; }
        }

        private HoaDon hd = new HoaDon();
        private Ship s = new Ship();
        private BindingSource bs = new BindingSource();
        private HoaDonBAL balHD = new HoaDonBAL();
        private ShipBAL balShip = new ShipBAL();
        private CTHDBAL balCTHD = new CTHDBAL();
        public frmTaoDonHange()
        {
            InitializeComponent();
        }

        private async void frmTaoDonHang_Load(object sender, EventArgs e)
        {
            dgvHang.SuspendLayout();
            bsHang.SuspendBinding();

            bsHang.DataSource = await new HangBAL().LayDT();

            if (hd.ID == -1)
            {
                ThemHoaDon();
            }

            bsHang.ResumeBinding();
            dgvHang.ResumeLayout();


            dgvDanhSachHang.DataSource = bs;
        }

        private async void ThemHoaDon()
        {
            
            await balHD.Them(new HoaDon());
            hd = ((await balHD.LayLst()).OrderBy(p => p.ID)).Last();
            s.IDHoaDon = hd.ID;
            await balShip.Them(s);
            txtNhan.Text = Program.FormatNumber(s.Nhan.ToString());
            txtTra.Text = Program.FormatNumber(s.Tra.ToString());
        }

        #region textbox chon hang
        
        private void txtHang_TextChanged(object sender, EventArgs e)
        {
            if (txtHang.TextLength == 0 || txtHang.Text == "Nhập chọn hàng")
            {
                bsHang.RemoveFilter();
            }
            else
            {
                bsHang.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [TenHang] LIKE '%{0}%'", txtHang.Text);
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

        private async void dgvHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CTHD c = new CTHD();
            c.IDHoaDon = hd.ID;
            c.IDHang = Convert.ToInt32(dgvHang.Rows[dgvHang.CurrentCell.RowIndex].Cells["IDHang"].Value);
            Hang h = Program.lstHang.FirstOrDefault(p => p.ID == c.IDHang);
            frmYeuCauHang f = new frmYeuCauHang(c, chbGiaSi.Checked, h.GiaBan, h.SoLuong);
            f.Text = h.TenHang;
            if (f.ShowDialog() == DialogResult.OK)
            {
                await CapNhap();
            }
        }

        private async void dgvHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CTHD c = new CTHD();
                c.IDHoaDon = hd.ID;
                c.IDHang = Convert.ToInt32(dgvHang.Rows[dgvHang.CurrentCell.RowIndex].Cells["IDHang"].Value);
                Hang h = Program.lstHang.FirstOrDefault(p => p.ID == c.IDHang);
                frmYeuCauHang f = new frmYeuCauHang(c, chbGiaSi.Checked, h.GiaBan, h.SoLuong);
                f.Text = h.TenHang;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    await CapNhap();
                }

            }
        }

        private async Task<List<CTHang>> CTHangs()
        {
            return (await new CTHDBAL().LayLst(hd.ID)).Join(
                Program.lstHang,
                o => o.IDHang,
                m => m.ID,
                (o, m) => new CTHang()
                {
                    IDHang = o.IDHang,
                    TenHang = m.TenHang,
                    SL = o.SoLuong,
                    ThanhTien = Program.FormatNumber((((o.GiaSi != -1) ? o.GiaSi : (o.Tang == 0) ? m.GiaBan : 0) * o.SoLuong).ToString())
                }
                ).ToList();
        }

        private async Task CapNhap()
        {
            List<CTHang> lst = await CTHangs();
            lblThanhTien.Text = "0";

            bs.DataSource = lst;
            foreach (CTHang item in lst)
            {
                lblThanhTien.Text = (Convert.ToInt32(lblThanhTien.Text) + Program.UnFormatNumber(item.ThanhTien)).ToString();
            }
            lblThanhTien.Text = Program.FormatNumber(lblThanhTien.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtHang.Text = "";
            txtHang_Leave(null,null);
        }

        #endregion

        


        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text == "Hủy")
            {
                if (MessageBox.Show("Bạn có muốn hủy đơn này không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //new HoaDonBAL().Xoa();
                }
            }
            
        }


        #region Ship

        private async void txtTra_Leave(object sender, EventArgs e)
        {
            if (txtTra.Text == "")
            {
                txtTra.Text = Program.FormatNumber("35000");
            }
            else
            {
                txtTra.Text = Program.FormatNumber(s.Tra.ToString());
            }
            if (txtNhan.Text == "")
            {
                txtNhan.Text = "0";
            }
            else
            {
                txtNhan.Text = Program.FormatNumber(s.Nhan.ToString());
            }
            s.Nhan = Program.UnFormatNumber(txtNhan.Text);
            s.Tra = Program.UnFormatNumber(txtTra.Text);
            await balShip.CapNhap(s);
        }

        private void txtNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        #endregion


        private async void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachHang.Rows.Count == 0)
            {
                if (MessageBox.Show("Chưa có sản phẩm bán đi. Bạn muốn xóa đơn ?\nYES để xóa đơn.\nNO để tiếp tục sửa hóa đơn","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes);
                {
                    await balHD.Xoa(hd.ID);
                }
            }
            else
            {
                hd.TinhTrang = 1;
                await balHD.CapNhap(hd);
            }     
            if (MessageBox.Show("Bạn có muốn tiếp tục tạo đơn không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Tạo đơn mới");
            }
            else
            {
                this.Close();
            }
        }

        private async void btnTroLai_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachHang.Rows.Count == 0)
            {
                await balHD.Xoa(hd.ID);
            }
            else
            {
                this.Close();
            }
        }
    }
}
