using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.AxHost;
using System.Windows.Media.Media3D;
using System.Runtime.CompilerServices;

namespace BTL.Forms
{
    public partial class BaoCao : Form
    {
        XuLyCSDL xuLy = new XuLyCSDL();
        int index;
        public BaoCao()
        {
            InitializeComponent();
        }

        private bool check()
        {
            if(index == 1 || index == 2)
            {
                if(txtInput.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầu vào");
                    return false;
                }
            }

            if(index == 3 && cboQuy.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn quý");
                return false;
            }

            if(dateTimePicker.Value.Year > DateTime.Today.Year)
            {
                MessageBox.Show("Vui lòng chọn đúng năm");
            }

            if(dateTimePicker.Value.Month > DateTime.Today.Month && dateTimePicker.Value.Year == DateTime.Today.Year)
            {
                MessageBox.Show("Vui lòng chọn tháng bé hơn tháng hiện tại");
            }
            return true;
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            index = 1;
            btnLamMoi_Click(this, e);
            MenuItem1_Click(this, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            dateTimePicker.Value = DateTime.Today;
            cboQuy.SelectedIndex = -1;
            dgvKetQua.DataSource = null;
            btnBaoCao.Enabled = false;
            lbOutPut.Text = "Tổng Tiền Nhập Hàng";
        }

        private void ActivateMenu1(bool state)
        {
            lbInput.Visible = state;
            txtInput.Visible = state;
            btnTke.Enabled = !state;
            btnBaoCao.Enabled = !state;
            btnXuatExcel.Enabled = !state;
        }

        private void ActivateMenu2(bool state)
        {
            dateTimePicker.Visible = state;
            lbTgian.Visible = state;
            dateTimePicker.CustomFormat = "MMMM yyyy";
            
            lbOutPut.Visible = state;

            lbInput.Visible = state;
            txtInput.Visible = state;

            btnTke.Enabled = state;
            btnBaoCao.Enabled = !state;
            btnXuatExcel.Enabled = !state;
        }

        private void ActivateMenu3(bool state)
        {
            dateTimePicker.CustomFormat = "yyyy";
            dateTimePicker.Visible = state;
            lbTgian.Visible = state;
            
            cboQuy.Visible = state;
            lbQuy.Visible = state;
            
            lbInput.Visible = !state;
            txtInput.Visible = !state;

            btnTke.Enabled = state;
            btnBaoCao.Enabled = !state;
        }

        private void ActivateMenu4(bool state)
        {
            dateTimePicker.Visible = state;
            dateTimePicker.CustomFormat = "MMMM yyyy";

            lbInput.Visible = !state;
            txtInput.Visible = !state;

            btnBaoCao.Enabled = !state;
            btnTke.Enabled = state;
        }

        private void MenuItem1_Click(object sender, EventArgs e)
        {
            index = 1;
            lbInput.Text = "Tên NV";
            btnLamMoi_Click(this, e);
            ActivateMenu2(false);
            ActivateMenu3(false);
            ActivateMenu1(true);
        }

        private void MenuItem2_Click(object sender, EventArgs e)
        {
            index = 2;
            lbInput.Text = "Mã NCC";
            btnLamMoi_Click(this, e);
            ActivateMenu3(false);
            ActivateMenu1(false);
            ActivateMenu2(true);
        }

        private void MenuItem3_Click(object sender, EventArgs e)
        {
            index = 3;
            btnLamMoi_Click(this, e);
            ActivateMenu1(false);
            ActivateMenu2(false);
            ActivateMenu3(true);

        }

        private void dsKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 4;
            btnLamMoi_Click(this, e);
            ActivateMenu1(false);
            ActivateMenu2(false);
            ActivateMenu3(false);
            ActivateMenu4(true);
        }


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int thang = dateTimePicker.Value.Month;
            int nam = dateTimePicker.Value.Year;
            DataTable table = null;
            if (index == 2 && check())
            {
                table = xuLy.DocBang($"Select * From BaoCao2('{txtInput.Text}', {thang}, {nam})");

                if (table.Rows.Count > 0)
                {
                    double tien;
                    MessageBox.Show("Tìm thấy dữ liệu");
                    tien = Convert.ToDouble(table.Rows[0][4]);
                    lbOutPut.Text = $"Tổng tiền nhập hàng từ {txtInput.Text}: {tien}";
                    btnBaoCao.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu");
                    btnBaoCao.Enabled = false;
                }
                dgvKetQua.DataSource = table;
            }

            if (index == 3 && check())
            {
                int selectedIndex = cboQuy.SelectedIndex;
                table = xuLy.DocBang($"Select * From Quy({selectedIndex})");
                if(table.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm thấy dữ liệu");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu");
                }
                dgvKetQua.DataSource = table;
            }

            if(index == 4 && check())
            {
                table = xuLy.DocBang($"Select * From KhachHang({thang}, {nam})");
                if(table.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm thấy dữ liệu");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu");
                }
                dgvKetQua.DataSource = table;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (index == 1)
            {
                if(txtInput.Text == "")
                {
                    dgvKetQua.DataSource = null;
                    btnBaoCao.Enabled = false;
                }
                
                if(txtInput.Text != "")
                {
                    DataTable table = xuLy.DocBang($"Select * From BaoCao1(N'{txtInput.Text}')");
                    if (table.Rows.Count > 0)
                    {
                        btnBaoCao.Enabled = true;
                    }
                    else
                    {
                        btnBaoCao.Enabled = false;
                    }

                    dgvKetQua.DataSource = table;
                }
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if(index == 1)
            {
                FormReport formReport = new FormReport(index, xuLy.DocBang($"Select * From BaoCao1(N'{txtInput.Text}')"));
                formReport.ShowDialog();
            }

            if (index == 2)
            {
                int thang = dateTimePicker.Value.Month;
                int nam = dateTimePicker.Value.Year;
                FormReport formReport = new FormReport(index, xuLy.DocBang($"Select * From BaoCao2('{txtInput.Text}', {thang}, {nam})"));
                formReport.ShowDialog();
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvKetQua.Rows.Count > 0) //TH có dữ liệu để ghi
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
                exSheet.get_Range("F6:P6").Merge(true);
                header.Font.Name = "Times new roman";
                header.MergeCells = true;
                header.Font.Size = 16;
                header.Font.Bold = true;
                header.Font.Italic = true;
                header.Font.Color = Color.Red;
                
                if(index == 3)
                {
                    header.Value = $"DOANH THU QUÝ {cboQuy.SelectedItem} NĂM {dateTimePicker.Value.Year}";
                }

                if(index == 4)
                {
                    header.Value = $"DANH SÁCH KHÁCH HÀNG KHÔNG MUA HÀNG TRONG THÁNG {dateTimePicker.Value.Month} NĂM {dateTimePicker.Value.Year}";
                }

                //Tạo dòng tiêu đề bảng
                exSheet.get_Range("A8:D8").Font.Bold = true;
                exSheet.get_Range("A40:L40").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                exSheet.get_Range("E7").Value = "STT";
                exSheet.get_Range("E7").ColumnWidth = 10;

                if(index == 3)
                {
                    exSheet.get_Range("F7").Value = "Số hóa đơn bán";
                    exSheet.get_Range("F7").ColumnWidth = 15;

                    exSheet.get_Range("G7").Value = "Tổng số hàng đã bán";
                    exSheet.get_Range("G7").ColumnWidth = 25;

                    exSheet.get_Range("H7").Value = "Tổng tiền bán";
                    exSheet.get_Range("H7").ColumnWidth = 15;
                }

                if(index == 4)
                {
                    exSheet.get_Range("F7").Value = "Mã KH";
                    exSheet.get_Range("F7").ColumnWidth = 15;

                    exSheet.get_Range("G7").Value = "Tên KH";
                    exSheet.get_Range("G7").ColumnWidth = 25;

                    exSheet.get_Range("H7").Value = "Ngày Mua Hàng";
                    exSheet.get_Range("H7").ColumnWidth = 15;
                }

                //In dữ liệu
                int n = dgvKetQua.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    exSheet.get_Range("E" + (i + 7).ToString() + ":I" + (i + 4).ToString()).Font.Bold = false;
                    exSheet.get_Range("E" + (i + 7).ToString()).Value = (i + 1).ToString();

                    exSheet.get_Range("F" + (i + 7).ToString()).Value = dgvKetQua.Rows[i].Cells[0].Value;
                    exSheet.get_Range("G" + (i + 7).ToString()).Value = dgvKetQua.Rows[i].Cells[1].Value;
                    exSheet.get_Range("H" + (i + 7).ToString()).Value = dgvKetQua.Rows[i].Cells[2].Value;
                }
                exSheet.Name = "BaoCao";
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
                    MessageBox.Show("Không có dữ liệu để in");
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(index == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Vui lòng chỉ nhập chữ");
                }
            }
        }
    }
}
