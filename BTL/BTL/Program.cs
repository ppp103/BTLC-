using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.Forms;

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
            //Application.Run(new HomePage.TrangChinh());
            //Application.Run(new Forms.BaoCao());
<<<<<<< HEAD
            //Application.Run(new FormHDB());
            //Application.Run(new HomePage.TrangChinh());
            //Application.Run(new FormHDB());
            // Application.Run(new FormNhapHang());
            Application.Run(new FormTkeHangHoa());
=======
            //Application.Run(new FormThongKeHoaDon());

>>>>>>> f6697593272a5ce5133bec753739eb477e3461a9
        }
    }
}
