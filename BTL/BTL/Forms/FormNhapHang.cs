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
    public partial class FormNhapHang : Form
    {
        SqlConnection con;
        public FormNhapHang()
        {
            InitializeComponent();
        }
        public void reset()
        {
            txtTenHang.Text = " ";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtTGBH.Text = "";
            txtAnh.Text = "";
            txtGhiChu.Text = "";
            txtMaKL.Text = "";
            txtMaLoai.Text = "";
            txtMaHangSX.Text = "";
            txtMaCL.Text = "";
            txtMaNSX.Text = "";
            txtMaMau.Text = "";
            txtMaCD.Text = "";
            txtMaMua.Text = "";

        }
        //private void btnClean_Click(object sender, EventArgs e)
        //{
        //    if (txtTenHang.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập tên hàng !");

        //    }
        //    else
        //    {
        //        if (txtSoLuong.Text == "")
        //        {
        //            MessageBox.Show("Vui lòng nhập tên sản phẩm !");

        //        }
        //        else
        //        {
        //            if (txtDonGiaNhap.Text == "")
        //            {
        //                MessageBox.Show("Vui lòng nhập tên sản phẩm !");

        //            }
        //            else
        //            {
        //                if (txtDonGiaBan.Text == "")
        //                {
        //                    MessageBox.Show("Vui lòng nhập tên sản phẩm !");

        //                }
        //                else
        //                {
        //                    if (txtTGBH.Text == "")
        //                    {
        //                        MessageBox.Show("Vui lòng nhập tên sản phẩm !");

        //                    }
        //                    else
        //                    {
        //                        if (txtMaKL.Text == "")
        //                        {
        //                            MessageBox.Show("Vui lòng nhập tên sản phẩm !");

        //                        }
        //                        else
        //                        {
        //                            if (txtMaLoai.Text == "")
        //                            {
        //                                MessageBox.Show("Vui lòng nhập tên sản phẩm !");

        //                            }
        //                            else
        //                            {
        //                                if (txtMaCL.Text == "")
        //                                {
        //                                    MessageBox.Show("Vui lòng nhập tên sản phẩm !");

        //                                }
        //                                else
        //                                {
        //                                    if (txtMaNSX.Text == "")
        //                                    {
        //                                        MessageBox.Show("Vui lòng nhập tên sản phẩm !");

        //                                    }
        //                                    else
        //                                    {
        //                                        if (txtMaMau.Text == "")
        //                                        {
        //                                            MessageBox.Show("Vui lòng nhập tên sản phẩm !");

        //                                        }
        //                                        else
        //                                        {
        //                                            if (txtMaCD.Text == "")
        //                                            {
        //                                                MessageBox.Show("Vui lòng nhập tên sản phẩm !");

        //                                            }
        //                                            else
        //                                            {

        //                                                if (txtGiaBan.Text == "")
        //                {
        //                    {
        //                        System.Data.DataTable dataTable = ProcessDataBase.ReadTable($"select * from QuanLySanPham where Ten = N'{txtTen.Text.Trim()}'");
        //                        if (dataTable.Rows.Count > 0)
        //                        {
        //                            MessageBox.Show("Tên sản phẩm này đã tồn tại, bạn hãy nhập tên sản phẩm khác!");
        //                            txtTen.Focus();
        //                        }
        //                        else
        //                        {
        //                            try
        //                            {
        //                                ProcessDataBase.UpdateData($"insert into QuanLySanPham values (N'{txtTen.Text.Trim()}',N'{txtGioiTinh.Text.Trim()}',N'{txtDungTich.Text.Trim()}',N'{txtDoLuuHuong.Text.Trim()}',N'{txtHSD.Text.Trim()}',N'{txtHang.Text.Trim()}',N'{txtGiaNhap.Text.Trim()}',N'{txtGiaBan.Text.Trim()}')");
        //                                FormNhapHang_Load(sender, e);
        //                                reset();
        //                                MessageBox.Show("Bạn đã thêm thành công");


        //                            }
        //                            catch (Exception ex)
        //                            {
        //                                MessageBox.Show(ex.Message);
        //                            }

        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //private void FormNhapHang_Load(object sender, EventArgs e)
        //{
        //    con = new SqlConnection();
        //    con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\STEP\Source\Repos\BTLC-\BTL\BTL\DataBase\DuLieu.mdf;Integrated Security=True";
        //    DataTable ct = ProcessDataBase.ReadTable("select * from tblHangHoa");
        //    dataGridView1.DataSource = ct;
        //    dataGridView1.Columns[0].HeaderText = "Mã Hàng";
        //    dataGridView1.Columns[1].HeaderText = "Tên Hàng";
        //    dataGridView1.Columns[2].HeaderText = "Số Lượng";
        //    dataGridView1.Columns[3].HeaderText = "Đơn Giá Nhập";
        //    dataGridView1.Columns[4].HeaderText = "Đơn Giá Bán";
        //    dataGridView1.Columns[5].HeaderText = "Thời Gian Bảo Hành";
        //    dataGridView1.Columns[6].HeaderText = "Ảnh";
        //    dataGridView1.Columns[7].HeaderText = "Ghi Chú";
        //    dataGridView1.Columns[8].HeaderText = "Mã Khối Lượng";
        //    dataGridView1.Columns[9].HeaderText = "Mã Loại";
        //    dataGridView1.Columns[10].HeaderText = "Mã Hàng Sản Xuất";
        //    dataGridView1.Columns[11].HeaderText = "Mã Chất Liệu";
        //    dataGridView1.Columns[12].HeaderText = "Mã Nước Sản Xuất";
        //    dataGridView1.Columns[13].HeaderText = "Mã Màu";
        //    dataGridView1.Columns[14].HeaderText = "Mã Cung Dụng";
        //    dataGridView1.Columns[15].HeaderText = "Mã Mua";
        //    dataGridView1.Columns[0].Width = 100;
        //    dataGridView1.Columns[1].Width = 100;
        //    dataGridView1.Columns[2].Width = 100;
        //    dataGridView1.Columns[3].Width = 100;
        //    dataGridView1.Columns[4].Width = 100;
        //    dataGridView1.Columns[5].Width = 100;
        //    dataGridView1.Columns[6].Width = 100;
        //    dataGridView1.Columns[7].Width = 100;
        //    dataGridView1.Columns[8].Width = 100;
        //    dataGridView1.Columns[9].Width = 100;
        //    dataGridView1.Columns[10].Width = 100;
        //    dataGridView1.Columns[11].Width = 100;
        //    dataGridView1.Columns[12].Width = 100;
        //    dataGridView1.Columns[13].Width = 100;
        //    dataGridView1.Columns[14].Width = 100;
        //    dataGridView1.Columns[15].Width = 100;
        //    dataGridView1.BackgroundColor = Color.Gray;
        //    ct.Dispose();

        //}
    }
}
