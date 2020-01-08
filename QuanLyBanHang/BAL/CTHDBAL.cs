using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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

        //public async Task<CTHD> LayID(int ID)
        //{
        //    return new CTHD((await Val.Lay(ID)).Rows[0]);
        //}

        public async Task<List<CTHD>> LayLst()
        {
            List<CTHD> lst = new List<CTHD>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new CTHD(dr));
            }

            return lst;
        }

        public async Task<int> Them(CTHD obj)
        {
            return await Val.Them(obj);
        }

        public async Task<int> Xoa(CTHD obj)
        {
            return await Val.Xoa(obj);
        }
    }
}
