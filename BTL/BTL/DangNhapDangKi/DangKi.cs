using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace BTL.DangNhapDangKi
{
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
                this.Close();
            
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9{6,24}]$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify mod = new Modify();  
        private void radio1_Click(object sender, EventArgs e)
        {
            string tentk = txttk.Texts;
            string mk = txtpass.Texts;
            string xacnhanmk = txtconfirmpass.Texts;
            string email = txtemail.Texts;
            if (!checkAccount(tentk)) { MessageBox.Show("Tên tài khoản phải chứa từ 6-24 kí tự và các chữ cái (thường hoặc hoa) !", "Cảnh Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (!checkAccount(mk)) { MessageBox.Show("Tên mật khẩu phải chứa từ 6-24 kí tự và các chữ cái (thường hoặc hoa) !", "Cảnh Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if(xacnhanmk!=mk){ MessageBox.Show("Mật khẩu chưa  trùng khớp!", "Cảnh Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (tentk == mk) { MessageBox.Show("Tên tài khoản và mật khẩu không được giống kí tự nhau!", "Cảnh Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (!checkEmail(email)) { MessageBox.Show("Email chưa đúng định dạng!", "Cảnh Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if(mod.Id("SELECT * FROM tblLogin WHERE EMAIL = '" + email + "'").Count!=0) { MessageBox.Show("Email đã  tồn tại , vui lòng nhập email khác!", "Cảnh Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            try 
            { 
                string query = "INSERT INTO tblLogin VALUES('"+tentk+"','"+mk+"','"+email+"')";
                mod.Command(query);
                if(MessageBox.Show("Đăng Ký Tài Khoản Mới Thành Công!,Bạn Có Muốn Đăng Nhập Luôn Không", "SOS !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Tên tài khoản này  đã  tồn tại , vui sử dụng tên tài khoản  khác!", "Cảnh Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
        }
    }
}
