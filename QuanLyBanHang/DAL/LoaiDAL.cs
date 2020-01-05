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
    public class LoaiDAL : SQLHelper, CInterface<Loai>
    {
        public async Task<int> CapNhap(Loai obj)
        {
            return await ExecuteNonQuery(
                "SuaKhachHang",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TenLoai", SqlDbType.NVarChar) { Value = obj.TenLoai }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("LayLoai");
        }

        public async Task<int> Them(Loai obj)
        {
            return await ExecuteNonQuery(
                "ThemLoai",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TenLoai", SqlDbType.NVarChar) { Value = obj.TenLoai }
                );
        }

        public async Task<int> Xoa(Loai obj)
        {
            return await ExecuteNonQuery(
                "SuaKhachHang",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID }
                );
        }
    }
}
