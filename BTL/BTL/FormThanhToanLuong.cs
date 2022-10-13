using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormThanhToanLuong : Form
    {
        public FormThanhToanLuong()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThuongThem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void FormThanhToanLuong_Load(object sender, EventArgs e)
        {
            DanhSachLuong.View = View.Details;
            DanhSachLuong.GridLines = true;
            DanhSachLuong.FullRowSelect = true;

            //Thêm tiêu đề cho cột

            DanhSachLuong.Columns.Add("StaffCode", 100);
            DanhSachLuong.Columns.Add("StaffName", 100);
            DanhSachLuong.Columns.Add("HoursWork", 100);
            DanhSachLuong.Columns.Add("Bonus", 100);
            DanhSachLuong.Columns.Add("TotalSalary", 100);

            //Thêm Item vào listview
            string[] arr = new string[5];
            ListViewItem itm;

            //Thêm Item đầu tiên
            arr[0] = "001";
            arr[1] = "nam";
            arr[2] = "1000";
            arr[3] = "900 VND";
            arr[4] = "1.900.000 VND";
            itm = new ListViewItem(arr);
            DanhSachLuong.Items.Add(itm);

            //Thêm Item thứ 2
            arr[0] = "002";
            arr[1] = "hen";
            arr[2] = "2000";
            arr[3] = "700 VND";
            arr[4] = "1.700.000 VND";
            itm = new ListViewItem(arr);
            DanhSachLuong.Items.Add(itm);
        }
    }
}
