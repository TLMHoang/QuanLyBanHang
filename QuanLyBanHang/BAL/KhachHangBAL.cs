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
    public class KhachHangBAL : CInterface<KhachHang>
    {
        KhachHangDAL Val = new KhachHangDAL();
        public async Task<int> CapNhap(KhachHang obj)
        {
            return await Val.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await Val.Lay();
        }

        //public async Task<KhachHang> LayID(int ID)
        //{
        //    return new KhachHang((await Val.Lay(ID)).Rows[0]);
        //}

        public async Task<List<KhachHang>> LayLst()
        {
            List<KhachHang> lst = new List<KhachHang>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new KhachHang(dr));
            }

            return lst;
        }

        public async Task<int> Them(KhachHang obj)
        {
            return await Val.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await Val.Xoa(ID);
        }
    }
}
