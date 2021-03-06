﻿using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BAL
{
    public class CTHDBAL : CInterface<CTHD>
    {
        CTHDDAL Val = new CTHDDAL();
        public async Task<int> CapNhap(CTHD obj)
        {
            return await Val.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await Val.Lay();
        }

        public async Task<DataTable> LayID(int IDHoaDon, int IDHang)
        {
            return await Val.Lay(IDHoaDon, IDHang);
        }

        public async Task<DataTable> LayID(int IDHoaDon, int IDHang, byte Tang)
        {
            return await Val.Lay(IDHoaDon, IDHang, Tang);
        }

        public async Task<List<CTHD>> LayLst()
        {
            List<CTHD> lst = new List<CTHD>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new CTHD(dr));
            }

            return lst;
        }

        public async Task<List<CTHD>> LayLst(int IDHoaDon)
        {
            List<CTHD> lst = new List<CTHD>();
            foreach (DataRow dr in (await Val.Lay(IDHoaDon, -1)).Rows)
            {
                lst.Add(new CTHD(dr));
            }

            return lst;
        }

        public async Task<int> Them(CTHD obj)
        {
            return await Val.Them(obj);
        }

        //public async Task<int> Xoa(int IDHoaDon)
        //{
        //    return await Val.Xoa(IDHoaDon);
        //}

        public async Task<int> Xoa(int IDHoaDon, int IDHang, byte Tang)
        {
            return await Val.Xoa(IDHoaDon, IDHang, Tang);
        }

        public async Task<int> Xoa(CTHD obj)
        {
            return await Val.Xoa(obj);
        }

        public Task<int> Xoa(int ID)
        {
            throw new System.NotImplementedException();
        }
    }
}
