﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL
{
    public partial class FormThongKeHoaDon : Form
    {
        XuLyCSDL XuLy = new XuLyCSDL();
        public FormThongKeHoaDon()
        {
            InitializeComponent();
        }

        private void FormThongKeHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dtHoaDon = XuLy.DocBang("Select * From tblHoaDonBan");
            dataGridView1.DataSource = dtHoaDon;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
