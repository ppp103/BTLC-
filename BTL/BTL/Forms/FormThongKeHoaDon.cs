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
    public partial class FormThongKeHoaDon : Form
    {
        XuLyCSDL XuLy = new XuLyCSDL();
        public FormThongKeHoaDon()
        {
            InitializeComponent();
        }

        private void FormThongKeHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dtHoaDon = XuLy.DocBang("Select * From tblHoaDonNhap");
            dgvKetQua.DataSource = dtHoaDon;
        }
       

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if(txtChon.SelectedIndex==1)
            {
                DataTable table = XuLy.DocBang($"Select * from tblHoaDonNhap where Day(NgayNhap) = {dtNgay.Value.Day} and Month(NgayNhap) = {dtNgay.Value.Month} and Year(NgayNhap) = {dtNgay.Value.Year}");
                
                if(table.Rows.Count > 0)
                {
                    MessageBox.Show("Có tìm thấy dữ liệu");
                }
                dgvKetQua.DataSource = table;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool Check()
        {
            if (txtChon.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn tìm kiếm theo!");
                return false;
            }
            return true;
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            if (Check())
            {
                if (txtChon.Text == "Mã hàng")
                {
                    DataTable dtHH = XuLy.DocBang("select * from tblChiTietHoaDonNhap where MaHang like N'%" + txtNhap.Text.Trim() + "%' ");
                    dgvKetQua.DataSource = dtHH;
                }

                if (txtChon.Text == "Nhà cung cấp")
                {
                    DataTable dtHH = XuLy.DocBang("select * from tblHoaDonNhap Join tblNhaCungCap on tblHoaDonNhap.MaNCC = tblNhaCungCap.MaNCC where TenNCC like N'%" + txtNhap.Text.Trim() + "%' ");
                    dgvKetQua.DataSource = dtHH;
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //if (txtChon.Text == "Mã hàng")
            //{
            //    DataTable dtHH = XuLy.DocBang("select * from tblChiTietHoaDonNhap where MaHang like N'%" + txtNhap.Text.Trim() + "%' ");
            //    dgvKetQua.DataSource = dtHH;
            //}
            if (txtChon.Text == "Ngày nhập")
            {
                DataTable dtHH = XuLy.DocBang("select * from tblHoaDonNhap where NgayNhap like N'%" + txtNhap.Text.Trim() + "%' ");
                dgvKetQua.DataSource = dtHH;
            }
            //if (txtChon.SelectedIndex == 2)
            //{
            //    DataTable dtHH = XuLy.DocBang("select * from tblHoaDonNhap where MaNCC like N'%" + txtNhap.Text.Trim() + "%' ");
            //    dgvKetQua.DataSource = dtHH;
            //}
        }

        private void txtChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtChon.SelectedIndex==1)
            {
                txtNhap.Enabled = false;
            }
            else
            {
                txtNhap.Enabled = true;
            } 

            if(txtChon.SelectedIndex == 2 || txtChon.SelectedIndex == 0)
            {
                dtNgay.Enabled = false;
                btnHienThi.Enabled = false;
            }
            else
            {
                dtNgay.Enabled = true;
                btnHienThi.Enabled = true;
            }
        }

        private void dtNgay_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dtNgay.Value.ToShortDateString();
            theDate = txtNhap.Text;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtChon.SelectedIndex = -1;
            txtNhap.Text = "";
            dtNgay.Value = DateTime.Today;
        }
    }
}
