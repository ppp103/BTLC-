using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DangNhapDangKi.DangNhap());
<<<<<<< HEAD
            Application.Run(new HomePage.TrangChinh());
            //Application.Run(new Forms.BaoCao());
            //Application.Run(new FormHDB());
=======
            //Application.Run(new HomePage.TrangChinh());

            //Application.Run(new Forms.BaoCao());
            Application.Run(new FormHDB());
           // Application.Run(new FormNhapHang());

            
>>>>>>> 58a5abead5a5df8c6c07afa70c970b63c7fa41c1
        }
    }
}
