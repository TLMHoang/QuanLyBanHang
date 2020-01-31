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
    public partial class frmChon : Form
    {
        private class HoaDonHoan
        {
            private int ID { get; set; }
            private int IDKH { get; set; }
            private string SDT { get; set; }
            private string TongTien { get; set; }
            private DateTime Ngay { get; set; }
        }

        private class ChotHoaDon
        {
            private int ID { get; set; }
            private int IDKH { get; set; }
            private DateTime Ngay { get; set; }
        }

        HoaDonBAL balHD = new HoaDonBAL();

        public frmChon()
        {
            InitializeComponent();
        }

        private async void frmChon_Load(object sender, EventArgs e)
        {
            dtpNgayBD.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtpNgayKetThuc.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            bsHoanThanh.SuspendBinding();

            bsHoanThanh.DataSource = await balHD.LayDT(dtpNgayBD.Value, dtpNgayKetThuc.Value, Convert.ToByte(0));

            bsHoanThanh.ResumeBinding();
        }

        private async Task LoadBS()
        {

        }

        private void radThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            if (radNam.Checked)
            {
                tlpChonThoiGian.Enabled = radThoiGian.Checked;

            }
        }

        private async void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            bsHoanThanh.DataSource = await balHD.LayDT(dtpNgayBD.Value, dtpNgayKetThuc.Value, Convert.ToByte(0));
        }

        private async void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            bsHoanThanh.DataSource = await balHD.LayDT(dtpNgayBD.Value, dtpNgayKetThuc.Value, Convert.ToByte(0));
        }

        private async void dgvHoanThanh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HoaDon hd = new HoaDon();
            int a = dgvHoanThanh.Rows.Count;

            hd.ID = Convert.ToInt32(dgvHoanThanh.Rows[e.RowIndex].Cells[0].Value);

            if (Convert.IsDBNull(dgvHoanThanh.Rows[e.RowIndex].Cells[1].Value))
            {
                hd.IDKhachHang = -1;
            }
            hd.IDKhachHang = Convert.IsDBNull(dgvHoanThanh.Rows[e.RowIndex].Cells[1].Value) ? -1 : Convert.ToInt32(dgvHoanThanh.Rows[e.RowIndex].Cells[1].Value) == 0 ? -1 : Convert.ToInt32(dgvHoanThanh.Rows[e.RowIndex].Cells[1].Value);
            hd.IDNhanVien = Convert.IsDBNull(dgvHoanThanh.Rows[e.RowIndex].Cells[2].Value) ? -1 : Convert.ToInt32(dgvHoanThanh.Rows[e.RowIndex].Cells[2].Value) == 0 ? -1 : Convert.ToInt32(dgvHoanThanh.Rows[e.RowIndex].Cells[2].Value);
            hd.Ngay = Convert.ToDateTime(dgvHoanThanh.Rows[e.RowIndex].Cells[3].Value);
            hd.TinhTrang = Convert.ToByte(true);

            await balHD.CapNhap(hd);
            bsHoanThanh.DataSource = await balHD.LayDT(dtpNgayBD.Value, dtpNgayKetThuc.Value, Convert.ToByte(0));
            
            if (a <= dgvHoanThanh.Rows.Count)
            {
                MessageBox.Show("Hoàn thành đơn không thành công.\nVui lòng thử lại.\nNếu vẫn tiếp tục lỗi xin thông báo cho kỹ thuật viên.");
            }
        }
    }
}
