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
    public class ShipBAL : CInterface<Ship>
    {
        ShipDAL Val = new ShipDAL();
        public async Task<int> CapNhap(Ship obj)
        {
            return await Val.CapNhap(obj);
        }

        public Task<DataTable> LayDT()
        {
            throw new NotImplementedException();
        }

        public Task<List<Ship>> LayLst()
        {
            throw new NotImplementedException();
        }

        public async Task<Ship> Lay(int IDHoaDon)
        {
            return new Ship((await Val.Lay(IDHoaDon)).Rows[0]);
        }

        public async Task<int> Them(Ship obj)
        {
            return await Val.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await Val.Xoa(ID);
        }
    }
}
