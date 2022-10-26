using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL
{
    public partial class FormNhapHangHoa: Form
    {
        XuLyCSDL XuLy = new XuLyCSDL();
        public FormNhapHangHoa()
        {
            InitializeComponent();
        }

        private void FormThongKeHangHoa_Load(object sender, EventArgs e)
        {
            DataTable dtHangHoa = XuLy.DocBang("Select * From tblHangHoa");
            dataGridView1.DataSource = dtHangHoa;
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
