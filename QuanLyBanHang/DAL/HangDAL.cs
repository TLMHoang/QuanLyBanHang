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
    public class HangDAL : SQLHelper, CInterface<Hang>
    {
        public async Task<int> CapNhap(Hang obj)
        {
            return await ExecuteNonQuery(
                "SuaHang",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TenHang", SqlDbType.NVarChar) { Value = obj.TenHang },
                new SqlParameter("@GiaHang", SqlDbType.NVarChar) { Value = obj.GiaHang },
                new SqlParameter("@IDLoai", SqlDbType.NVarChar) { Value = obj.IDLoai },
                new SqlParameter("@SoLuong", SqlDbType.Int) { Value = obj.SoLuong }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("LayHang");
        }

        public async Task<int> Them(Hang obj)
        {
            return await ExecuteNonQuery(
                "ThemHang",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TenHang", SqlDbType.NVarChar) { Value = obj.TenHang },
                new SqlParameter("@GiaHang", SqlDbType.NVarChar) { Value = obj.GiaHang },
                new SqlParameter("@IDLoai", SqlDbType.NVarChar) { Value = obj.IDLoai },
                new SqlParameter("@SoLuong", SqlDbType.Int) { Value = obj.SoLuong }
                );
        }

        public async Task<int> Xoa(Hang obj)
        {
            return await ExecuteNonQuery(
                "XoaHang",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID }
                );
        }
    }
}
