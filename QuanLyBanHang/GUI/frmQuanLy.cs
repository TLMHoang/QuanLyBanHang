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
    public partial class frmQuanLy : Form
    {
        HangBAL hang = new HangBAL();
        NhanVienBAL nhanVien = new NhanVienBAL();
        KhachHangBAL khachHang = new KhachHangBAL();
        TaiKhoanBAL taiKhoan = new TaiKhoanBAL();

        public DataTable dt = new DataTable();
        public frmQuanLy()
        {
            InitializeComponent();
            txtFind.Text = "Nhập ID Hoặc Tên Để Tìm";
            txtFind.ForeColor = Color.Gray;
        }

        private async void frmQuanLy_Load(object sender, EventArgs e)
        {

            tcQuanLy.SuspendLayout();

            bsHang.SuspendBinding();
            bsNhanVien.SuspendBinding();
            bsKhachHang.SuspendBinding();
            bsTaiKhoan.SuspendBinding();

            bsHang.DataSource = await hang.LayDT();
            bsKhachHang.DataSource = await khachHang.LayDT();
            bsNhanVien.DataSource = await nhanVien.LayDT();
            bsTaiKhoan.DataSource = await taiKhoan.LayDT();


            bsHang.ResumeBinding();
            bsNhanVien.ResumeBinding();
            bsKhachHang.ResumeBinding();
            bsTaiKhoan.ResumeBinding();

            tcQuanLy.ResumeLayout();
        }

        #region Hang
        private void dgvHang_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            MessageBox.Show("Nhập Sai kiểu dữ liệu cột : " + dgvHang.Columns[dgvHang.CurrentCell.ColumnIndex].HeaderText);
        }

        private async void dgvHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView drv = ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as DataRowView);
            if (drv == null)
            {
                return;
            }

            for (int i = 1; i < drv.Row.ItemArray.Length; i++)
            {
                if (i != 3)
                {
                    if (string.IsNullOrEmpty(drv.Row.ItemArray[i].ToString()))
                    {
                        return;
                    }
                }

            }
            Hang h = new Hang(Convert.ToInt32(drv.Row.ItemArray[0]), drv.Row.ItemArray[1].ToString(), Convert.ToInt32(drv.Row.ItemArray[2]) * 1000, 0, Convert.ToInt32(drv.Row.ItemArray[4]) * 1000, Convert.ToInt32(drv.Row.ItemArray[5]));
            if (h.ID == -1)
            {
                //Add 
                await hang.Them(h);
                bsHang.DataSource = await hang.LayDT();
            }
            else
            {
                //update
                await hang.CapNhap(h);
            }
        }

        private void dgvHang_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dgvHang.Rows[e.Row.Index - 1].Cells[0].Value = -1;

        }

        private async void dgvHang_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Hang h = new Hang((e.Row.DataBoundItem as DataRowView).Row);
                    await hang.Xoa(h);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa nhiều");
                e.Cancel = true;
                //if (MessageBox.Show("Bạn muốn xóa " + (sender as DataGridView).SelectedRows.Count + " dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                //{
                //    for (int i = 0; i < (sender as DataGridView).SelectedRows.Count - 1; i++)
                //    {
                //        Hang h = new Hang((sender as DataGridView).Rows[0]);
                //        await hang.Xoa(h);
                //    }

                //}
                //else
                //{
                //    e.Cancel = true;
                //}
            }
        }
        #endregion


        #region NhanVien
        private void dgvNhanVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Nhập Sai kiểu dữ liệu cột : " + dgvNhanVien.Columns[dgvNhanVien.CurrentCell.ColumnIndex].HeaderText);
        }

        private async void dgvNhanVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView drv = ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as DataRowView);
            if (drv == null)
            {
                return;
            }

            for (int i = 1; i < drv.Row.ItemArray.Length; i++)
            {
                if (string.IsNullOrEmpty(drv.Row.ItemArray[i].ToString()))
                {
                    return;
                }

            }
            NhanVien val = new NhanVien(drv.Row);
            if (val.ID == -1)
            {
                //Add 
                await nhanVien.Them(val);
                bsNhanVien.DataSource = await nhanVien.LayDT();
            }
            else
            {
                //update
                await nhanVien.CapNhap(val);
            }
        }

        private void dgvNhanVien_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dgvNhanVien.Rows[e.Row.Index - 1].Cells[0].Value = -1;
        }

        private async void dgvNhanVien_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    NhanVien val = new NhanVien((e.Row.DataBoundItem as DataRowView).Row);
                    await nhanVien.Xoa(val);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa nhiều");
                e.Cancel = true;
            }
        }
        #endregion

        #region KhachHang

        private async void dgvKhachHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView drv = ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as DataRowView);
            if (drv == null)
            {
                return;
            }

            for (int i = 1; i < drv.Row.ItemArray.Length; i++)
            {
                if (string.IsNullOrEmpty(drv.Row.ItemArray[i].ToString()))
                {
                    return;
                }

            }
            KhachHang val = new KhachHang(drv.Row);
            if (val.ID == -1)
            {
                //Add 
                await khachHang.Them(val);
                bsKhachHang.DataSource = await khachHang.LayDT();
            }
            else
            {
                //update
                await khachHang.CapNhap(val);
            }
        }

        private void dgvKhachHang_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Nhập Sai kiểu dữ liệu cột : " + dgvKhachHang.Columns[dgvHang.CurrentCell.ColumnIndex].HeaderText);
        }

        private void dgvKhachHang_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dgvKhachHang.Rows[e.Row.Index - 1].Cells[0].Value = -1;
        }

        private async void dgvKhachHang_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    KhachHang val = new KhachHang((e.Row.DataBoundItem as DataRowView).Row);
                    await khachHang.Xoa(val);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa nhiều");
                e.Cancel = true;
            }
        }

        #endregion

        #region TaiKhoan

        private async void dgvTaiKhoan_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView drv = ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as DataRowView);
            if (drv == null)
            {
                return;
            }

            for (int i = 1; i < drv.Row.ItemArray.Length; i++)
            {
                if (i != 2)
                {
                    if (string.IsNullOrEmpty(drv.Row.ItemArray[i].ToString()))
                    {
                        return;
                    }
                }

            }
            TaiKhoan val = new TaiKhoan(Convert.ToInt32(drv.Row.ItemArray[0]),drv.Row.ItemArray[1].ToString(), drv.Row.ItemArray[1].ToString(), Convert.ToByte(drv.Row.ItemArray[3]));
            if (val.ID == -1)
            {
                //Add 
                await taiKhoan.Them(val);
                bsTaiKhoan.DataSource = await taiKhoan.LayDT();
            }
            else
            {
                //update
                await taiKhoan.CapNhap(val);
            }
        }

        private void dgvTaiKhoan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Nhập Sai kiểu dữ liệu cột : " + dgvTaiKhoan.Columns[dgvHang.CurrentCell.ColumnIndex].HeaderText);
        }

        private void dgvTaiKhoan_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dgvTaiKhoan.Rows[e.Row.Index - 1].Cells[0].Value = -1;
        }

        private async void dgvTaiKhoan_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    TaiKhoan val = new TaiKhoan((e.Row.DataBoundItem as DataRowView).Row);
                    await taiKhoan.Xoa(val);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa nhiều");
                e.Cancel = true;
            }
        }


        #endregion

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text != "Nhập ID Hoặc Tên Để Tìm")
            {
                if (txtFind.TextLength > 0)
                {
                    bsHang.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [TenHang] LIKE '%{0}%'", txtFind.Text);
                    bsKhachHang.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [TenKH] LIKE '%{0}%'", txtFind.Text);
                    bsNhanVien.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [Ten] LIKE '%{0}%'", txtFind.Text);
                    bsTaiKhoan.Filter = String.Format("CONVERT(ID, System.String)='{0}' OR [TKhoan] LIKE '%{0}%'", txtFind.Text);

                }
                else
                {
                    bsHang.RemoveFilter();
                    bsKhachHang.RemoveFilter();
                    bsNhanVien.RemoveFilter();
                    bsTaiKhoan.RemoveFilter();
                }
            }
            else
            {
                bsHang.RemoveFilter();
                bsKhachHang.RemoveFilter();
                bsNhanVien.RemoveFilter();
                bsTaiKhoan.RemoveFilter();
            }
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            if (txtFind.TextLength == 0)
            {
                txtFind.Text = "Nhập ID Hoặc Tên Để Tìm";
                txtFind.ForeColor = Color.Gray;
            }
        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
            if (txtFind.Text == "Nhập ID Hoặc Tên Để Tìm")
            {
                txtFind.Text = "";
                txtFind.ForeColor = Color.Black;
            }
        }
    }
}
