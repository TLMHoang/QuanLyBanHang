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
    public class TaiKhoanBAL : CInterface<TaiKhoan>
    {
        TaiKhoanDAL Val = new TaiKhoanDAL();
        public async Task<int> CapNhap(TaiKhoan obj)
        {
            return await Val.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await Val.Lay();
        }

        public async Task<List<TaiKhoan>> LayLst()
        {
            List<TaiKhoan> lst = new List<TaiKhoan>();
            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new TaiKhoan(dr));
            }

            return lst;
        }

        public async Task<int> Them(TaiKhoan obj)
        {
            return await Val.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await Val.Xoa(ID);
        }

        public async Task<List<TaiKhoan>> DangNhap(string TaiKhoan, string MatKhau)
        {
            List<TaiKhoan> lst = new List<TaiKhoan>();
            foreach (DataRow item in (await Val.DangNhap(TaiKhoan, MatKhau)).Rows)
            {
                lst.Add(new TaiKhoan(item));
            }
            return lst;
        }

        //public async Task<TaiKhoan> LayID(int ID)
        //{
        //    return new TaiKhoan((await Val.Lay(ID)).Rows[0]);
        //}

    }
}
