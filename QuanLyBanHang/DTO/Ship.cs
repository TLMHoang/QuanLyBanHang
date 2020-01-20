using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ship
    {
        public int IDHoaDon { get; set; }
        public int Nhan { get; set; }
        public int Tra { get; set; }

        public Ship()
        {
            IDHoaDon = -1;
            Nhan = 0;
            Tra = 35000;
        }

        public Ship(int iDHoaDon, int nhan, int tra)
        {
            IDHoaDon = iDHoaDon;
            Nhan = nhan;
            Tra = tra;
        }

        public Ship(DataRow dr)
        {
            IDHoaDon = Convert.IsDBNull(dr["IDHoaDon"]) ? -1 : Convert.ToInt32(dr["IDHoaDon"]);
            Nhan = Convert.ToInt32(dr["Nhan"]);
            Tra = Convert.ToInt32(dr["Tra"]);
        }
    }
}
