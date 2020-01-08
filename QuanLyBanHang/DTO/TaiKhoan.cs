using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public int ID { get; set; }
        public string TKhoan { get; set; }
        public string MatKhau { get; set; }
        public byte? Loai { get; set; }

        public TaiKhoan() { ID = -1; TKhoan = ""; MatKhau = "";  Loai = 1; }

        public TaiKhoan(int iD, string tKhoan, string matKhau, byte loai)
        {
            ID = iD;
            TKhoan = tKhoan;
            MatKhau = matKhau;
            Loai = loai;
        }

        public TaiKhoan(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TKhoan = dr["TKhoan"].ToString();
            MatKhau = dr["MatKhau"].ToString(); ;
            Loai = Convert.ToByte(dr["Loai"]);
        }
    }
}
