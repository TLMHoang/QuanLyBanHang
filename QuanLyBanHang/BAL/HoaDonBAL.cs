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
    public class HoaDonBAL : CInterface<HoaDon>
    {
        HoaDonDAL Val = new HoaDonDAL();
        public async Task<int> CapNhap(HoaDon obj)
        {
            return await Val.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await Val.Lay();
        }

        public async Task<DataTable> LayTT()
        {
            byte TT = 0;
            return await Val.Lay(TT);
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

        public async Task<int> Xoa(HoaDon obj)
        {
            return await Val.Xoa(obj);
        }
    }
}
