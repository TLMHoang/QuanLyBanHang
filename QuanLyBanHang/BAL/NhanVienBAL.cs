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
    public class NhanVienBAL : CInterface<NhanVien>
    {
        NhanVienDAL Val = new NhanVienDAL();
        public async Task<int> CapNhap(NhanVien obj)
        {
            return await Val.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await Val.Lay();
        }

        //public async Task<NhanVien> LayID(int ID)
        //{
        //    return new NhanVien((await Val.Lay(ID)).Rows[0]);
        //}

        public async Task<List<NhanVien>> LayLst()
        {
            List<NhanVien> lst = new List<NhanVien>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new NhanVien(dr));
            }

            return lst;
        }

        public async Task<int> Them(NhanVien obj)
        {
            return await Val.Them(obj);
        }

        public async Task<int> Xoa(NhanVien obj)
        {
            return await Val.Xoa(obj);
        }
    }
}
