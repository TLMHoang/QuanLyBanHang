using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL : SQLHelper, CInterface<TaiKhoan>
    {
        public async Task<int> CapNhap(TaiKhoan obj)
        {
            return await ExecuteNonQuery(
                "SuaTaiKhoan",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau },
                new SqlParameter("@Loai", SqlDbType.VarChar) { Value = obj.Loai }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("LayTaiKhoan");
        }

        public async Task<int> Them(TaiKhoan obj)
        {
            return await ExecuteNonQuery(
                "ThemTaiKhoan",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TKhoan", SqlDbType.VarChar) { Value = obj.TKhoan },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau },
                new SqlParameter("@Loai", SqlDbType.VarChar) { Value = obj.Loai }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaTaiKhoan",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                );
        }

        public async Task<DataTable> DangNhap(string TaiKhoan, string MatKhau)
        {
            return await ExecuteQuery(
                "DangNhap",
                new SqlParameter("@TaiKhoan", SqlDbType.VarChar) { Value = TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = MatKhau }
                );
        }

        //public async Task<DataTable> Lay(int ID)
        //{
        //    return await ExecuteQuery("LayTaiKhoan", new SqlParameter("@ID", SqlDbType.Int) { Value = ID});
        //}
    }
}
