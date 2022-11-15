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
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace BTL
{
    public partial class FormNhapHang : Form
    {
        XuLyCSDL nam = new XuLyCSDL();
        SqlConnection strConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\BTL-CSharp\New folder\BTL\BTL\DataBase\DuLieu.mdf"";Integrated Security=True");
        string duongdan = "";
        SqlCommand cmd;
        public FormNhapHang()
        {
            InitializeComponent();
        }
        public void reset()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtTGBH.Text = "";
            picture.Image = null;
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
        public void hiengiatri()
        {
            DataTable dtHnh = nam.DocBang("SELECT * FROM tblHangHoa");
            dataGridView1.DataSource = dtHnh;
            dtHnh.Dispose();
        }
        public bool isCheck()
        {
            if (txtMaHang.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaHang, "Số Hóa Đơn Bán Đang Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtTenHang.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenHang, "Chưa Chọn Mã Nhân Viên!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtSoLuong.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSoLuong, "Ngày Bán cần được chọn!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            //if (txtDonGiaNhap.Text.Trim() == "")
           // {
            //    errorProvider1.SetError(txtDonGiaNhap, "Mã Khách Hàng Không Được Để Trống!");
            //    return false;
           // }
            //else
           // {
            //    errorProvider1.Clear();
           // }
            if (txtDonGiaBan.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDonGiaBan, "Mã Khách Hàng Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtTGBH.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTGBH, "Mã Khách Hàng Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (picture.Image == null)
            {
                errorProvider1.SetError(picture, "Mã Khách Hàng Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtGhiChu.Text.Trim() == "")
            {
                errorProvider1.SetError(txtGhiChu, "Mã Khách Hàng Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtMaKL.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaKL, "Mã Khách Hàng Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (txtMaLoai.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaLoai, "Mã Khách Hàng Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (txtMaCL.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaCL, "Mã Khách Hàng Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (txtMaNSX.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaNSX, "Mã Khách Hàng Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (txtMaMau.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaNSX, "Mã Khách Hàng Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (txtMaCD.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaCD, "Mã Khách Hàng Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (txtMaMua.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaMua, "Mã Khách Hàng Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }

            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            DialogResult chon = MessageBox.Show("Bạn có chắc chắn thêm mới mã hàng " + txtMaHang.Text + "  không?", "Thêm", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                if (isCheck())
                {
                        byte[] anh = null;
                        FileStream Streem = new FileStream(duongdan, FileMode.Open, FileAccess.Read);
                        BinaryReader bs = new BinaryReader(Streem);
                        anh = bs.ReadBytes((int)Streem.Length);
                        strConnect.Open();
                        string sql = $"Insert into tblHangHoa(MaHang,TenHang,SoLuong,DonGiaNhap,DonGiaBan,ThoiGianBaoHanh,Anh,GhiChu,MaKL,MaLoai,MaHangSX,MaCL,MaNuocSX,MaMau,MaCD,MaMua) Values ('"+txtMaHang.Text+"','" +txtTenHang.Text+"','" +txtSoLuong.Text+"','"+ txtDonGiaNhap.Text+"','" +txtDonGiaBan.Text+"','" +txtTGBH.Text+"',@anh, '"+txtGhiChu.Text+"','" +txtMaKL.Text+"','" +txtMaLoai.Text+"', '"+txtMaHangSX.Text+"', '"+txtMaCL.Text+"', '"+txtMaNSX.Text+"', '"+txtMaMau.Text+"', '"+txtMaCD.Text+"', '"+txtMaMua.Text+"')";
                        cmd = new SqlCommand(sql, strConnect);
                        cmd.Parameters.Add(new SqlParameter("@anh",anh));
                        int N = cmd.ExecuteNonQuery();
                        //nam.CapNhatDuLieu(sql);
                        hiengiatri();
                        strConnect.Close();
                        //reset();
                        MessageBox.Show("Thêm thành công");
                    
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "File image (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";
            openFileDialog.Multiselect = false; // k cho chọn nhiều ảnh
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                duongdan = openFileDialog.FileName.ToString();
                picture.ImageLocation = duongdan; // set đường dẫn cho ảnh
            }
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            hiengiatri();
        }

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
