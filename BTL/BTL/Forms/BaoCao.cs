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
            if(txtInput.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầu vào");
                return false;
            }
            return true;
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            index = 1;
            dateTimePicker.CustomFormat = "MMMM yyyy";
            lbTgian.Visible = false;
            dateTimePicker.Visible = false;
        }

        private void sảnPhẩmBánChạyNhấtTừNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 1;
            dateTimePicker.Visible = false;
            lbTgian.Visible = false;
            lbInput.Text = "Mã NV";
        }

        private void danhSáchHĐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 2;
            lbInput.Text = "Mã NCC";
            lbTgian.Visible = true;
            dateTimePicker.Visible = true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(index == 1 && check())
            {
                DataTable table = xuLy.DocBang($"Select * From BaoCao1('{txtInput.Text}')");
                
                if(table.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm thấy dữ liệu");
                    dgvKetQua.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu");
                }
            }

            if(index == 2 && check())
            {
                int thang = dateTimePicker.Value.Month;
                int nam = dateTimePicker.Value.Year;
                DataTable table = xuLy.DocBang($"Select * From BaoCao2('{txtInput.Text}', {thang}, {nam})");

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm thấy dữ liệu");
                    dgvKetQua.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            dateTimePicker.Value = DateTime.Today;
        }
    }
}
