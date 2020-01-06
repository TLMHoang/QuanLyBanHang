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
    public class HangBAL :CInterface<Hang>
    {
        HangDAL Val = new HangDAL();
        public async Task<int> CapNhap(Hang obj)
        {
            return await Val.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await Val.Lay();
        }

        public async Task<List<Hang>> LayLst()
        {
            List<Hang> lst = new List<Hang>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new Hang(dr));
            }

            return lst;
        }

        public async Task<int> Them(Hang obj)
        {
            return await Val.Them(obj);
        }

        public async Task<int> Xoa(Hang obj)
        {
            return await Val.Xoa(obj);
        }
    }
}