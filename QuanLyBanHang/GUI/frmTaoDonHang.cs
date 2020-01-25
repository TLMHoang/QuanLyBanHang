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
        private KhachHang kh = new KhachHang();

        private BindingSource bs = new BindingSource();
        private HoaDonBAL balHD = new HoaDonBAL();
        private ShipBAL balShip = new ShipBAL();
        private CTHDBAL balCTHD = new CTHDBAL();
        public frmTaoDonHange()
        {
            InitializeComponent();
            if (hd.ID == -1)
            {
                ThemHoaDon();
            }
        }

        private async void frmTaoDonHang_Load(object sender, EventArgs e)
        {
            dgvHang.SuspendLayout();
            bsHang.SuspendBinding();

            bsHang.DataSource = await new HangBAL().LayDT();
            foreach (NhanVien item in Program.lstNhanVien)
            {
                cbxNhanVien.Items.Add(item.Ten);
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
            await MoChonSoLuong(dgvHang.CurrentCell.RowIndex);
            //CTHD c = new CTHD();
            //c.IDHoaDon = hd.ID;
            //c.IDHang = Convert.ToInt32(dgvHang.Rows[dgvHang.CurrentCell.RowIndex].Cells["IDHang"].Value);
            //Hang h = Program.lstHang.FirstOrDefault(p => p.ID == c.IDHang);
            //frmYeuCauHang f = new frmYeuCauHang(c, chbGiaSi.Checked, h.ID);
            //f.Text = h.TenHang;
            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    txtHang.Text = "";
            //    txtHang.Focus();
            //    await CapNhap();
            //}
        }

        private async void dgvHang_KeyUp(object sender, KeyEventArgs e) // keydown not keyup lười chưa đổi lại
        {
            if (e.KeyCode == Keys.Enter)
            {
                await MoChonSoLuong(dgvHang.CurrentCell.RowIndex);
                //CTHD c = new CTHD();
                //c.IDHoaDon = hd.ID;
                //c.IDHang = Convert.ToInt32(dgvHang.Rows[dgvHang.CurrentCell.RowIndex].Cells["IDHang"].Value);
                //Hang h = Program.lstHang.FirstOrDefault(p => p.ID == c.IDHang);
                //frmYeuCauHang f = new frmYeuCauHang(c, chbGiaSi.Checked, h.ID);
                //f.Text = h.TenHang;
                //if (f.ShowDialog() == DialogResult.OK)
                //{
                //    txtHang.Text = "";
                //    txtHang.Focus();
                //    await CapNhap();

                //}

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
            bsHang.DataSource = await new HangBAL().LayDT();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtHang.Text = "";
            txtHang_Leave(null,null);
        }

        private async void txtHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await MoChonSoLuong(0);
            }
            else
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    dgvHang.Focus();
                }
            }
        }

        private async Task MoChonSoLuong(int RowSelect)
        {
            CTHD c = new CTHD();
            c.IDHoaDon = hd.ID;
            c.IDHang = Convert.ToInt32(dgvHang.Rows[RowSelect].Cells["IDHang"].Value);
            Hang h = Program.lstHang.FirstOrDefault(p => p.ID == c.IDHang);
            frmYeuCauHang f = new frmYeuCauHang(c, chbGiaSi.Checked, h.ID);
            f.Text = h.TenHang;
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtHang.Text = "";
                txtHang.Focus();
                await CapNhap();
            }
        }

        #endregion




        private void btnHuy_Click(object sender, EventArgs e) // tao moi hoa don + huy don
        {
            if (btnLuu.Text == "Hủy")
            {
                if (MessageBox.Show("Bạn có muốn hủy đơn này không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //new HoaDonBAL().Xoa();
                }
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn tạo đơn mới?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bs.Clear();
                    txtHang.Text = "";
                    txtHang_Leave(null, null);
                    cbxNhanVien.Text = "";
                    chbGiaSi.Checked = false;
                    kh = new KhachHang();
                    ThemHoaDon();
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
                txtTra.Text = Program.FormatNumber(Program.UnFormatNumber(txtTra.Text).ToString());
            }
            if (txtNhan.Text == "")
            {
                txtNhan.Text = "0";
            }
            else
            {
                txtNhan.Text = Program.FormatNumber(Program.UnFormatNumber(txtNhan.Text).ToString());
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

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang(hd);
            DialogResult result = f.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    Program.dtKhachHang = await new KhachHangBAL().LayDT();
                    Program.lstKhachHang = await new KhachHangBAL().LayLst(Program.dtKhachHang);
                    hd = new HoaDon((await balHD.LayDT(hd.ID)).Rows[0]);
                    kh = Program.lstKhachHang.FirstOrDefault(p => p.ID == hd.IDKhachHang);
                    lblKhachHang.Text += "\n" + kh.TenKH;
                    break;
                case DialogResult.Yes:
                    hd = new HoaDon((await balHD.LayDT(hd.ID)).Rows[0]);
                    kh = Program.lstKhachHang.FirstOrDefault(p => p.ID == hd.IDKhachHang);
                    lblKhachHang.Text += "\n" + kh.TenKH;
                    break;
                default:
                    lblKhachHang.Text = "Tên Khách Hàng: ";
                    break;
            }
            
        }

        private async void dgvDanhSachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dt = (DataGridView)sender;

            if (dt.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (dt.Columns[e.ColumnIndex].Name.Equals("Sua"))
                {
                    // click sửa here
                    frmYeuCauHang f = new frmYeuCauHang(new CTHD((await balCTHD.LayID(hd.ID, Convert.ToInt32(dt.Rows[e.RowIndex].Cells["ID"].Value))).Rows[0]),
                        chbGiaSi.Checked,
                        Convert.ToInt32(dt.Rows[e.RowIndex].Cells["ID"].Value));

                    f.Text = dt.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        await CapNhap();
                    }
                }
                else if (dt.Columns[e.ColumnIndex].Name.Equals("Xoa"))
                {
                    // click xoa here
                    if (MessageBox.Show("Bạn có muốn xóa hàng này đi không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await balCTHD.Xoa(hd.ID, Convert.ToInt32(dt.Rows[e.RowIndex].Cells["ID"].Value), (Program.UnFormatNumber(dt.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString()) == 0) ? Convert.ToByte(true) : Convert.ToByte(false));
                        await CapNhap();
                    }
                }
            }
        }

        private async void btnXoaDon_Click(object sender, EventArgs e)
        {
            List<CTHD> lst = await balCTHD.LayLst(hd.ID);
            foreach (CTHD item in lst)
            {
                await balCTHD.Xoa(item);
            }

            await CapNhap();
            txtHang.Text = "";
            txtHang_Leave(null, null);
        }

        private async void frmTaoDonHange_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvDanhSachHang.Rows.Count == 0)
            {
                await balHD.Xoa(hd.ID);
            }
        }
    }
}