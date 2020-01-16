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
    public class HoaDonDAL : SQLHelper, CInterface<HoaDon>
    {
        public async Task<int> CapNhap(HoaDon obj)
        {
            return await ExecuteNonQuery(
                "SuaHoaDon",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@IDKhachHang", SqlDbType.Int) { Value = obj.IDKhachHang },
                new SqlParameter("@IDNhanVien", SqlDbType.Int) { Value = obj.IDNhanVien },
                new SqlParameter("@Ngay", SqlDbType.DateTime) { Value = obj.Ngay },
                new SqlParameter("@TinhTrang", SqlDbType.Bit) { Value = obj.TinhTrang }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("LayHoaDon");
        }

        public async Task<DataTable> Lay(byte TT)
        {
            return await ExecuteQuery("LayHoaDon", new SqlParameter("@TinhTrang", SqlDbType.Bit) { Value = TT });
        }

        public async Task<int> Them(HoaDon obj)
        {
            return await ExecuteNonQuery(
                "ThemHoaDon",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@IDKhachHang", SqlDbType.Int) { Value = obj.IDKhachHang },
                new SqlParameter("@IDNhanVien", SqlDbType.Int) { Value = obj.IDNhanVien },
                new SqlParameter("@Ngay", SqlDbType.DateTime) { Value = obj.Ngay }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaHoaDon",
                new SqlParameter("@ID", SqlDbType.Int) { Value = ID }
                );
        }

        //public async Task<DataTable> Lay(int ID)
        //{
        //    return await ExecuteQuery("LayHoaDon", new SqlParameter("@ID", SqlDbType.Int) { Value = ID });
        //}
    }
}
