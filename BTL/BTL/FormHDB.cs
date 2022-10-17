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
        SqlConnection connection;
        public FormHDB()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=LAPTOP-AUDFFK8M;Initial Catalog=QLBanNuocHoa;Integrated Security=True");
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
            DataTable dtHdb = CSDLFormHDB.DocBang("SELECT DMHANGHOA.Ma_hang,DMHANGHOA.Ten_hang_hoa,CHITIETHOADONBAN.So_luong,DMHANGHOA.Don_Gia_Ban,CHITIETHOADONBAN.Giam_gia,(CHITIETHOADONBAN.So_luong*DMHANGHOA.Don_Gia_Ban) AS TongTien\r\nFROM DMHANGHOA INNER JOIN CHITIETHOADONBAN ON DMHANGHOA.Ma_hang=CHITIETHOADONBAN.Ma_hang");
            dataGridView1.DataSource = dtHdb;
            //Định dạng dataGrid
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
