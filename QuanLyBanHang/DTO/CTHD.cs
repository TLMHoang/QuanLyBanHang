using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHD
    {
        public int IDHoaDon { get; set; }
        public int IDHang { get; set; }
        public int SoLuong { get; set; }
        public byte? Tang { get; set; }
        public int GiaSi { get; set; }


        public CTHD() { IDHoaDon = -1; IDHang = -1; SoLuong = 0; Tang = 0; GiaSi = -1; }
        public CTHD(int iDHoaDon, int iDHang, int soLuong, byte tang, int giaSi)
        {
            IDHoaDon = iDHoaDon;
            IDHang = iDHang;
            SoLuong = soLuong;
            Tang = tang;
            GiaSi = giaSi;
        }

        public CTHD(DataRow dr)
        {
            IDHoaDon = Convert.IsDBNull(dr["IDHoaDon"]) ? -1 : Convert.ToInt32(dr["IDHoaDon"]);
            IDHang = Convert.IsDBNull(dr["IDHang"]) ? -1 : Convert.ToInt32(dr["IDHang"]);
            SoLuong = Convert.ToInt32(dr["SoLuong"]);
            Tang = Convert.ToByte(dr["Tang"]);
            GiaSi = Convert.IsDBNull(dr["GiaSi"]) ? -1 : Convert.ToInt32(dr["GiaSi"]);
        }
    }
}
