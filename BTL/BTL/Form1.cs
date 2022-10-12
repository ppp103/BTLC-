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

        private void Form1_Load(object sender, EventArgs e)
        {
            FormHDB hdb = new FormHDB();
            hdb.ShowDialog();
        }

        private void btnThanhToanLuong_Click(object sender, EventArgs e)
        {
            FormThanhToanLuong ttl = new FormThanhToanLuong();
            ttl.ShowDialog();
        }
    }
}
