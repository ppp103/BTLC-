using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BTL.DangNhapDangKi
{
    public partial class Quenmatkhau : Form
    {
        public Quenmatkhau()
        {
            InitializeComponent();
            label1.Text = "";
        }
        Modify mod = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {

                this.Close();
          
        }

        private void radio1_Click(object sender, EventArgs e)
        {
            string email = textboxhide1.Texts;
            if(email.Trim() == "") { MessageBox.Show("Vui Lòng Nhập Email  !", "Cảnh Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                string query = "SELECT * FROM tblLogin WHERE EMAIL  = '" + email + "'";
                if (mod.Id(query).Count != 0)
                {
                    label1.ForeColor = Color.Blue;
                    label1.Text = "Mật Khẩu : " + mod.Id(query)[0].Matkhau;
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "EMAIL NÀY KHÔNG TỒN TẠI !! " ;
                }    
            }
        }
    }
}
