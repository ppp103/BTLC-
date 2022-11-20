using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Forms
{
    public partial class ChiTietHDB : Form
    {
        XuLyCSDL cthdb = new XuLyCSDL();
        FormHDB FormHDB = new FormHDB();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\STEP\source\repos\BTLC-\BTL\BTL\DataBase\DuLieu.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        string sql;
        double kq ;
        public ChiTietHDB()
        {
            InitializeComponent();

        }
        public bool isCheck()
        {
            if (cbHdb.Text.Trim() == "")
            {
                errorProvider1.SetError(cbHdb, "Bạn phải số hóa đơn bán!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtsoluong.Text.Trim() == "")
            {
                errorProvider1.SetError(txtsoluong, "Bạn không được để trống số lượng!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtgiamgia.Text.Trim() == "")
            {
                errorProvider1.SetError(txtgiamgia, "Bạn không được để trống giảm giá!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (cbmahang.Text.Trim() == null)
            {
                errorProvider1.SetError(cbmahang, "Bạn chưa chọn  mã hàng !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            return true;

        }
        public void Showresult()
        {
            DataTable hdb = cthdb.DocBang("SELECT * FROM tblChiTietHoaDonBan");
            dataGridView1.DataSource = hdb;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridView1.Columns[0].HeaderText = "Số Hóa Đơn Bán";
            dataGridView1.Columns[1].HeaderText = "Mã Hàng";
            dataGridView1.Columns[2].HeaderText = "Số Lượng";
            dataGridView1.Columns[3].HeaderText = "Giảm Giá";
            dataGridView1.Columns[4].HeaderText = "Thành Tiền";
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Width = 85;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.BackgroundColor = Color.White;
            hdb.Dispose();
        }
        public void reloaddata()
        {
            dataGridView1.DataSource = cthdb.DocBang($"select * from tblChiTietHoaDonBan where SoHDB = N'{FormHDB.tra()}'");
        }



        //void loadCMB()
        //{
        //    dataGridView1.DataSource = cthdb.DocBang($"select * from tblChiTietHoaDonBan where SoHDB = N'{FormHDB.tra()}'");
        //    DataTable dt = cthdb.DocBang("select * from tblHoaDonBan");
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        cbHdb.Items.Add(dt.Rows[i][0].ToString());                                                   
        //    }
        //}
        void loadCMB1()
        {
            dataGridView1.DataSource = cthdb.DocBang($"select * from tblChiTietHoaDonBan where SoHDB = N'{FormHDB.tra()}'");
            DataTable d1 = cthdb.DocBang("select * from tblHangHoa");
            for (int i = 0; i < d1.Rows.Count; i++)
            {
                cbmahang.Items.Add(d1.Rows[i][0].ToString());
            }
        }



        private void ChiTietHDB_Load(object sender, EventArgs e)
        {
            txtthanhtien.Enabled = false;
            txttienhang.Enabled = false;
            txtgiamgia.Controls[0].Visible = false;
                DataTable CD = cthdb.DocBang($"select SoHDB from tblHoaDonBan where SoHDB = N'{FormHDB.tra()}'");
                String cd = CD.Rows[0][0].ToString();
                cbHdb.Text = cd;
            cbHdb.Enabled = false;

            Showresult();
            //loadCMB();
            loadCMB1();
            btnSua.Enabled = false;
            btnXoaHoaDon.Enabled = false;
            btnXoaSanPham.Enabled = false;
        }


        public void ResetGiaTri()
        {
            cbmahang.Text = null;
            txtsoluong.Text = null;
            txtgiamgia.Text = "";
            txtthanhtien.Text = "";
            txttienhang.Text = "";
            

        }

        private void radio5_Click(object sender, EventArgs e)
        {
            ResetGiaTri();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoaHoaDon.Enabled=false;
            btnXoaSanPham.Enabled = false;
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dataTable = cthdb.DocBang($"select * from tblChiTietHoaDonBan where MaHang = N'{cbmahang.Text.Trim()}' and SoHDB =  N'{cbHdb.Text.Trim()}'");
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Mã này đã tồn tại chỉ có thể cập nhật !");
                cbmahang.Focus();
                return;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có chắc chắn thêm số hóa đơn " + cbHdb.Text + " với mã hàng " + cbmahang.Text + " không?", "Thêm", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    if (isCheck())
                    {
                        DataTable table = cthdb.DocBang($"Select * From tblHangHoa Where MaHang= '{cbmahang.Text.Trim()}' ");

                        sql = $"Insert into tblChiTietHoaDonBan Values (N'{cbHdb.Text}', N'{cbmahang.Text}', N'{txtsoluong.Text}', N'{txtgiamgia.Text}', N'{txtthanhtien.Text}')";
                        cthdb.CapNhatDuLieu(sql);
                        reloaddata();
                        MessageBox.Show("Thêm thành công");

                    }
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int cout = 0;
            DataTable d1 = cthdb.DocBang($"select MaHang from tblChiTietHoaDonBan where SoHDB = N'{FormHDB.tra()}'");
            for (int i = 0; i < d1.Rows.Count; i++)
            {
                if(cbmahang.Text == d1.Rows[i][0].ToString())
                {
                    cout = 0;
                    if(cout == 0) {
                        if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (isCheck())
                            {


                                cthdb.CapNhatDuLieu($"update tblChiTietHoaDonBan set SoLuong = N'{txtsoluong.Text.Trim()}', GiamGia = N'{txtgiamgia.Text}', ThanhTien = '{txtthanhtien.Text}' where MaHang = N'{cbmahang.Text}' ");
                                reloaddata();

                                cbHdb.Enabled = true;
                                cbHdb.Focus();

                                MessageBox.Show("Sửa thành công");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng điền đủ thông tin");
                        }
                    }    
                }
                else
                {
                    cout++;
                }
                 if(cout == d1.Rows.Count)
                {
                    MessageBox.Show("Mã Hàng chưa tồn tại ! Hãy thêm mới ! ");
                    return;
                }
            }

            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult choose;
            choose = MessageBox.Show("Bạn có chắc chắn muốn xóa mã hàng " + cbmahang.Text + " ra khỏi hóa đơn " + cbHdb.Text + " không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choose == DialogResult.Yes)
            {
                if (cbHdb.Text.Trim() != "")
                {
                    errorProvider1.Clear();
                    //string sql = "";

                    ////Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
                    //sql = ;
                    cthdb.CapNhatDuLieu("Delete From tblChiTietHoaDonBan Where SoHDB = N'" + cbHdb.Text + "'AND MaHang =N'" + cbmahang.Text + "'");

                    //Cap nhat lai DataGrid

                    reloaddata();
                    ResetGiaTri();
                    MessageBox.Show("Xóa Thành Công");

                }
                else
                {
                    errorProvider1.SetError(cbmahang, "Chưa chọn mã hàng cần xóa");
                    return;
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DialogResult choose;
            choose = MessageBox.Show("Bạn có chắc chắn muốn xóa  hóa đơn " + cbHdb.Text + "  không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choose == DialogResult.Yes)
            {
                if (cbHdb.Text.Trim() != "")
                {
                    errorProvider1.Clear();


                    //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
                    sql = "Delete From tblChiTietHoaDonBan Where SoHDB =N'" + cbHdb.Text + "'";
                    cthdb.CapNhatDuLieu(sql);

                    //Cap nhat lai DataGrid

                    reloaddata();
                    MessageBox.Show("Xóa Thành Công");
                }
                else
                {
                    errorProvider1.SetError(cbHdb, "Chưa chọn/nhập hóa đơn  cần xóa");
                    return;
                }
            }
        }

        private void txtsohdb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    kq = float.Parse(txtsoluong.Text) * float.Parse(txttienhang.Text);//lỗi
                    kq = kq - kq * (float.Parse(txtgiamgia.Text) / 100);
                    txtthanhtien.Text = kq.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }

        }

        private void txtgiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                        e.Handled = true;
                        kq = double.Parse(txtsoluong.Text) * double.Parse(txttienhang.Text);
                        kq -= kq * (double.Parse(txtgiamgia.Text) / 100);
                        txtthanhtien.Text = kq.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbHdb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbmahang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoluong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DataTable CD = cthdb.DocBang($"select DonGiaBan from tblHangHoa where MaHang = N'{cbmahang.Text}'");
            String cd = CD.Rows[0][0].ToString();
            txtthanhtien.Text = cd;
            txtgiamgia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtthanhtien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            btnSua.Enabled = true;
            btnXoaHoaDon.Enabled = true;
            btnXoaSanPham.Enabled = true;
            btnThem.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cbmahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            System.Data.DataTable dataTable = cthdb.DocBang($"select * from tblChiTietHoaDonBan where MaHang = N'{cbmahang.Text.Trim()}'");
            if (dataTable.Rows.Count > 0 && count >= 1)
            {
                MessageBox.Show(" mã hàng này đã có !");
                cbmahang.Focus();
                return;
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM tblHangHoa WHERE MaHang=@mahang", con);
                cmd.Parameters.AddWithValue("@mahang", cbmahang.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string giaban = dr["DonGiaBan"].ToString();
                    txttienhang.Text = giaban;
                }
                con.Close();
                count++;
            }
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtsoluong.Text.Length == 0)
            {
                return;
            }
            if (txttienhang.Text.Length == 0)
            {
                return;
            }
            if (txtgiamgia.Text.Length == 0)
            {
                return;
            }
            kq = double.Parse(txtsoluong.Text) * double.Parse(txttienhang.Text);//lỗi
            kq = kq - kq * (double.Parse(txtgiamgia.Text.ToString()) / 100);
            txtthanhtien.Text = kq.ToString();


        }

        private void txtgiamgia_ValueChanged(object sender, EventArgs e)
        {
            if (txtsoluong.Text.Length == 0)
            {
                return;
            }
            if (txttienhang.Text.Length == 0)
            {
                return;
            }
            if (txtgiamgia.Text.Length == 0)
            {
                return;
            }
            kq = double.Parse(txtsoluong.Text) * double.Parse(txttienhang.Text);//lỗi
            kq = kq - kq * (double.Parse(txtgiamgia.Text.ToString()) / 100);
            txtthanhtien.Text = kq.ToString();


        }





        private void txttienhang_TextChanged(object sender, EventArgs e)
        {
            if (txtsoluong.Text.Length == 0)
            {
                return;
            }
            if (txttienhang.Text.Length == 0)
            {
                return;
            }
            if (txtgiamgia.Text.Length == 0)
            {
                return;
            }
            kq = double.Parse(txtsoluong.Text) * double.Parse(txttienhang.Text);//lỗi
            kq = kq - kq * (double.Parse(txtgiamgia.Text.ToString()) / 100);
            txtthanhtien.Text = kq.ToString();





        }

        private void txttienhang_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                
                    e.Handled = true;
                    kq = float.Parse(txtsoluong.Text) * float.Parse(txttienhang.Text);//lỗi
                    kq = kq - kq * (float.Parse(txtgiamgia.Text) / 100);
                    txtthanhtien.Text = kq.ToString();
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
