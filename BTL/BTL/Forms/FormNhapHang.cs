using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormNhapHang : Form
    {
        SqlDataReader dr;
        XuLyCSDL nam = new XuLyCSDL();
        SqlConnection strConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HocHanh(ki5)\C#\Projects\BTLv7\BTL\BTL\DataBase\DuLieu.mdf;Integrated Security=True");
        string duongdan = "";
        SqlCommand cmd;

        public FormNhapHang()
        {
            InitializeComponent();
            loadCBKL();
            loadCBHSX();
            loadCBLoai();
            loadCBCL();
            loadCBCD();
            loadCBMau();
            loadCBMua();
            loadCBNSX();
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
            cbKL.Text = "";
            cbLoai.Text = "";
            cbHSX.Text = "";
            cbCL.Text = "";
            cbNSX.Text = "";
            cbMau.Text = "";
            cbCD.Text = "";
            cbMua.Text = "";

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
                errorProvider1.SetError(txtMaHang, "Bạn không thể bỏ trống mã hàng!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtTenHang.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenHang, "Chưa Chọn tên hàng !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtSoLuong.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSoLuong, "Bạn không thể bỏ trống số lượng !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtDonGiaNhap.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDonGiaNhap, "Bạn không thể bỏ trống đơn giá nhập !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtTGBH.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTGBH, "Bạn không thể bỏ trống thời gian bảo hành !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (picture.Image == null)
            {
                errorProvider1.SetError(picture, "hãy chọn ảnh !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (picture.Image == null)
            {
                errorProvider1.SetError(txtGhiChu, "Ảnh Sản Phẩm Không Được Để Trống!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (cbKL.Text.Trim() == "")
            {
                errorProvider1.SetError(cbKL, "Bạn không thể bỏ trống khối lượng !");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (cbLoai.Text.Trim() == "")
            {
                errorProvider1.SetError(cbLoai, "Bạn không thể bỏ trống mã loại !");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (cbCL.Text.Trim() == "")
            {
                errorProvider1.SetError(cbCL, "Bạn không thể bỏ trống mã chất lượng !");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (cbNSX.Text.Trim() == "")
            {
                errorProvider1.SetError(cbNSX, "Bạn không thể bỏ trống mã nhà sản xuất!");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (cbMau.Text.Trim() == "")
            {
                errorProvider1.SetError(cbNSX, "Bạn không thể bỏ trống mã màu!");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (cbCD.Text.Trim() == "")
            {
                errorProvider1.SetError(cbCD, "Bạn không thể bỏ trống mã công dụng!");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (cbMua.Text.Trim() == "")
            {
                errorProvider1.SetError(cbMua, "Bạn không thể bỏ trống mã mua");
                return false;
            }
            else
            {
                errorProvider1.Clear();

            }

            return true;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            laydulieu();
            System.Data.DataTable dataTable = nam.DocBang($"select * from tblHangHoa where MaHang = N'{txtMaHang.Text.Trim()}'");
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Mã này đã tồn tại chỉ có thể cập nhật !");
                txtMaHang.Focus();
            }
            else
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
                        string sql = $"Insert into tblHangHoa(MaHang,TenHang,SoLuong,DonGiaNhap,DonGiaBan,ThoiGianBaoHanh,Anh,GhiChu,MaLoai,MaHangSX,MaKL,MaCL,MaNuocSX,MaMau,MaCD,MaMua) Values ('" + txtMaHang.Text + "N','" + txtTenHang.Text + "','" + txtSoLuong.Text + "','" + txtDonGiaNhap.Text + "','" + txtDonGiaBan.Text + "','" + txtTGBH.Text + "',@anh, '" + txtGhiChu.Text + "',N'" + txtLoai.Text + "', N'" + txtHSX.Text + "', '" + txtKL.Text + "', N'" + txtCL.Text + "', '" + txtNSX.Text + "', N'" + txtMau.Text + "N', '" + txtCD.Text + "N', '" + txtMua.Text + "')";
                        cmd = new SqlCommand(sql, strConnect);
                        cmd.Parameters.Add(new SqlParameter("@anh", anh));
                        int N = cmd.ExecuteNonQuery();
                        //nam.CapNhatDuLieu(sql);
                        hiengiatri();
                        strConnect.Close();
                        reset();
                        MessageBox.Show("Thêm thành công");

                    }
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
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dataGridView1.Columns[6];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Hãy nhập mã hàng bạn muốn xóa !");
            }
            else
            {
               if (MessageBox.Show("Bạn có muốn xóa sản phẩm có mã là:" +
               txtMaHang.Text + " không?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
               System.Windows.Forms.DialogResult.Yes)
                {
                    nam.CapNhatDuLieu("delete tblHangHoa where MaHang ='" + txtMaHang.Text.Trim() + "'");
                    nam.CapNhatDuLieu($"Delete tblChiTietHoaDonBan where MaHang = '{txtMaHang.Text.Trim()}'");
                    dataGridView1.DataSource = nam.DocBang("Select * from tblHangHoa");
                    reset();
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    guna2Button1.Enabled = true;
                    btnLamMoi.Enabled = true;
               }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDonGiaNhap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDonGiaBan.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTGBH.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[6].Value.ToString() != null)
            {
                MemoryStream memoryStream = new MemoryStream((byte[])dataGridView1.SelectedRows[0].Cells[6].Value);
                picture.Image = System.Drawing.Image.FromStream(memoryStream);
                //duongdan = ;
            }
            else
            {
                picture.Image = null;
            }
            txtGhiChu.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


            DataTable KL = nam.DocBang($"select TenKL from tblKhoiLuong where MaKL = N'{dataGridView1.CurrentRow.Cells[8].Value.ToString()}'");
            String kl = KL.Rows[0][0].ToString();
            cbKL.Text = kl;

            DataTable Loai = nam.DocBang($"select TenLoai from tblLoai where MaLoai = N'{dataGridView1.CurrentRow.Cells[9].Value.ToString()}'");
            String loai = Loai.Rows[0][0].ToString();
            cbLoai.Text = loai;

            DataTable HSX = nam.DocBang($"select TenHangSX from tblHangSX where MaHangSX = N'{dataGridView1.CurrentRow.Cells[10].Value.ToString()}'");
            String hsx = HSX.Rows[0][0].ToString();
            cbHSX.Text = hsx;

            DataTable CL = nam.DocBang($"select TenCL from tblChatLieu where MaCL = N'{dataGridView1.CurrentRow.Cells[11].Value.ToString()}'");
            String cl = CL.Rows[0][0].ToString();
            cbCL.Text = cl;

            DataTable NSX = nam.DocBang($"select TenNuocSX from tblNuocSX where MaNuocSX = N'{dataGridView1.CurrentRow.Cells[12].Value.ToString()}'");
            String nsx = NSX.Rows[0][0].ToString();
            cbNSX.Text = nsx;

            DataTable Mau = nam.DocBang($"select TenMau from tblMauSac where MaMau = N'{dataGridView1.CurrentRow.Cells[13].Value.ToString()}'");
            String mau = Mau.Rows[0][0].ToString();
            cbMau.Text = mau;

            DataTable CD = nam.DocBang($"select TenCD from tblCongDung where MaCD = N'{dataGridView1.CurrentRow.Cells[14].Value.ToString()}'");
            String cd = CD.Rows[0][0].ToString();
            cbCD.Text = cd;

            DataTable Mua = nam.DocBang($"select TenMua from tblMua where MaMua = N'{cbMua.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString()}'");
            String mua = Mua.Rows[0][0].ToString();
            cbMua.Text = mua;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            guna2Button1.Enabled = true;
            btnLamMoi.Enabled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reset();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            guna2Button1.Enabled = true;
            btnLamMoi.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            laydulieu();
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (isCheck())
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(duongdan, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    SqlConnection CN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HocHanh(ki5)\C#\Projects\BTLv7\BTL\BTL\DataBase\DuLieu.mdf;Integrated Security=True");

                    // this is a smaple query for update statement and update where id=@id
                    string Query = "update tblHangHoa set TenHang =@Ten,SoLuong = @SoLuong, DonGiaNhap = @GiaNhap, DonGiaBan = @GiaBan, ThoiGianBaoHanh = @ThoiGianBaoHanh, Anh = @img, GhiChu = @GhiChu, MaKL = @MaKL,MaLoai = @MaLoai,MaHangSX = @MaHSX,MaCL = @MaCL,MaNuocSX = @MaNSX,MaMau = @MaMau,MaCD = @MaCD,MaMua = @MaMua where MaHang=@Ma ";

                    CN.Open();
                    cmd = new SqlCommand(Query, CN);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    cmd.Parameters.Add(new SqlParameter("@Ma", txtMaHang.Text));
                    cmd.Parameters.Add(new SqlParameter("@Ten", txtTenHang.Text));
                    cmd.Parameters.Add(new SqlParameter("@GiaNhap", txtDonGiaNhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@GiaBan", txtDonGiaBan.Text));
                    cmd.Parameters.Add(new SqlParameter("@SoLuong", txtSoLuong.Text));
                    cmd.Parameters.Add(new SqlParameter("@ThoiGianBaoHanh", txtTGBH.Text));
                    cmd.Parameters.Add(new SqlParameter("@GhiChu", txtGhiChu.Text));
                    cmd.Parameters.Add(new SqlParameter("@MaKL", txtKL.Text));
                    cmd.Parameters.Add(new SqlParameter("@MaLoai", txtLoai.Text));
                    cmd.Parameters.Add(new SqlParameter("@MaHSX", txtHSX.Text));
                    cmd.Parameters.Add(new SqlParameter("@MaCL", txtCL.Text));
                    cmd.Parameters.Add(new SqlParameter("@MaNSX", txtNSX.Text));
                    cmd.Parameters.Add(new SqlParameter("@MaMau", txtMau.Text));
                    cmd.Parameters.Add(new SqlParameter("@MaCD", txtCD.Text));
                    cmd.Parameters.Add(new SqlParameter("@MaMua", txtMua.Text));
                    cmd.ExecuteNonQuery();
                    CN.Close();

                    //nam.CapNhatDuLieu($"update tblHangHoa set  TenHang = N'{txtTenHang.Text.Trim()}', SoLuong = N'{txtSoLuong.Text}', DonGiaNhap = N'{txtDonGiaNhap.Text}', DonGiaBan = N'{txtDonGiaBan.Text}', ThoiGianBaoHanh = N'{txtTGBH.Text}', Anh = '{picture.InitialImage}', GhiChu = N'{txtGhiChu.Text}', MaKL = '{cbKL.Text}' where MaHang = N'{txtMaHang.Text.Trim()}' ");
                    hiengiatri();

                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin");
                }
                reset();
                strConnect.Close();
            }
        }

        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaNhap.Text == "")
            {
                txtDonGiaBan.Text = "0";
            }
            else
            {
                txtDonGiaBan.Text = (float.Parse(txtDonGiaNhap.Text) * 1.1).ToString();
            }
        }
        public string kl;


        private void txtDonGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        public void loadCBKL()
        {
            dataGridView1.DataSource = nam.DocBang("select * from tblHangHoa ");
            DataTable dt = nam.DocBang("select * from tblKhoiLuong");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbKL.Items.Add(dt.Rows[i][1].ToString());
            }
        }
        void loadCBLoai()
        {
            dataGridView1.DataSource = nam.DocBang("select * from tblHangHoa ");
            DataTable dt = nam.DocBang("select * from tblLoai");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbLoai.Items.Add(dt.Rows[i][1].ToString());
            }
        }
        void loadCBHSX()
        {
            dataGridView1.DataSource = nam.DocBang("select * from tblHangHoa ");
            DataTable dt = nam.DocBang("select * from tblHangSX");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbHSX.Items.Add(dt.Rows[i][1].ToString());
            }
        }
        void loadCBCL()
        {
            dataGridView1.DataSource = nam.DocBang("select * from tblHangHoa ");
            DataTable dt = nam.DocBang("select * from tblChatLieu");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbCL.Items.Add(dt.Rows[i][1].ToString());
            }
        }
        void loadCBNSX()
        {
            dataGridView1.DataSource = nam.DocBang("select * from tblHangHoa ");
            DataTable dt = nam.DocBang("select * from tblNuocSX");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbNSX.Items.Add(dt.Rows[i][1].ToString());
            }
        }
        void loadCBMau()
        {
            dataGridView1.DataSource = nam.DocBang("select * from tblHangHoa ");
            DataTable dt = nam.DocBang("select * from tblMauSac");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbMau.Items.Add(dt.Rows[i][1].ToString());
            }
        }
        void loadCBCD()
        {
            dataGridView1.DataSource = nam.DocBang("select * from tblHangHoa ");
            DataTable dt = nam.DocBang("select * from tblCongDung");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbCD.Items.Add(dt.Rows[i][1].ToString());
            }
        }
        void loadCBMua()
        {
            dataGridView1.DataSource = nam.DocBang("select * from tblHangHoa ");
            DataTable dt = nam.DocBang("select * from tblMua");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbMua.Items.Add(dt.Rows[i][1].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable KL = nam.DocBang($"select MaKL from tblKhoiLuong where TenKL = N'{cbKL.SelectedItem}'");
            String kl = KL.Rows[0][0].ToString();
            txtKL.Text = kl;

        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Loai = nam.DocBang($"select MaLoai from tblLoai where TenLoai = N'{cbLoai.SelectedItem}'");
            String loai = Loai.Rows[0][0].ToString();
            txtLoai.Text = loai;
        }

        private void cbHSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable HSX = nam.DocBang($"select MaHangSX from tblHangSX where TenHangSX = N'{cbHSX.SelectedItem}'");
            String hsx = HSX.Rows[0][0].ToString();
            txtHSX.Text = hsx;
        }

        private void cbCL_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable CL = nam.DocBang($"select MaCL from tblChatLieu where TenCL = N'{cbCL.SelectedItem}'");
            String cl = CL.Rows[0][0].ToString();
            txtCL.Text = cl;
        }

        private void cbNSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable NSX = nam.DocBang($"select MaNuocSX from tblNuocSX where TenNuocSX = N'{cbNSX.SelectedItem}'");
            String nsx = NSX.Rows[0][0].ToString();
            txtNSX.Text = nsx;
        }

        private void cbMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Mau = nam.DocBang($"select MaMau from tblMauSac where TenMau = N'{cbMau.SelectedItem}'");
            String mau = Mau.Rows[0][0].ToString();
            txtMau.Text = mau;
        }

        private void cbCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable CD = nam.DocBang($"select MaCD from tblCongDung where TenCD = N'{cbCD.SelectedItem}'");
            String cd = CD.Rows[0][0].ToString();
            txtCD.Text = cd;
        }

        private void cbMua_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Mua = nam.DocBang($"select MaMua from tblMua where TenMua = N'{cbMua.SelectedItem}'");
            String mua = Mua.Rows[0][0].ToString();
            txtMua.Text = mua;
        }
        public void laydulieu()
        {
            if (isCheck())
            {
                DataTable Loai = nam.DocBang($"select MaLoai from tblLoai where TenLoai = N'{cbLoai.SelectedItem}'");
                String loai = Loai.Rows[0][0].ToString();
                txtLoai.Text = loai;


                DataTable HSX = nam.DocBang($"select MaHangSX from tblHangSX where TenHangSX = N'{cbHSX.SelectedItem}'");
                String hsx = HSX.Rows[0][0].ToString();
                txtHSX.Text = hsx;

                DataTable CL = nam.DocBang($"select MaCL from tblChatLieu where TenCL = N'{cbCL.SelectedItem}'");
                String cl = CL.Rows[0][0].ToString();
                txtCL.Text = cl;

                DataTable NSX = nam.DocBang($"select MaNuocSX from tblNuocSX where TenNuocSX = N'{cbNSX.SelectedItem}'");
                String nsx = NSX.Rows[0][0].ToString();
                txtNSX.Text = nsx;

                DataTable Mau = nam.DocBang($"select MaMau from tblMauSac where TenMau = N'{cbMau.SelectedItem}'");
                String mau = Mau.Rows[0][0].ToString();
                txtMau.Text = mau;

                DataTable CD = nam.DocBang($"select MaCD from tblCongDung where TenCD = N'{cbCD.SelectedItem}'");
                String cd = CD.Rows[0][0].ToString();
                txtCD.Text = cd;

                DataTable Mua = nam.DocBang($"select MaMua from tblMua where TenMua = N'{cbMua.SelectedItem}'");
                String mua = Mua.Rows[0][0].ToString();
                txtMua.Text = mua;

                DataTable KL = nam.DocBang($"select MaKL from tblKhoiLuong where TenKL = N'{cbKL.SelectedItem}'");
                String kl = KL.Rows[0][0].ToString();
                txtKL.Text = kl;
            }
        }
    }
}
