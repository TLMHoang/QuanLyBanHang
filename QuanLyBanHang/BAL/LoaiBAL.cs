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
    public class LoaiBAL : CInterface<Loai>
    {
        LoaiDAL Val = new LoaiDAL();
        public async Task<int> CapNhap(Loai obj)
        {
            return await Val.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await Val.Lay();
        }

        public async Task<List<Loai>> LayLst()
        {
            List<Loai> lst = new List<Loai>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new Loai(dr));
            }

            return lst;
        }

        public async Task<int> Them(Loai obj)
        {
            return await Val.Them(obj);
        }

        public async Task<int> Xoa(Loai obj)
        {
            return await Val.Xoa(obj);
        }
    }
}
