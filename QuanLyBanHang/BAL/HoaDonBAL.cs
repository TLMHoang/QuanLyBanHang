﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class HoaDonBAL : CInterface<HoaDon>
    {
        HoaDonDAL Val = new HoaDonDAL();
        public async Task<int> CapNhap(HoaDon obj)
        {
            return await Val.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await Val.Lay(-1);
        }

        public async Task<DataTable> LayDT(int ID)
        {
            return await Val.Lay(ID);
        }

        public async Task<DataTable> LayDT(DateTime dateFrom, DateTime dateTo)
        {
            return await Val.Lay(dateFrom,dateTo);
        }

        public async Task<DataTable> LayDT(DateTime dateFrom, DateTime dateTo, byte TT)
        {
            return await Val.Lay(dateFrom, dateTo, TT);
        }

        public async Task<List<HoaDon>> LayLst()
        {
            List<HoaDon> lst = new List<HoaDon>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new HoaDon(dr));
            }

            return lst;
        }

        public async Task<int> Them(HoaDon obj)
        {
            return await Val.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await Val.Xoa(ID);
        }
    }
}
