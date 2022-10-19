﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            FormThongKeHoaDon thongKe = new FormThongKeHoaDon();
            thongKe.ShowDialog();
        }

        private void btnThanhToanLuong_Click(object sender, EventArgs e)
        {
            FormThanhToanLuong ttl = new FormThanhToanLuong();
            ttl.ShowDialog();
        }

        private void btnHDB_Click(object sender, EventArgs e)
        {
            FormHDB hdb = new FormHDB();
            hdb.ShowDialog();

        }

        private void btnNhapHangHoa_Click(object sender, EventArgs e)
        {
            FormNhapHangHoa nhh = new FormNhapHangHoa();
            nhh.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
