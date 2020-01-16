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
                new SqlParameter("@GiaBan", SqlDbType.NVarChar) { Value = obj.GiaBan },
                new SqlParameter("@GiaNhap", SqlDbType.NVarChar) { Value = obj.GiaNhap },
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
                new SqlParameter("@GiaBan", SqlDbType.NVarChar) { Value = obj.GiaBan },
                new SqlParameter("@GiaNhap", SqlDbType.NVarChar) { Value = obj.GiaNhap },
                new SqlParameter("@SoLuong", SqlDbType.Int) { Value = obj.SoLuong }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaHang",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                );
        }

        //public async Task<DataTable> Lay(int ID)
        //{
        //    return await ExecuteQuery("LayHang", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        //}
    }
}
