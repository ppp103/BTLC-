
namespace BTL
{
    partial class FormThanhToanLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToanLuong));
            this.label1 = new System.Windows.Forms.Label();
            this.MaNhanVien = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TenNhanVien = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GioLamViec = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LuongThuViec = new System.Windows.Forms.CheckBox();
            this.ThuongThem = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TongLuong = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TongLuongPhaiThanhToanTrongThang = new System.Windows.Forms.Label();
            this.TBTongLuongPhaiThanhToanTrongThang = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.DanhSachLuong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Thông Tin : ";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.AutoSize = true;
            this.MaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhanVien.Location = new System.Drawing.Point(1, 71);
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Size = new System.Drawing.Size(95, 13);
            this.MaNhanVien.TabIndex = 0;
            this.MaNhanVien.Text = "Mã Nhân Viên :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.AutoSize = true;
            this.TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhanVien.Location = new System.Drawing.Point(284, 71);
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Size = new System.Drawing.Size(95, 13);
            this.TenNhanVien.TabIndex = 0;
            this.TenNhanVien.Text = "Mã Nhân Viên :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // GioLamViec
            // 
            this.GioLamViec.AutoSize = true;
            this.GioLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioLamViec.Location = new System.Drawing.Point(528, 71);
            this.GioLamViec.Name = "GioLamViec";
            this.GioLamViec.Size = new System.Drawing.Size(90, 13);
            this.GioLamViec.TabIndex = 0;
            this.GioLamViec.Text = "Giờ Làm Việc :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(624, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LuongThuViec
            // 
            this.LuongThuViec.AutoSize = true;
            this.LuongThuViec.ForeColor = System.Drawing.Color.Red;
            this.LuongThuViec.Location = new System.Drawing.Point(78, 156);
            this.LuongThuViec.Name = "LuongThuViec";
            this.LuongThuViec.Size = new System.Drawing.Size(102, 17);
            this.LuongThuViec.TabIndex = 3;
            this.LuongThuViec.Text = "Lương Thử Việc";
            this.LuongThuViec.UseVisualStyleBackColor = true;
            // 
            // ThuongThem
            // 
            this.ThuongThem.AutoSize = true;
            this.ThuongThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThuongThem.Location = new System.Drawing.Point(209, 156);
            this.ThuongThem.Name = "ThuongThem";
            this.ThuongThem.Size = new System.Drawing.Size(93, 13);
            this.ThuongThem.TabIndex = 0;
            this.ThuongThem.Text = "Thưởng Thêm :";
            this.ThuongThem.Click += new System.EventHandler(this.ThuongThem_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(308, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 20);
            this.textBox3.TabIndex = 2;
            // 
            // TongLuong
            // 
            this.TongLuong.AutoSize = true;
            this.TongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongLuong.Location = new System.Drawing.Point(525, 157);
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.Size = new System.Drawing.Size(83, 13);
            this.TongLuong.TabIndex = 0;
            this.TongLuong.Text = "Tổng Lương :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(615, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 20);
            this.textBox4.TabIndex = 2;
            // 
            // TongLuongPhaiThanhToanTrongThang
            // 
            this.TongLuongPhaiThanhToanTrongThang.AutoSize = true;
            this.TongLuongPhaiThanhToanTrongThang.ForeColor = System.Drawing.Color.Red;
            this.TongLuongPhaiThanhToanTrongThang.Location = new System.Drawing.Point(371, 240);
            this.TongLuongPhaiThanhToanTrongThang.Name = "TongLuongPhaiThanhToanTrongThang";
            this.TongLuongPhaiThanhToanTrongThang.Size = new System.Drawing.Size(222, 13);
            this.TongLuongPhaiThanhToanTrongThang.TabIndex = 0;
            this.TongLuongPhaiThanhToanTrongThang.Text = "Tổng Lương Phải Thanh Toán Trong Tháng :";
            // 
            // TBTongLuongPhaiThanhToanTrongThang
            // 
            this.TBTongLuongPhaiThanhToanTrongThang.Location = new System.Drawing.Point(599, 237);
            this.TBTongLuongPhaiThanhToanTrongThang.Name = "TBTongLuongPhaiThanhToanTrongThang";
            this.TBTongLuongPhaiThanhToanTrongThang.Size = new System.Drawing.Size(193, 20);
            this.TBTongLuongPhaiThanhToanTrongThang.TabIndex = 2;
            this.TBTongLuongPhaiThanhToanTrongThang.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(440, 286);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(521, 286);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(602, 286);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(683, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // DanhSachLuong
            // 
            this.DanhSachLuong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.DanhSachLuong.FullRowSelect = true;
            this.DanhSachLuong.GridLines = true;
            this.DanhSachLuong.HideSelection = false;
            this.DanhSachLuong.LabelEdit = true;
            this.DanhSachLuong.Location = new System.Drawing.Point(13, 326);
            this.DanhSachLuong.Name = "DanhSachLuong";
            this.DanhSachLuong.Size = new System.Drawing.Size(775, 124);
            this.DanhSachLuong.TabIndex = 5;
            this.DanhSachLuong.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "StaffCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(691, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // FormThanhToanLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DanhSachLuong);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.LuongThuViec);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TBTongLuongPhaiThanhToanTrongThang);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GioLamViec);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TongLuongPhaiThanhToanTrongThang);
            this.Controls.Add(this.TongLuong);
            this.Controls.Add(this.ThuongThem);
            this.Controls.Add(this.TenNhanVien);
            this.Controls.Add(this.MaNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThanhToanLuong";
            this.Text = "FormThanhToanLuong";
            this.Load += new System.EventHandler(this.FormThanhToanLuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaNhanVien;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label TenNhanVien;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label GioLamViec;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox LuongThuViec;
        private System.Windows.Forms.Label ThuongThem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label TongLuong;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label TongLuongPhaiThanhToanTrongThang;
        private System.Windows.Forms.TextBox TBTongLuongPhaiThanhToanTrongThang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView DanhSachLuong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}