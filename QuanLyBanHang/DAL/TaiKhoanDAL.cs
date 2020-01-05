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
                "SuaNhanVien",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TKhoan", SqlDbType.VarChar) { Value = obj.TKhoan },
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
                "SuaNhanVien",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TKhoan", SqlDbType.VarChar) { Value = obj.TKhoan },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau },
                new SqlParameter("@Loai", SqlDbType.VarChar) { Value = obj.Loai }
                );
        }

        public async Task<int> Xoa(TaiKhoan obj)
        {
            return await ExecuteNonQuery(
                "SuaNhanVien",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID }
                );
        }

        public async Task<int> DangNhap(string TaiKhoan, string MatKhau)
        {
            return await ExecuteNonQuery(
                "DangNhap",
                new SqlParameter("@TaiKhoan", SqlDbType.VarChar) { Value = TaiKhoan },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = MatKhau }
                );
        }
    }
}
