using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int ID { set; get; }
        public string Ten { set; get; }

        public NhanVien() { ID = -1; Ten = ""; }

        public NhanVien(int iD, string ten)
        {
            ID = iD;
            Ten = ten;
        }

        public NhanVien(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
        }
    }
}
