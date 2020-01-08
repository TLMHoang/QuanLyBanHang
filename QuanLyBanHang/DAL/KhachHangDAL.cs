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
    public class KhachHangDAL : SQLHelper, CInterface<KhachHang>
    {
        public async Task<int> CapNhap(KhachHang obj)
        {
            return await ExecuteNonQuery(
                "SuaKhachHang",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TenKH", SqlDbType.NVarChar) { Value = obj.TenKH },
                new SqlParameter("@DiaChi", SqlDbType.NVarChar) { Value = obj.DiaChi },
                new SqlParameter("@SDT", SqlDbType.VarChar) { Value = obj.SDT }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("LayKhachHang");
        }

        public async Task<int> Them(KhachHang obj)
        {
            return await ExecuteNonQuery(
                "ThemKhachHang",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@TenKH", SqlDbType.NVarChar) { Value = obj.TenKH },
                new SqlParameter("@DiaChi", SqlDbType.NVarChar) { Value = obj.DiaChi },
                new SqlParameter("@SDT", SqlDbType.VarChar) { Value = obj.SDT }
                );
        }

        public async Task<int> Xoa(KhachHang obj)
        {
            return await ExecuteNonQuery(
                "XoaKhachHang",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID }
                );
        }

        //public async Task<DataTable> Lay(int ID)
        //{
        //    return await ExecuteQuery("LayKhachHang", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        //}
    }
}
