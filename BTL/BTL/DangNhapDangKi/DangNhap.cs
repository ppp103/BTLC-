using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL;
using HomePage;

namespace BTL.DangNhapDangKi
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void radio2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKi dk = new DangKi();
            dk.ShowDialog();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Quenmatkhau fg = new Quenmatkhau();
            fg.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        Modify mod = new Modify();
        public void check()
        {

        }
 
        private void radio1_Click(object sender, EventArgs e)
        {
            string tentk = textBox1.Texts;
            string mk = txtmk.Texts;
            if(tentk.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên tài khoản");
               
            }
            else if (mk.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
               
            }
            else
            {
                string query = "SELECT * FROM tblLogin WHERE ID = '"+tentk+"' AND PASS = '"+mk+"'";
                if(mod.Id(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công !","Cảnh Báo !",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    TrangChinh f2 = new TrangChinh();
                    f2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu chưa chính xác !", "Cảnh Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
