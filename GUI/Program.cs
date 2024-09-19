using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI_HoaDonBan());
            //Application.Run(new GUI_ThongKe ());
            //Application.Run(new GUI_MatHang());
            //Application.Run(new GUI_DangNhap());
        }
    }
}
