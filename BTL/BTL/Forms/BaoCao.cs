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
            lbInput.Text = "Nhà NCC";
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
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu");
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

        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(index == 1)
            {
                if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Vui lòng không nhập số");
                }
            }
        }
    }
}
