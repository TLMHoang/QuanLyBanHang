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
    public class TaiKhoanBLL : CInterface<TaiKhoan>
    {
        TaiKhoanDAL Val = new TaiKhoanDAL();
        public Task<int> CapNhap(TaiKhoan obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<TaiKhoan>> LayLst()
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(TaiKhoan obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(TaiKhoan obj)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DangNhap(string TaiKhoan, string MatKhau)
        {
            if (await Val.DangNhap(TaiKhoan, MatKhau) == 1)
            {
                return true;
            }

            return false;
        }
    }
}
