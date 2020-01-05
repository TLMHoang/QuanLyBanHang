﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Loai
    {
        public int ID { get; set; }
        public string TenLoai { get; set; }

        public Loai() { ID = -1; TenLoai = ""; }

        public Loai(int iD, string tenLoai)
        {
            ID = iD;
            TenLoai = tenLoai;
        }

        public Loai(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenLoai = dr["TenLoai"].ToString();
        }
    }
}
