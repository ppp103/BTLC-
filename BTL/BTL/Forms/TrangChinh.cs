using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace HomePage
{
    public partial class TrangChinh : Form
    {
        private IconButton nutHienTai;
        bool tkeDangMo = false;
        bool isNotActive = false;
        public TrangChinh()
        {
            InitializeComponent();
        }
        private void KichHoatNut(object btn)
        {
            if(btn != null)
            {
                HuyKichHoatNutHtai();
                nutHienTai = (IconButton)btn;
                nutHienTai.BackColor = Color.LightCoral;
                iconTieuDe.IconChar = nutHienTai.IconChar;
                labelTieuDe.Text = nutHienTai.Text;
            }
        }

        private void HuyKichHoatNutHtai()
        {
            if(nutHienTai != null)
            {
                nutHienTai.BackColor = Color.PeachPuff;
            }
        }

        private void btnTkeHoaDon_Click(object sender, EventArgs e)
        {
            timerTkeHoaDon.Start();
            KichHoatNut(sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerTkeHoaDon_Tick(object sender, EventArgs e)
        {
            if (tkeDangMo == false)
            {
                panelTkeHoaDon.Height += 10;
                if(panelTkeHoaDon.Height == panelTkeHoaDon.MaximumSize.Height)
                {
                    tkeDangMo = true;
                    timerTkeHoaDon.Stop();
                }
            }
            else
            {
                panelTkeHoaDon.Height -= 10;
                if(panelTkeHoaDon.Height == panelTkeHoaDon.MinimumSize.Height)
                {
                    tkeDangMo = false;
                    timerTkeHoaDon.Stop();
                }
            }
        }

        private void btnTkeHangHoa_Click(object sender, EventArgs e)
        {
            KichHoatNut(sender);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            KichHoatNut(sender);
        }

        private void btnNhapHoaDonBan_Click(object sender, EventArgs e)
        {
            KichHoatNut(sender);

        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            KichHoatNut(sender);
        }                                                                                      

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            KichHoatNut(sender);
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            iconTieuDe.IconChar = IconChar.Home;
            labelTieuDe.Text = "Trang chủ";
        }

        private void logo_Click(object sender, EventArgs e)
        {
            HuyKichHoatNutHtai();
            iconTieuDe.IconChar = IconChar.Home;
            labelTieuDe.Text = "Trang chủ";
            if (tkeDangMo) timerTkeHoaDon.Start();
        }
    }
}
