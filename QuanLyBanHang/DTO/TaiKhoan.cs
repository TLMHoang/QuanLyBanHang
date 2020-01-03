using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TaiKhoan
    {
        public int ID { get; set; }
        public string TKhoan { get; set; }
        public string MatKhau { get; set; }
        public int KeyMaHoa { get; set; }
        public byte Loai { get; set; }

        public TaiKhoan() { ID = -1; TKhoan = ""; MatKhau = ""; KeyMaHoa = new Random().Next(100, 999); Loai = 1; }

        public TaiKhoan(int iD, string tKhoan, string matKhau, int keyMaHoa, byte loai)
        {
            ID = iD;
            TKhoan = tKhoan;
            MatKhau = matKhau;
            KeyMaHoa = keyMaHoa;
            Loai = loai;
        }

        public TaiKhoan(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TKhoan = dr["TaiKhoan"].ToString();
            MatKhau = dr["MatKhau"].ToString(); ;
            KeyMaHoa = Convert.ToInt32(dr["ID"]);
            Loai = Convert.ToByte(dr["Loai"]);
        }
    }
}
