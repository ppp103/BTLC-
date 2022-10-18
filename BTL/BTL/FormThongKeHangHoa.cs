using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BTL
{
    public partial class FormThongKeHangHoa: Form
    {
        XuLyCSDL XuLy = new XuLyCSDL();
        public FormThongKeHangHoa()
        {
            InitializeComponent();
        }

        private void FormThongKeHangHoa_Load(object sender, EventArgs e)
        {
            DataTable dtHoaDon = XuLy.DocBang("Select * From tblHoaDonBan");
            dataGridView1.DataSource = dtHoaDon;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void livDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grbNhapTT_Enter(object sender, EventArgs e)
        {

        }
    }
}
