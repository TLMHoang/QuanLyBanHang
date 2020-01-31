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
    

    public partial class frmDoanhThu : Form
    {
        private class DoanhThu
        {
            public int ID { get; set; }
            public string KHang { get; set; }
            public string NVien { get; set; }
            public int TongChi { get; set; }
            public int Tong { get; set; }
            public DateTime Ngay { get; set; }
        }

        private DateTime TuNgay = DateTime.Now;
        private DateTime DenNgay = DateTime.Now;
        private HoaDonBAL balHoaDon = new HoaDonBAL();
        private CTHDBAL balCTHD = new CTHDBAL();
        private ShipBAL balShip = new ShipBAL();

        private List<DoanhThu> lstDoanhThu = new List<DoanhThu>();


        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {

            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                cbxNam.Items.Add(i);
            }
            cbxNam.Text = DateTime.Now.Year.ToString();

            for (int i = 1; i <= 12; i++)
            {
                cbxThang.Items.Add(i);
            }
            cbxThang.Text = DateTime.Now.Month.ToString();

            radThoiGian_CheckedChanged(null, null);
            dtpNgayBD.Value = dtpNgayKetThuc.Value = TuNgay;
        }

        private int TinhNgay(int Month, int Year)
        {
            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0) ? 29 : 28;
                default:
                    return 30;
            }
        }


        private void radThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            if (radNam.Checked)
            {
                tlpThangNam.Visible = radNam.Checked;
                tlpChonThoiGian.Visible = !tlpThangNam.Visible;

                label2.Visible = false;
                cbxThang.Visible = false;
            }
            if (radThang.Checked)
            {
                tlpThangNam.Visible = radThang.Checked;
                tlpChonThoiGian.Visible = !tlpThangNam.Visible;

                label2.Visible = true;
                cbxThang.Visible = true;
            }
            if (radTuan.Checked)
            {
                tlpChonThoiGian.Visible = radTuan.Checked;
                tlpThangNam.Visible = !tlpChonThoiGian.Visible;

                lblFromTimeLbl.Text = "Chọn ngày:";
                lblToTimeLbl.Visible = false;
                dtpNgayKetThuc.Visible = false;
            }
            if (radThoiGian.Checked)
            {
                tlpChonThoiGian.Visible = radThoiGian.Checked;
                tlpThangNam.Visible = !tlpChonThoiGian.Visible;


                lblFromTimeLbl.Text = "Từ ngày:";
                lblToTimeLbl.Visible = true;
                dtpNgayKetThuc.Visible = true;
            }
        }

        private async void btnViewReport_Click(object sender, EventArgs e)
        {
            int ValTong = 0;
            int ValChi = 0;

            lstDoanhThu.Clear();
            lvDanhSach.Items.Clear();

            if (radNam.Checked)
            {
                TuNgay = new DateTime(Convert.ToInt32(cbxNam.Text), 1, 1, 0, 0, 0);
                DenNgay = new DateTime(Convert.ToInt32(cbxNam.Text), 12, 31, 23, 59, 59);
            }
            if (radThang.Checked)
            {
                TuNgay = new DateTime(Convert.ToInt32(cbxNam.Text), int.Parse(cbxThang.Text), 1, 0, 0, 0);
                DenNgay = new DateTime(Convert.ToInt32(cbxNam.Text), int.Parse(cbxThang.Text), TinhNgay(int.Parse(cbxThang.Text), int.Parse(cbxNam.Text)), 23, 59, 59);
            }
            if (radTuan.Checked)
            {
                DateTime d = DateTime.Now;
                d = new DateTime(dtpNgayBD.Value.Year, dtpNgayBD.Value.Month, dtpNgayBD.Value.Day, 0, 0, 0);

                TuNgay = d.AddDays(-(Convert.ToInt32(d.DayOfWeek) == 0 ? 6 : Convert.ToInt32(d.DayOfWeek) - 1));
                d = TuNgay.AddDays(6);
                DenNgay = new DateTime(d.Year, d.Month, d.Day, 23, 59, 59);//TuNgay.AddDays(6);
            }
            if (radThoiGian.Checked)
            {
                TuNgay = new DateTime(dtpNgayBD.Value.Year, dtpNgayBD.Value.Month, dtpNgayBD.Value.Day, 0, 0, 0);
                DenNgay = new DateTime(dtpNgayKetThuc.Value.Year, dtpNgayKetThuc.Value.Month, dtpNgayKetThuc.Value.Day, 23, 59, 59);
            }
            try
            {
                foreach (DataRow dr in (await balHoaDon.LayDT(TuNgay, DenNgay)).Rows)
                {
                    lstDoanhThu.Add(new DoanhThu()
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        NVien = Convert.IsDBNull(dr["IDNhanVien"]) ? "Không có NV" : Program.lstNhanVien.FirstOrDefault(p => p.ID == Convert.ToInt32(dr["IDNhanVien"])).Ten,
                        KHang = Convert.IsDBNull(dr["IDKhacHang"]) ? "Khách Vãn lai" : Program.lstKhachHang.FirstOrDefault(p => p.ID == Convert.ToInt32(dr["IDKhacHang"])).TenKH,
                        Ngay = Convert.ToDateTime(dr["Ngay"]),
                        TongChi = await TongChi(Convert.ToInt32(dr["ID"])),
                        Tong = await Tong(Convert.ToInt32(dr["ID"]))
                    });
                }

                var lstGroups = lstDoanhThu.GroupBy(p => p.Ngay.Date);

                foreach (var gr in lstGroups)
                {
                    ListViewGroup lvg = new ListViewGroup("lgv_" + gr.Key.Date.ToString("ddMMyyyy"), "Ngày: " + gr.Key.Date.ToString("dd/MMyyyy")) { HeaderAlignment = HorizontalAlignment.Center };

                    foreach (var item in gr)
                    {
                        lvg.Items.Add(new ListViewItem(new string[] { item.ID.ToString(), item.NVien, item.KHang, Program.FormatNumber(item.TongChi.ToString()), Program.FormatNumber(item.Tong.ToString()) }));
                        ValTong += item.Tong;
                        ValChi += item.TongChi;
                    }
                    lvDanhSach.Items.AddRange(lvg.Items);
                    lvDanhSach.Groups.Add(lvg);

                    lblTong.Text = Program.FormatNumber(ValTong.ToString());
                    lblLoiNhuan.Text = Program.FormatNumber(ValChi.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private async Task<int> TongChi(int IDHoaDon)
        {
            int Tong = 0;
            foreach (DataRow ct in (await balCTHD.LayID(IDHoaDon,-1)).Rows)
            {
                Tong += Program.lstHang.FirstOrDefault(p => p.ID == Convert.ToInt32(ct["IDHang"])).GiaNhap;
            }
            Tong += (await balShip.Lay(IDHoaDon)).Tra;
            return Tong;
        }

        private async Task<int> Tong(int IDHoaDon)
        {
            int Tong = 0;
            foreach (DataRow ct in (await balCTHD.LayID(IDHoaDon, -1)).Rows)
            {
                Tong += Program.lstHang.FirstOrDefault(p => p.ID == Convert.ToInt32(ct["IDHang"])).GiaBan;
            }
            Tong += (await balShip.Lay(IDHoaDon)).Nhan;
            return Tong;
        }
    }
}
