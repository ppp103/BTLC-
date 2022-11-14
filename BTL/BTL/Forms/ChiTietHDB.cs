using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string sql;
        public ChiTietHDB()
        {
            InitializeComponent();
        }
        public bool isCheck()
        {
            if (txtsohdb.Text.Trim() == "")
            {
                errorProvider1.SetError(txtsohdb, "Bạn không được để trống số hóa đơn bán!");
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

            if (txtmahang.Text.Trim() == "")
            {
                errorProvider1.SetError(txtmahang, "Bạn không được để trống mã hàng !");
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
            dataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[4].DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.Columns[0].HeaderText = "Số Hóa Đơn Bán";
            dataGridView1.Columns[1].HeaderText = "Mã Hàng";
            dataGridView1.Columns[2].HeaderText = "Số Lượng";
            dataGridView1.Columns[3].HeaderText = "Giảm Giá";
            dataGridView1.Columns[4].HeaderText = "Thành Tiền";
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 85;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.BackgroundColor = Color.White;
            hdb.Dispose();
        }
        public void reloaddata()
        {
            dataGridView1.DataSource = cthdb.DocBang("select * from tblChiTietHoaDonBan");
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
       

        private void radio3_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có chắc chắn thêm số hóa đơn " + txtsohdb.Text + " không?", "Thêm", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                if (isCheck())
                {
                    DataTable table = cthdb.DocBang($"Select * From tblChiTietHoaDonBan Where MaHang= '{txtmahang.Text.Trim()}' ");
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show($"Không tồn tại mã hàng{txtmahang.Text} trong danh sách");
                        //errChiTiet.SetError(txtSoKhung, "Số khung trùng trong cơ sở dữ liệu");
                        //return;
                        //
                    }
                    else
                    {
                        sql = $"Insert into tblChiTietHoaDonBan Values (N'{txtsohdb.Text}', N'{txtmahang.Text}', N'{txtsoluong.Text}', N'{txtgiamgia.Text}', N'{txtthanhtien.Text}')";
                        cthdb.CapNhatDuLieu(sql);
                        reloaddata();
                        MessageBox.Show("Thêm thành công");
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsohdb.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            txtmahang.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            txtsoluong.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            txtgiamgia.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            txtthanhtien.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            txtsohdb.Enabled = false;
         
        }

        private void ChiTietHDB_Load(object sender, EventArgs e)
        {
            txtthanhtien.Enabled = false;
            Showresult();
        }

        private void radio1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (isCheck())
                {
                    cthdb.CapNhatDuLieu($"update tblChiTietHoaDonBan set  SoHDB = N'{txtsohdb.Text.Trim()}', SoLuong = N'{txtsoluong.Text.Trim()}', GiamGia = N'{txtgiamgia.Text}', ThanhTien = '{txtthanhtien.Text}' where MaHang = N'{txtmahang.Text.Trim()}' ");
                    Showresult();
                  
                    txtsohdb.Enabled = true;
                    txtsohdb.Focus();
                   
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin");
                }
            }
        }

        private void radio2_Click(object sender, EventArgs e)
        {

            DialogResult choose;
            choose = MessageBox.Show("Bạn có chắc chắn muốn xóa trắng hóa đơn "+txtsohdb.Text+"  không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choose == DialogResult.Yes)
            {
                if (txtsohdb.Text.Trim() != "")
                {
                    errorProvider1.Clear();
                   

                    //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
                    sql = "Delete From tblChiTietHoaDonBan Where SoHDB =N'" + txtsohdb.Text + "'";
                    cthdb.CapNhatDuLieu(sql);

                    //Cap nhat lai DataGrid

                    reloaddata();
                    MessageBox.Show("Xóa Thành Công");
                }
                else
                {
                    errorProvider1.SetError(txtsohdb, "Chưa chọn/nhập hóa đơn  cần xóa");
                    return;
                }
            }
        }
        public void ResetGiaTri()
        {
            txtsohdb.Text = "";
            txtmahang.Text = "";
            txtsoluong.Text = " ";
            txtgiamgia.Text = " ";
            txtthanhtien.Text = " ";
            txtsohdb.Enabled = true;
        }

        private void radio5_Click(object sender, EventArgs e)
        {
            ResetGiaTri();
        }

        private void radio4_Click(object sender, EventArgs e)
        {
            DialogResult choose;
            choose = MessageBox.Show("Bạn có chắc chắn muốn xóa mã hàng "+txtmahang.Text+" ra khỏi hóa đơn "+txtsohdb.Text+" không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choose == DialogResult.Yes)
            {
                if (txtsohdb.Text.Trim() != "")
                {
                    errorProvider1.Clear();
                    string sql = "";

                    //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
                    sql = "Delete From tblChiTietHoaDonBan Where MaHang =N'" + txtmahang.Text + "'";
                    cthdb.CapNhatDuLieu(sql);

                    //Cap nhat lai DataGrid

                    reloaddata();
                    MessageBox.Show("Xóa Thành Công");
                }
                else
                {
                    errorProvider1.SetError(txtmahang, "Chưa chọn mã hàng cần xóa");
                    return;
                }
            }
        }
    }
}
