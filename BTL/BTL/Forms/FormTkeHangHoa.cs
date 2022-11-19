using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;

namespace BTL.Forms
{
    public partial class FormTkeHangHoa : Form
    {
        XuLyCSDL tkhh = new XuLyCSDL();
        public FormTkeHangHoa()
        {
            InitializeComponent();
        }

        private void FormTkeHangHoa_Load(object sender, EventArgs e)
        {
            DataTable dtHH = tkhh.DocBang("Select * From tblHangHoa");
            dgvKq.DataSource = dtHH;
            LoadDgvKq();
        }
        private void LoadDgvKq()
        {
            DataTable dtHH = tkhh.DocBang($"SELECT MaHang as N'Mã hàng', TenHang as N'Tên Hàng', SoLuong as N'Số lượng', DonGiaNhap as N'Đơn giá nhập',  DonGiaBan as N'Đơn giá bán', ThoiGianBaoHanh as N'Thời gian bảo hành', MaKL as N'Khối lượng', MaLoai as N'Loại', MaHangSX as N'Hãng sản xuất', MaNuocSX as N'Nước sản xuất' FROM tblHangHoa");
            dgvKq.DataSource = dtHH;
            dtHH.Dispose();
        }

        private void checkDataTable(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Tìm thấy dữ liệu");
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu");
            }
        }

        private bool check()
        {
            if (cmbChon.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mục tìm kiếm thông tin theo");
                return false;
            }

            if (cmbTT.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mục thông tin tìm kiếm");
                return false;
            }
            return true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (cmbChon.Text == "Khối lượng")
                {
                    DataTable dtHH = tkhh.DocBang("SELECT MaHang as N'Mã hàng', TenHang as N'Tên Hàng', SoLuong as N'Số lượng', DonGiaNhap as N'Đơn giá nhập',  DonGiaBan as N'Đơn giá bán', ThoiGianBaoHanh as N'Thời gian bảo hành', tblHangHoa.MaKL as N'Khối lượng', MaLoai as N'Loại', MaHangSX as N'Hãng sản xuất', MaNuocSX as N'Nước sản xuất' from tblHangHoa join tblKhoiLuong on tblHangHoa.MaKL = tblKhoiLuong.MaKL where TenKL like N'%" + cmbTT.Text.Trim() + "%' ");
                    checkDataTable(dtHH);
                    dgvKq.DataSource = dtHH;
                }
                if (cmbChon.Text == "Loại")
                {
                    DataTable dtHH = tkhh.DocBang("SELECT MaHang as N'Mã hàng', TenHang as N'Tên Hàng', SoLuong as N'Số lượng', DonGiaNhap as N'Đơn giá nhập',  DonGiaBan as N'Đơn giá bán', ThoiGianBaoHanh as N'Thời gian bảo hành', MaKL as N'Khối lượng', tblHangHoa.MaLoai as N'Loại', MaHangSX as N'Hãng sản xuất', MaNuocSX as N'Nước sản xuất' from tblHangHoa join tblLoai on tblHangHoa.MaLoai = tblLoai.MaLoai where TenLoai like N'%" + cmbTT.Text.Trim() + "%' ");
                    checkDataTable(dtHH);
                    dgvKq.DataSource = dtHH;
                }
                if (cmbChon.Text == "Nước sản xuất")
                {
                    DataTable dtHH = tkhh.DocBang("SELECT MaHang as N'Mã hàng', TenHang as N'Tên Hàng', SoLuong as N'Số lượng', DonGiaNhap as N'Đơn giá nhập',  DonGiaBan as N'Đơn giá bán', ThoiGianBaoHanh as N'Thời gian bảo hành', MaKL as N'Khối lượng', MaLoai as N'Loại', MaHangSX as N'Hãng sản xuất', tblHangHoa.MaNuocSX as N'Nước sản xuất' from tblHangHoa join tblNuocSX on tblHangHoa.MaNuocSX = tblNuocSX.MaNuocSX where TenNuocSX like N'%" + cmbTT.Text.Trim() + "%' ");
                    checkDataTable(dtHH);
                    dgvKq.DataSource = dtHH;
                }
            }
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvKq.Rows.Count > 0) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo các đối tượng
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

                // Định dạng chung
                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[2, 2];
                tenCuaHang.Font.Name = "Times new roman";
                tenCuaHang.MergeCells = true;
                tenCuaHang.Font.Size = 11;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.Font.Italic = true;
                tenCuaHang.Font.Color = Color.Blue;
                tenCuaHang.Value = "LINAPPUTY Perfume Shop";
                Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[3, 2];
                dcCuaHang.Font.Name = "Times new roman";
                dcCuaHang.MergeCells = true;
                dcCuaHang.Font.Size = 11;
                dcCuaHang.Font.Bold = true;
                dcCuaHang.Font.Italic = true;
                dcCuaHang.Font.Color = Color.Blue;
                dcCuaHang.Value = "Địa chỉ: Biệt thự Villa - Hà Nội";
                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[4, 2];
                dtCuaHang.Font.Name = "Times new roman";
                dtCuaHang.MergeCells = true;
                dtCuaHang.Font.Size = 11;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Italic = true;
                dtCuaHang.Font.Color = Color.Blue;
                dtCuaHang.Value = "Điện thoại: (03)95 246 708 ";
                Excel.Range header = (Excel.Range)exSheet.Cells[6, 6];
                exSheet.get_Range("F6:L6").Merge(true);
                header.Font.Name = "Times new roman";
                header.MergeCells = true;
                header.Font.Size = 22;
                header.Font.Bold = true;
                header.Font.Italic = true;
                header.Font.Color = Color.Red;
                header.Value = "DANH SÁCH THỐNG KÊ HÀNG HÓA";

                //Tạo dòng tiêu đề bảng
                exSheet.get_Range("A8:K8").Font.Bold = true;
                exSheet.get_Range("A8:K8").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                exSheet.get_Range("A8").Value = "STT";
                exSheet.get_Range("A8").ColumnWidth = 10;

                exSheet.get_Range("B8").Value = "Mã hàng";
                exSheet.get_Range("B8").ColumnWidth = 15;

                exSheet.get_Range("C8").Value = "Tên hàng";
                exSheet.get_Range("C8").ColumnWidth = 25;

                exSheet.get_Range("D8").Value = "Số lượng";
                exSheet.get_Range("D8").ColumnWidth = 15;

                exSheet.get_Range("E8").Value = "Đơn giá nhập";
                exSheet.get_Range("E8").ColumnWidth = 20;

                exSheet.get_Range("F8").Value = "Đơn giá bán";
                exSheet.get_Range("F8").ColumnWidth = 20;

                exSheet.get_Range("G8").Value = "Thời gian bảo hành";
                exSheet.get_Range("G8").ColumnWidth = 20;

                exSheet.get_Range("H8").Value = "Khối lượng";
                exSheet.get_Range("H8").ColumnWidth = 15;

                exSheet.get_Range("I8").Value = "Loại";
                exSheet.get_Range("I8").ColumnWidth = 15;

                exSheet.get_Range("J8").Value = "Hãng sản xuất";
                exSheet.get_Range("J8").ColumnWidth = 15;

                exSheet.get_Range("K8").Value = "Nước sản xuất";
                exSheet.get_Range("K8").ColumnWidth = 15;

                //In dữ liệu
                int n = dgvKq.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    exSheet.get_Range("A" + (i + 10).ToString() + ":K" + (i + 10).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 9).ToString()).Value = (i + 1).ToString();

                    exSheet.get_Range("B" + (i + 9).ToString()).Value = dgvKq.Rows[i].Cells[0].Value;
                    exSheet.get_Range("C" + (i + 9).ToString()).Value = dgvKq.Rows[i].Cells[1].Value;
                    exSheet.get_Range("D" + (i + 9).ToString()).Value = dgvKq.Rows[i].Cells[2].Value;
                    exSheet.get_Range("E" + (i + 9).ToString()).Value = dgvKq.Rows[i].Cells[3].Value;
                    exSheet.get_Range("F" + (i + 9).ToString()).Value = dgvKq.Rows[i].Cells[4].Value;
                    exSheet.get_Range("G" + (i + 9).ToString()).Value = dgvKq.Rows[i].Cells[5].Value;
                    exSheet.get_Range("H" + (i + 9).ToString()).Value = dgvKq.Rows[i].Cells[6].Value;
                    exSheet.get_Range("I" + (i + 9).ToString()).Value = dgvKq.Rows[i].Cells[7].Value;
                    exSheet.get_Range("J" + (i + 9).ToString()).Value = dgvKq.Rows[i].Cells[8].Value;
                    exSheet.get_Range("K" + (i + 9).ToString()).Value = dgvKq.Rows[i].Cells[9].Value;

                }
                exSheet.Name = "ThongKeHangHoa";
                exSheet.Activate();//Kích hoạt file Excel

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "fileExcel(*.xlsx)|*.xlsx |Word Document(*.doc) |*.doc|All files(*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = ".xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    exBook.SaveAs(saveFileDialog.FileName.ToString());//Lưu file Excel
                    MessageBox.Show("Lưu file thành công");
                    exApp.Quit();//Thoát khỏi ứng dụng
                }

            }
            else
            {
                MessageBox.Show("Không có danh sách hàng để in");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn chắc chắn muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void cmbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDgvKq();
            if (cmbChon.Text == "Khối lượng")
            {
                DataTable tenKL = tkhh.DocBang("select * from tblKhoiLuong");
                //dgvKq.DataSource = tenKL;

                cmbTT.Items.Clear();
                cmbTT.ResetText();

                for (int i = 0; i < tenKL.Rows.Count; i++)
                {
                    cmbTT.Items.Add(tenKL.Rows[i][1].ToString());
                }
            }

            if (cmbChon.Text == "Loại")
            {
                DataTable tenL = tkhh.DocBang("select * from tblLoai");
                //dgvKq.DataSource = tenL;

                cmbTT.Items.Clear();
                cmbTT.ResetText();

                for (int j = 0; j < tenL.Rows.Count; j++)
                {
                    cmbTT.Items.Add(tenL.Rows[j][1].ToString());
                }
            }

            if (cmbChon.Text == "Nước sản xuất")
            {
                DataTable tenNSX = tkhh.DocBang("select * from tblNuocSX");
                //dgvKq.DataSource = tenNSX;
                cmbTT.Items.Clear();
                cmbTT.ResetText();

                for (int k = 0; k < tenNSX.Rows.Count; k++)
                {
                    cmbTT.Items.Add(tenNSX.Rows[k][1].ToString());
                }
            }
        }
    }
}

