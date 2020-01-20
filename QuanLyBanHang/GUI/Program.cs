using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        public static TaiKhoan TK;
        public static List<Hang> lstHang = new List<Hang>();
        public static List<HoaDon> lstHoaDon = new List<HoaDon>();
        public static string FormatNumber(string s) => Convert.ToInt64(s).ToString("N0");
        public static int UnFormatNumber(string s) => Convert.ToInt32(s.Replace(",", "").Replace(".", ""));
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
