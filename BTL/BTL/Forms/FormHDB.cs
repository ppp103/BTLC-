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
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\BTL-CSharp\\New folder\\BTL\\BTL\\DataBase\\DuLieu.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
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
        public void Showresult()
        {
            DataTable dtHdb = DSHDB.DocBang("SELECT tblHangHoa.MaHang,tblHangHoa.TenHang,tblCHITIETHOADONBAN.SoLuong,tblHANGHOA.DonGiaBan,tblCHITIETHOADONBAN.GiamGia,(tblCHITIETHOADONBAN.SoLuong*tblHANGHOA.DonGiaBan) AS TongTien\r\nFROM tblHANGHOA INNER JOIN tblCHITIETHOADONBAN ON tblHANGHOA.MaHang=tblCHITIETHOADONBAN.MaHang");
            dataGridView1.DataSource = dtHdb;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[4].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[5].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[0].HeaderText = "Mã Hàng Hóa";
            dataGridView1.Columns[1].HeaderText = "Tên Hàng Hóa";
            dataGridView1.Columns[2].HeaderText = "Số Lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn Giá Bán";
            dataGridView1.Columns[4].HeaderText = "Giảm Giá";
            dataGridView1.Columns[5].HeaderText = "Tổng Tiền";
            dataGridView1.Columns[0].Width = 140;
            dataGridView1.Columns[1].Width = 210;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 160;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 130;
            dataGridView1.BackgroundColor = Color.White;
            dtHdb.Dispose();
        }
        private void FormHDB_Load(object sender, EventArgs e)
        {
            Showresult();
            txttennhanvien.Enabled = false;
            loadCMB();


        }
        void loadCMB()
        {
            string sql = "SELECT * FROM tblNhanVien";
            cmd = new SqlCommand(sql,con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbmanhanvien.Items.Add(dr["MaNV"]);
            }
            con.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM tblNhanVien WHERE MaNV=@manv",con);
            cmd.Parameters.AddWithValue("@manv", cbmanhanvien.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string tennv = dr["TenNV"].ToString();
                txttennhanvien.Text = tennv;
            }
            con.Close();

        }

        private void txttennhanvien_TextChanged(object sender, EventArgs e)
        {
            //loadCMB();
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled=true;
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
