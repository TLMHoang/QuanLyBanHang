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


        public CTHD() { }
        public CTHD(int iDHoaDon, int iDHang, int soLuong, int tong)
        {
            IDHoaDon = iDHoaDon;
            IDHang = iDHang;
            SoLuong = soLuong;
        }

        public CTHD(DataRow dr)
        {
            IDHoaDon = Convert.ToInt32(dr["IDHoaDon"]);
            IDHang = Convert.ToInt32(dr["IDHang"]);
            SoLuong = Convert.ToInt32(dr["SoLuong"]);
        }
    }
}
