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
    public partial class ChiTietHDN : Form
    {
        string maHang;
        public ChiTietHDN()
        {
            InitializeComponent();
        }
        FormHDN FormHDN = new FormHDN();
        public static String u;
        XuLyCSDL cthdb = new XuLyCSDL();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HocHanh(ki5)\C#\Projects\BTLv7\BTL\BTL\DataBase\DuLieu.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        string sql;
        double kq;

        public void load()
        {
            Showresult();
            loadCMB1();
            //dataGridView1.Update();
        }

        public bool isCheck()
        {
            if (cbHdb.Text.Trim() == "")
            {
                errorProvider1.SetError(cbHdb, "Bạn phải mã hóa đơn Nhập!");
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

            if (cbmahang.Text.Trim() == "")
            {
                errorProvider1.SetError(cbmahang, "Bạn chưa chọn mã hàng !");
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
            DataTable hdb = cthdb.DocBang($"select * from tblChiTietHoaDonNhap");
            dataGridView1.DataSource = hdb;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridView1.Columns[4].HeaderText = "Số HĐN";
            dataGridView1.Columns[5].HeaderText = "Mã Hàng";
            dataGridView1.Columns[0].HeaderText = "Số Lượng";
            dataGridView1.Columns[2].HeaderText = "Giảm Giá";
            dataGridView1.Columns[1].HeaderText = "Giá Nhập";
            dataGridView1.Columns[3].HeaderText = "Thành Tiền";
            dataGridView1.BackgroundColor = Color.White;
            hdb.Dispose();
        }
        public void reloaddata()
        {
            dataGridView1.DataSource = cthdb.DocBang($"select * from tblChiTietHoaDonNhap where SoHDN = N'{FormHDN.tra()}'");
        }



        //void loadCMB()
        //{
        //    dataGridView1.DataSource = cthdb.DocBang($"select * from tblChiTietHoaDonNhap where SoHDN = N'{FormHDN.tra()}'");
        //    DataTable dt = cthdb.DocBang("select * from tblHoaDonNhap");
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        cbHdb.Items.Add(dt.Rows[i][0].ToString());
        //    }
        //}
        void loadCMB1()
        {
            dataGridView1.DataSource = cthdb.DocBang($"select * from tblChiTietHoaDonNhap where SoHDN = N'{FormHDN.tra()}'");
            DataTable d1 = cthdb.DocBang("select * from tblHangHoa");
            for (int i = 0; i < d1.Rows.Count; i++)
            {
                cbmahang.Items.Add(d1.Rows[i][0].ToString());
            }
        }

        public void ChiTietHDN_Load(object sender, EventArgs e)
        {
            try
            {
                txtthanhtien.Enabled = false;
                txttienhang.Enabled = false;
                txtgiamgia.Controls[1].Visible = true;
                if (FormHDN.check() == false)
                {
                    DataTable CD = cthdb.DocBang($"select SoHDN from tblHoaDonNhap where SoHDN = N'{FormHDN.tra()}'");
                    String cd = CD.Rows[0][0].ToString();
                    cbHdb.Text = cd;
                }
                cbHdb.Enabled = false;

                Showresult();
                //loadCMB();
                loadCMB1();

                btnSua.Enabled = false;
                btnXoaHoaDon.Enabled = false;
                btnXoaSanPham.Enabled = false;


                dataGridView1.Update();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Vui lòng nhập hoặc chọn Số HĐN");
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isCheck())
            {
                System.Data.DataTable dataTable = cthdb.DocBang($"select * from tblChiTietHoaDonNhap where MaHang = N'{cbmahang.Text.Trim()}' and SoHDN =  N'{cbHdb.Text.Trim()}'");
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Mã này đã tồn tại chỉ có thể cập nhật !");
                    cbmahang.Focus();
                }
                else
                {
                    try
                    {
                        DataTable CD = cthdb.DocBang($"select DonGiaNhap from tblHangHoa where MaHang = N'{cbmahang.SelectedItem}'");
                        String cd = CD.Rows[0][0].ToString();
                        txttienhang.Text = cd;

                        DialogResult chon = MessageBox.Show("Bạn có chắc chắn thêm số hóa đơn " + cbHdb.Text + " với mã hàng " + cbmahang.Text + " không?", "Thêm", MessageBoxButtons.YesNo);
                        if (chon == DialogResult.Yes)
                        {
                            if (isCheck())
                            {
                                DataTable table = cthdb.DocBang($"Select * From tblHangHoa Where MaHang= '{cbmahang.Text.Trim()}' ");

                                sql = $"Insert into tblChiTietHoaDonNhap Values (N'{txtsoluong.Text}', N'{txttienhang.Text}', N'{txtgiamgia.Text}', N'{txtthanhtien.Text}',N'{cbHdb.Text}', N'{cbmahang.Text}')";
                                cthdb.CapNhatDuLieu(sql);
                                reloaddata();
                                MessageBox.Show("Thêm thành công");

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        this.Close();
                    }
                }

            }
        }
        public void ResetGiaTri()
        {
            cbmahang.Text = null;
            txtsoluong.Text = null;
            txtgiamgia.Text = "";
            txtthanhtien.Text = "";
            txttienhang.Text = "";


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGiaTri();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoaHoaDon.Enabled = false;
            btnXoaSanPham.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isCheck())
            {
                DataTable table = cthdb.DocBang($"Select * From tblChiTietHoaDonNhap where SoHDN = '{cbHdb.Text}' and MaHang = '{cbmahang.SelectedItem}'");
                if (table.Rows.Count > 0 && !cbmahang.SelectedItem.ToString().Equals(maHang))
                {
                    MessageBox.Show("Đã có mã hàng trong hóa đơn");
                }
                else
                {

                    cthdb.CapNhatDuLieu($"update tblChiTietHoaDonNhap set SoLuong = N'{txtsoluong.Text.Trim()}', GiamGia = N'{txtgiamgia.Text}', ThanhTien = '{txtthanhtien.Text}', MaHang = '{cbmahang.Text}' where SoHDN = '{cbHdb.Text.Trim()}' and MaHang = '{maHang.Trim()}'");
                    reloaddata();

                    cbHdb.Enabled = true;
                    txtsoluong.Focus();

                    MessageBox.Show("Sửa thành công");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbHdb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbmahang.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtsoluong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtgiamgia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            DataTable CD = cthdb.DocBang($"select DonGiaNhap from tblHangHoa where MaHang = N'{cbmahang.SelectedItem}'");
            String cd = CD.Rows[0][0].ToString();
            txttienhang.Text = cd;

            txttienhang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            txtthanhtien.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            btnSua.Enabled = true;
            btnXoaHoaDon.Enabled = true;
            btnXoaSanPham.Enabled = true;
            btnThem.Enabled = false;
            maHang = cbmahang.Text;
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
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
                    cthdb.CapNhatDuLieu("Delete From tblChiTietHoaDonNhap Where SoHDN = N'" + cbHdb.Text + "'AND MaHang =N'" + cbmahang.Text + "'");

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

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {

            DialogResult choose;
            choose = MessageBox.Show("Bạn có chắc chắn muốn xóa  hóa đơn " + cbHdb.Text + "  không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choose == DialogResult.Yes)
            {
                if (cbHdb.Text.Trim() != "")
                {
                    errorProvider1.Clear();


                    //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
                    sql = "Delete From tblChiTietHoaDonNhap Where SoHDN =N'" + cbHdb.Text + "'";
                    cthdb.CapNhatDuLieu(sql);

                    //Cap nhat lai DataGrid

                    reloaddata();
                    MessageBox.Show("Xóa Thành Công");
                }
                else
                {
                    errorProvider1.SetError(cbHdb, "Chưa chọn/nhập hóa đơn cần xóa");
                    return;
                }
            }
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

        private void cbHdb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmahang_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmd = new SqlCommand("SELECT * FROM tblHangHoa WHERE MaHang=@mahang", con);
            cmd.Parameters.AddWithValue("@mahang", cbmahang.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string giaban = dr["DonGiaNhap"].ToString();
                txttienhang.Text = giaban;
            }
            con.Close();
            if (cbmahang.Text != "")
            {
                DataTable CD = cthdb.DocBang($"select DonGiaNhap from tblHangHoa where MaHang = N'{cbmahang.SelectedItem}'");
                String cd = CD.Rows[0][0].ToString();
                txttienhang.Text = cd;
            }

        }

        private void txtgiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                try
                {
                    kq = double.Parse(txtsoluong.Text) * double.Parse(txttienhang.Text);
                    kq -= kq * (double.Parse(txtgiamgia.Text) / 100);
                    txtthanhtien.Text = kq.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng");
                }

            }
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
    }
}
