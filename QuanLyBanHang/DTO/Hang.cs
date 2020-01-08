using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hang
    {
        public int ID { get; set; }
        public string TenHang { get; set; }
        public int GiaBan { get; set; }
        public int GiaSi { get; set; }
        public int GiaNhap { get; set; }
        public int SoLuong { get; set; }

        public Hang() { ID = -1; TenHang = ""; GiaBan = 0; GiaSi = 0; GiaNhap = 0; SoLuong = 0; }

        public Hang(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenHang = dr["TenHang"].ToString();
            GiaBan = Convert.ToInt32(dr["GiaBan"]);
            GiaSi = Convert.ToInt32(dr["GiaSi"]);
            GiaNhap = Convert.ToInt32(dr["GiaNhap"]);
            SoLuong = Convert.ToInt32(dr["SoLuong"]);
        }

        public Hang(int iD, string tenHang, int giaBan, int giaSi, int giaNhap, int soLuong)
        {
            ID = iD;
            TenHang = tenHang;
            GiaBan = giaBan;
            GiaSi = giaSi;
            GiaNhap = giaNhap;
            SoLuong = soLuong;
        }
    }
}
