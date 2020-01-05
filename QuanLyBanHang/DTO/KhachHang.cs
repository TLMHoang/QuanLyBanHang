using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public KhachHang() { ID = -1; TenKH = ""; SDT = ""; DiaChi = ""; }

        public KhachHang(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenKH = dr["TenKH"].ToString();
            SDT = dr["SDT"].ToString();
            DiaChi = dr["DiaChi"].ToString();
        }

        public KhachHang(int iD, string tenKH, string sDT, string diaChi)
        {
            ID = iD;
            TenKH = tenKH;
            SDT = sDT;
            DiaChi = diaChi;
        }
    }
}
