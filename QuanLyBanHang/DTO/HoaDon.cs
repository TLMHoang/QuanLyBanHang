using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int? IDKhachHang { get; set; }
        public int? IDNhanVien { get; set; }
        public DateTime? Ngay { get; set; }
        public byte? TinhTrang { get; set; }



        public HoaDon() { ID = -1; IDKhachHang = -1; IDNhanVien = -1; Ngay = DateTime.Now; TinhTrang = 0; }

        public HoaDon(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDKhachHang = Convert.IsDBNull(dr["IDKhacHang"]) ? -1 : Convert.ToInt32(dr["IDKhachHang"]);
            IDNhanVien = Convert.IsDBNull(dr["IDNhanVien"]) ? -1 : Convert.ToInt32(dr["IDNhanVien"]);
            Ngay = Convert.ToDateTime(dr["Ngay"]);
            TinhTrang = Convert.ToByte(dr["TinhTrang"]);
        }

        public HoaDon(int iD, int iDKhachHang, int iDNhanVien, DateTime? ngay, byte? tinhTrang, byte? checkNull)
        {
            ID = iD;
            IDKhachHang = iDKhachHang;
            IDNhanVien = iDNhanVien;
            Ngay = ngay;
            TinhTrang = tinhTrang;
        }
    }
}
