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
    public class CTHDDAL : SQLHelper, CInterface<CTHD>
    {
        public async Task<int> CapNhap(CTHD obj)
        {
            
            return await ExecuteNonQuery(
                "SuaCTHD",
                new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = obj.IDHoaDon },
                new SqlParameter("@IDHang", SqlDbType.Int) { Value = obj.IDHang },
                new SqlParameter("@SoLuong", SqlDbType.Int) { Value = obj.SoLuong },
                new SqlParameter("@Tang", SqlDbType.Bit) { Value = obj.Tang },
                new SqlParameter("@GiaSi", SqlDbType.Int) { Value = obj.GiaSi}
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("LayCTHD");
        }

        public async Task<DataTable> Lay(int IDHoaDon, int IDHang)
        {
            return await ExecuteQuery(
                "LayCTHDID",
                new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = IDHoaDon },
                new SqlParameter("@IDHang", SqlDbType.Int) { Value = IDHang}
                );
        }

        public async Task<DataTable> Lay(int IDHoaDon, int IDHang, byte Tang)
        {
            return await ExecuteQuery(
                "LayCTHDCheck",
                new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = IDHoaDon },
                new SqlParameter("@IDHang", SqlDbType.Int) { Value = IDHang },
                new SqlParameter("@Tang", SqlDbType.Bit) { Value = Tang}
                );
        }

        public async Task<int> Them(CTHD obj)
        {
            return await ExecuteNonQuery(
                "ThemCTHD",
                new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = obj.IDHoaDon },
                new SqlParameter("@IDHang", SqlDbType.Int) { Value = obj.IDHang },
                new SqlParameter("@SoLuong", SqlDbType.Int) { Value = obj.SoLuong },
                new SqlParameter("@Tang", SqlDbType.Bit) { Value = obj.Tang },
                new SqlParameter("@GiaSi", SqlDbType.Int) { Value = obj.GiaSi }
                );
        }

        public Task<int> Xoa(int IDHoaDon)
        {
            throw new NotImplementedException();
            //    return await ExecuteNonQuery(
            //        "XoaCTHD",
            //        new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = IDHoaDon }
            //        );
        }
        public async Task<int> Xoa(int IDHoaDon, int IDHang, byte Tang)
        {
            return await ExecuteNonQuery(
                "XoaCTHD",
                new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = IDHoaDon },
                new SqlParameter("@IDHang", SqlDbType.Int) { Value = IDHang},
                new SqlParameter("@Tang", SqlDbType.Bit) { Value = Tang}
                );
        }

        public async Task<int> Xoa(CTHD obj)
        {
            return await ExecuteNonQuery(
                "XoaCTHD",
                new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = obj.IDHoaDon },
                new SqlParameter("@IDHang", SqlDbType.Int) { Value = obj.IDHang },
                new SqlParameter("@Tang", SqlDbType.Bit) { Value = obj.Tang }
                );
        }

        //public async Task<DataTable> Lay(int ID)
        //{
        //    return await ExecuteQuery("LayCTHD", new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = ID });
        //}
    }
}
