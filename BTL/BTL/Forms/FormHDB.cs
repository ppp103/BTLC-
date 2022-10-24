using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormHDB : Form
    {
        XuLyCSDL DSHDB = new XuLyCSDL();
        public FormHDB()
        {
            InitializeComponent();
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormHDB_Load(object sender, EventArgs e)
        {
            DataTable dtHdb = DSHDB.DocBang("SELECT tblHangHoa.MaHang,tblHangHoa.TenHang,tblCHITIETHOADONBAN.SoLuong,tblHANGHOA.DonGiaBan,tblCHITIETHOADONBAN.GiamGia,(tblCHITIETHOADONBAN.SoLuong*tblHANGHOA.DonGiaBan) AS TongTien\r\nFROM tblHANGHOA INNER JOIN tblCHITIETHOADONBAN ON tblHANGHOA.MaHang=tblCHITIETHOADONBAN.MaHang");
            dataGridView1.DataSource = dtHdb;
       
            dataGridView1.Columns[0].HeaderText = "Mã Hàng Hóa";
            dataGridView1.Columns[1].HeaderText = "Tên Hàng Hóa";
            dataGridView1.Columns[2].HeaderText = "Số Lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn Giá Bán";
            dataGridView1.Columns[4].HeaderText = "Giảm Giá";
            dataGridView1.Columns[5].HeaderText = "Tổng Tiền";
            dataGridView1.Columns[0].Width = 160;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Width = 160;
            dataGridView1.Columns[3].Width = 160;
            dataGridView1.Columns[4].Width = 160;
            dataGridView1.Columns[5].Width = 160;
            dataGridView1.BackgroundColor = Color.Gray;
            dtHdb.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
