using BTL.Forms;
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
        string sql;
        public FormHDB()
        {
            InitializeComponent();
            
        }

      
        public void Showresult()
        {
            DataTable dtHdb = DSHDB.DocBang("SELECT * FROM tblHoaDonBan");
            dataGridView1.DataSource = dtHdb;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[4].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[0].HeaderText = "Số Hóa Đơn Bán";
            dataGridView1.Columns[1].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[2].HeaderText = "Ngày Bán";
            dataGridView1.Columns[3].HeaderText = "Mã Khách Hàng";
            dataGridView1.Columns[4].HeaderText = "Tổng Tiền";
            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.BackgroundColor = Color.White;
            dtHdb.Dispose();
        }
        private void FormHDB_Load(object sender, EventArgs e)
        {
            Showresult();
            txttennhanvien.Enabled = false;
            loadCMB();
            txttongtien.Enabled = false;


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

        

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }


       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbmanhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM tblNhanVien WHERE MaNV=@manv", con);
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

        private void cbmanhanvien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public void resetvalue()
        {
            txthdb.Text = "";
            datetime.Value = DateTime.Today;
            cbmanhanvien.Text = null;
            txttennhanvien.Text = "";
            txtmakhachhang.Text = "";
            txthdb.Enabled = true;

        }
        private void radio5_Click(object sender, EventArgs e)
        {
            resetvalue();
        }
        public bool isCheck()
        {
            if (txthdb.Text.Trim() == "")
            {
                errorProvider1.SetError(txthdb, "Số Hóa Đơn Bán Đang Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (cbmanhanvien.Text.Trim() == "")
            {
                errorProvider1.SetError(cbmanhanvien, "Chưa Chọn Mã Nhân Viên!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (datetime.Text.Trim() == "")
            {
                errorProvider1.SetError(datetime, "Ngày Bán cần được chọn!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtmakhachhang.Text.Trim() == "")
            {
                errorProvider1.SetError(txtmakhachhang, "Mã Khách Hàng Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            
            return true;

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ChiTietHDB f = new ChiTietHDB();
            f.Show();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txthdb.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            cbmanhanvien.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            datetime.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            txtmakhachhang.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            txttongtien.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            txthdb.Enabled = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có chắc chắn thêm mới hóa đơn " + txthdb.Text + "  không?", "Thêm", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                if (isCheck())
                {
                    DataTable table = DSHDB.DocBang($"Select * From tblHoaDonBan Where SoHDB= '{txthdb.Text.Trim()}' ");
                    DataTable table1 = DSHDB.DocBang($"Select * From tblKhachHang Where MaKH= '{txtmakhachhang.Text.Trim()}' ");
                    if (table.Rows.Count != 0)
                    {
                        MessageBox.Show($"Đã tồn tại hóa đơn {txthdb.Text} trong danh sách");
                    }
                    else if (table1.Rows.Count == 0)
                    {
                        MessageBox.Show($"Không tồn tại mã khách {txtmakhachhang.Text} trong danh sách");
                    }
                    else
                    {
                        sql = $"Insert into tblHoaDonBan Values (N'{txthdb.Text}', N'{cbmanhanvien.Text}', N'{datetime.Value.ToString()}', N'{txtmakhachhang.Text}', N'{txttongtien.Text}')";
                        DSHDB.CapNhatDuLieu(sql);
                        resetvalue();
                        MessageBox.Show("Thêm thành công");
                    }
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (isCheck())
                {
                    DSHDB.CapNhatDuLieu($"update tblHoaDonBan set  MaNV = N'{cbmanhanvien.Text.Trim()}', NgayBan = N'{datetime.Value.ToString().Trim()}', MaKH = N'{txtmakhachhang.Text}', TongTien = '{txttongtien.Text}' where SoHDB = N'{txthdb.Text.Trim()}' ");
                    Showresult();

                    txthdb.Enabled = true;
                    

                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin");
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DialogResult choose;
            choose = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn " + txthdb.Text + " không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choose == DialogResult.Yes)
            {
                if (txthdb.Text.Trim() != "")
                {
                    errorProvider1.Clear();
                  

                    //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
                    sql = "Delete From tblHoaDonBan Where SoHDB =N'" + txthdb.Text + "'";
                    DSHDB.CapNhatDuLieu(sql);

                    //Cap nhat lai DataGrid


                    resetvalue();
                    MessageBox.Show("Xóa Thành Công");

                }
                else
                {
                    errorProvider1.SetError(txthdb, "Chưa chọn mã hóa đơn  cần xóa");
                    return;
                }
            }
        }
    }
}
