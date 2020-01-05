﻿using DTO;
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
                new SqlParameter("@SoLuong", SqlDbType.Int) { Value = obj.SoLuong }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("LayCTHD");
        }

        public async Task<int> Them(CTHD obj)
        {
            return await ExecuteNonQuery(
                "ThemCTHD",
                new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = obj.IDHoaDon },
                new SqlParameter("@IDHang", SqlDbType.Int) { Value = obj.IDHang },
                new SqlParameter("@SoLuong", SqlDbType.Int) { Value = obj.SoLuong }
                );
        }

        public async Task<int> Xoa(CTHD obj)
        {
            return await ExecuteNonQuery(
                "XoaCTHD",
                new SqlParameter("@IDHoaDon", SqlDbType.Int) { Value = obj.IDHoaDon }
                );
        }
    }
}