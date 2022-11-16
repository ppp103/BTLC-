using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            dgvKetQua.DataSource = null;
            lbOutPut.Text = "Tổng Tiền Nhập Hàng";
        }

        private void ActivateMenu1(bool state)
        {
            lbInput.Visible = state;
            txtInput.Visible = state;
        }

        private void ActivateMenu2(bool state)
        {
            dateTimePicker.Visible = state;
            lbTgian.Visible = state;
            dateTimePicker.CustomFormat = "MMMM yyyy";
            
            lbOutPut.Visible = state;

            lbInput.Visible = state;
            txtInput.Visible = state;
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
        }

        private void MenuItem1_Click(object sender, EventArgs e)
        {
            index = 1;
            lbInput.Text = "Mã NV";
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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (index == 1 && check())
            {
                DataTable table = xuLy.DocBang($"Select * From BaoCao1('{txtInput.Text}')");

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm thấy dữ liệu");
                    dgvKetQua.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu");
                    dgvKetQua.DataSource = table;
                }
            }

            if (index == 2 && check())
            {
                int thang = dateTimePicker.Value.Month;
                int nam = dateTimePicker.Value.Year;
                DataTable table = xuLy.DocBang($"Select * From BaoCao2('{txtInput.Text}', {thang}, {nam})");

                if (table.Rows.Count > 0)
                {
                    double tien;
                    MessageBox.Show("Tìm thấy dữ liệu");
                    dgvKetQua.DataSource = table;
                    tien = Convert.ToDouble(table.Rows[0][4]);
                    lbOutPut.Text = $"Tổng tiền nhập hàng từ {txtInput.Text}: {tien}";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu");
                    dgvKetQua.DataSource = table;
                }
            }

            if (index == 3 && check())
            {
                MessageBox.Show("Alo123");
                if(cboQuy.SelectedIndex == 0)
                {
                    int nam = dateTimePicker.Value.Year;
                    DataTable table = xuLy.DocBang($"Select * From Quy1({nam})");
                    dgvKetQua.DataSource = table;
                }

                if (cboQuy.SelectedIndex == 1)
                {
                    int nam = dateTimePicker.Value.Year;
                    DataTable table = xuLy.DocBang($"Select * From Quy2({nam})");
                    dgvKetQua.DataSource = table;
                }

                if (cboQuy.SelectedIndex == 2)
                {
                    int nam = dateTimePicker.Value.Year;
                    DataTable table = xuLy.DocBang($"Select * From Quy3({nam})");
                    dgvKetQua.DataSource = table;
                }

                if (cboQuy.SelectedIndex == 3)
                {
                    int nam = dateTimePicker.Value.Year;
                    DataTable table = xuLy.DocBang($"Select * From Quy4({nam})");
                    dgvKetQua.DataSource = table;
                }

            }
        }

    }
}
