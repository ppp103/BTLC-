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
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            //guna2DataGridView1.Columns[0].
        }

        private void sảnPhẩmBánChạyNhấtTừNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
            }
            else
            {
                guna2DataGridView1.DataSource = xuLy.DocBang($"Select * From BaoCao1('{txtMaNV.Text}')");
            }

        }
    }
}
