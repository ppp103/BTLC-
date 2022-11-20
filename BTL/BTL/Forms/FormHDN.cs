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

namespace BTL.Forms
{
    public partial class FormHDN : Form
    { 
        public static string t;
        XuLyCSDL DSHDB = new XuLyCSDL();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\STEP\source\repos\BTLC-\BTL\BTL\DataBase\DuLieu.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        string sql, sql1;

        public FormHDN()
        {
            InitializeComponent();

        }

        public void Showresult()
        {
            DataTable dtHdb = DSHDB.DocBang("SELECT * FROM tblHoaDonNhap");
            dataGridView1.DataSource = dtHdb;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridView1.Columns[0].HeaderText = "Số Hóa Đơn Nhập";
            dataGridView1.Columns[4].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[1].HeaderText = "Ngày Nhập";
            dataGridView1.Columns[3].HeaderText = "Mã NCC";
            dataGridView1.Columns[2].HeaderText = "Tổng Tiền";
            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.BackgroundColor = Color.White;
            dtHdb.Dispose();
            t = txthdb.Text;
        }
        private void FormHDB_Load(object sender, EventArgs e)
        {
            

        }
        void loadCMB()
        {
            string sql = "SELECT * FROM tblNhanVien";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbmanhanvien.Items.Add(dr["MaNV"]);
            }
            con.Close();

        }
        public void resetvalue()
        {
            txthdb.Text = "";
            datetime.Value = DateTime.Today;
            cbmanhanvien.Text = null;
            txttennhanvien.Text = "";
            txtmakhachhang.Text = "";
            txttongtien.Text = "";
            txthdb.Enabled = true;

        }
        private void radio5_Click(object sender, EventArgs e)
        {
            
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
                errorProvider1.SetError(datetime, "Ngày Nhập cần được chọn!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtmakhachhang.Text.Trim() == "")
            {
                errorProvider1.SetError(txtmakhachhang, "Mã nhà cung cấp Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            return true;

        }
        public string tra()
        {
            return t;
        }
        public bool check()
        {
            if (txthdb.Text == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (txthdb.Text != null)
            {
                Forms.ChiTietHDN f1 = new Forms.ChiTietHDN();
                f1.Show();
                t = txthdb.Text;
            }
            else
            {
                MessageBox.Show(" Bạn chưa chọn hóa đơn muốn thêm sản phẩm !");
                return;
            }
        }

        private void FormHDN_Load(object sender, EventArgs e)
        {
            Showresult();
            txttennhanvien.Enabled = false;
            loadCMB();
            txttongtien.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txthdb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbmanhanvien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            datetime.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtmakhachhang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txttongtien.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txthdb.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            t = txthdb.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có chắc chắn thêm mới hóa đơn " + txthdb.Text + "  không?", "Thêm", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                if (isCheck())
                {
                    DataTable table = DSHDB.DocBang($"Select * From tblHoaDonNhap Where SoHDN= '{txthdb.Text.Trim()}'");
                    DataTable table1 = DSHDB.DocBang($"Select * From tblNhaCungCap Where MaNCC= '{txtmakhachhang.Text.Trim()}'");

                    if (table.Rows.Count != 0)
                    {
                        MessageBox.Show($"Đã tồn tại hóa đơn {txthdb.Text} trong danh sách");
                    }
                    else if (table1.Rows.Count == 0)
                    {
                        MessageBox.Show($"Không tồn tại mã NCC {txtmakhachhang.Text} trong danh sách");
                    }
                    else
                    {
                        sql = $"Insert into tblHoaDonNhap Values (N'{txthdb.Text}', N'{datetime.Value.ToString()}',N'{txttongtien.Text}', N'{txtmakhachhang.Text}', N'{cbmanhanvien.Text}' )";
                        DSHDB.CapNhatDuLieu(sql);

                        Showresult();
                        resetvalue();
                        //ChiTietHDB f = new ChiTietHDB();
                        //f.Show();
                        MessageBox.Show("Thêm hóa đơn thành công!");

                    }
                }
            }
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            DSHDB.CapNhatDuLieu("UPDATE tblHoaDonNhap set tblHoaDonNhap.TongTien = (select ISNULL(SUM(tblChiTietHoaDonNhap.ThanhTien),0.0000) FROM tblChiTietHoaDonNhap where tblChiTietHoaDonNhap.SoHDN = tblHoaDonNhap.SoHDN) \r\n");
            this.Refresh();
            Refresh();
            this.Hide();
            FormHDN formHDN = new FormHDN();
            formHDN.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (isCheck())
                {
                    DSHDB.CapNhatDuLieu($"update tblHoaDonNhap set  MaNV = N'{cbmanhanvien.Text.Trim()}', NgayNhap = N'{datetime.Value.ToString().Trim()}', MaNCC = N'{txtmakhachhang.Text}', TongTien = '{txttongtien.Text}' where SoHDN = N'{txthdb.Text.Trim()}' ");
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult choose;
            choose = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn " + txthdb.Text + " không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choose == DialogResult.Yes)
            {
                if (txthdb.Text.Trim() != "")
                {
                    errorProvider1.Clear();


                    //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
                    sql1 = "Delete From tblChiTietHoaDonNhap Where SoHDN =N'" + txthdb.Text + "'";
                    sql = "Delete From tblHoaDonNhap Where SoHDN =N'" + txthdb.Text + "'";
                    DSHDB.CapNhatDuLieu(sql1);
                    DSHDB.CapNhatDuLieu(sql);


                    //Cap nhat lai DataGrid

                    Showresult();
                    resetvalue();
                    MessageBox.Show("Xóa Thành Công");

                }
                else
                {
                    errorProvider1.SetError(txthdb, "Chưa chọn mã hóa đơn cần xóa");
                    return;
                }
            }
        }

        private void cbmanhanvien_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void cbmanhanvien_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void radio5_Click_1(object sender, EventArgs e)
        {
            resetvalue();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}

