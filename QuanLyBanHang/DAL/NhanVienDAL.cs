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
    public class NhanVienDAL : SQLHelper, CInterface<NhanVien>
    {
        public async Task<int> CapNhap(NhanVien obj)
        {
            return await ExecuteNonQuery(
                "SuaNhanVien",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = obj.Ten }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("LayNhanVien");
        }

        public async Task<int> Them(NhanVien obj)
        {
            return await ExecuteNonQuery(
                "ThemNhanVien",
                new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID },
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = obj.Ten }
                );
        }

        public async Task<int> Xoa(NhanVien obj)
        {
            return await ExecuteNonQuery(
                 "XoaNhanVien",
                 new SqlParameter("@ID", SqlDbType.Int) { Value = obj.ID }
                 );
        }
    }
}
