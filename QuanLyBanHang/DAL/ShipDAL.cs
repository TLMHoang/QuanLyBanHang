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
    public class ShipDAL : SQLHelper, CInterface<Ship>
    {
        public async Task<int> CapNhap(Ship obj)
        {
            return await ExecuteNonQuery(
                "SuaShip",
                new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = obj.IDHoaDon },
                new SqlParameter("@Nhan", SqlDbType.Int) { Value = obj.Nhan },
                new SqlParameter("@Tra", SqlDbType.Int) { Value = obj.Tra }
                );
        }

        public Task<DataTable> Lay()
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> Lay(int IDHoaDon)
        {
            return ExecuteQuery(
                "LayShip",
                new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = IDHoaDon }
                );
        }

        public Task<int> Them(Ship obj)
        {
            return ExecuteNonQuery(
                "ThemShip",
                new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = obj.IDHoaDon },
                new SqlParameter("@Nhan", SqlDbType.Int) { Value = obj.Nhan },
                new SqlParameter("@Tra", SqlDbType.Int) { Value = obj.Tra }
                );
        }

        public Task<int> Xoa(int ID)
        {
            return ExecuteNonQuery(
                "XoaShip",
                new SqlParameter("@IDHang", SqlDbType.Int) { Value = ID }
                );
        }
    }
}
