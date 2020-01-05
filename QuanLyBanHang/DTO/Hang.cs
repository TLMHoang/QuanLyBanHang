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
        public int GiaHang { get; set; }
        public int IDLoai { get; set; }
        public int SoLuong { get; set; }

        public Hang() { ID = -1; TenHang = ""; GiaHang = 0; IDLoai = -1; SoLuong = 0; }
        public Hang(int iD, string tenHang, int giaHang, int iDLoai, int soLuong)
        {
            ID = iD;
            TenHang = tenHang;
            GiaHang = giaHang;
            IDLoai = iDLoai;
            SoLuong = soLuong;
        }

        public Hang(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenHang = dr["TenHang"].ToString();
            GiaHang = Convert.ToInt32(dr["GiaHang"]);
            IDLoai = Convert.ToInt32(dr["IDLoai"]);
            SoLuong = Convert.ToInt32(dr["SoLuong"]);
        }
    }
}
