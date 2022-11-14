namespace BTL.Forms
{
    partial class ChiTietHDB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietHDB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.txtsohdb = new System.Windows.Forms.TextBox();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radio5 = new BTL.Radio();
            this.radio3 = new BTL.Radio();
            this.btXoaHD = new BTL.Radio();
            this.radio2 = new BTL.Radio();
            this.radio1 = new BTL.Radio();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.radio5);
            this.panel1.Controls.Add(this.radio3);
            this.panel1.Controls.Add(this.btXoaHD);
            this.panel1.Controls.Add(this.radio2);
            this.panel1.Controls.Add(this.radio1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtthanhtien);
            this.panel1.Controls.Add(this.txtmahang);
            this.panel1.Controls.Add(this.txtsohdb);
            this.panel1.Controls.Add(this.txtgiamgia);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 641);
            this.panel1.TabIndex = 75;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(431, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 641);
            this.panel2.TabIndex = 91;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(510, 641);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 32);
            this.label1.TabIndex = 86;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN BÁN HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(219, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 85;
            this.label2.Text = "%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 78);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 19);
            this.label15.TabIndex = 84;
            this.label15.Text = "Số HDB :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 336);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 19);
            this.label14.TabIndex = 83;
            this.label14.Text = "Thành Tiền :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 144);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 19);
            this.label13.TabIndex = 82;
            this.label13.Text = "Số Lượng :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(5, 206);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 19);
            this.label12.TabIndex = 81;
            this.label12.Text = "Giảm Giá  :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(5, 270);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 19);
            this.label16.TabIndex = 80;
            this.label16.Text = "Mã Hàng :";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.txtthanhtien.Location = new System.Drawing.Point(159, 339);
            this.txtthanhtien.Margin = new System.Windows.Forms.Padding(2);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(174, 20);
            this.txtthanhtien.TabIndex = 75;
            // 
            // txtmahang
            // 
            this.txtmahang.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.txtmahang.Location = new System.Drawing.Point(159, 269);
            this.txtmahang.Margin = new System.Windows.Forms.Padding(2);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(174, 20);
            this.txtmahang.TabIndex = 76;
            // 
            // txtsohdb
            // 
            this.txtsohdb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.txtsohdb.Location = new System.Drawing.Point(159, 81);
            this.txtsohdb.Margin = new System.Windows.Forms.Padding(2);
            this.txtsohdb.Name = "txtsohdb";
            this.txtsohdb.Size = new System.Drawing.Size(174, 20);
            this.txtsohdb.TabIndex = 77;
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.txtgiamgia.Location = new System.Drawing.Point(159, 209);
            this.txtgiamgia.Margin = new System.Windows.Forms.Padding(2);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.Size = new System.Drawing.Size(55, 20);
            this.txtgiamgia.TabIndex = 78;
            this.txtgiamgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.txtsoluong.Location = new System.Drawing.Point(159, 147);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(2);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(55, 20);
            this.txtsoluong.TabIndex = 79;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // radio5
            // 
            this.radio5.BackColor = System.Drawing.Color.Crimson;
            this.radio5.BackgroundColor = System.Drawing.Color.Crimson;
            this.radio5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.radio5.BorderRadius = 20;
            this.radio5.BorderSize = 0;
            this.radio5.FlatAppearance.BorderSize = 0;
            this.radio5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radio5.ForeColor = System.Drawing.Color.White;
            this.radio5.Image = ((System.Drawing.Image)(resources.GetObject("radio5.Image")));
            this.radio5.Location = new System.Drawing.Point(272, 408);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(40, 40);
            this.radio5.TabIndex = 90;
            this.radio5.TextColor = System.Drawing.Color.White;
            this.radio5.UseVisualStyleBackColor = false;
            this.radio5.Click += new System.EventHandler(this.radio5_Click);
            // 
            // radio3
            // 
            this.radio3.BackColor = System.Drawing.Color.Crimson;
            this.radio3.BackgroundColor = System.Drawing.Color.Crimson;
            this.radio3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.radio3.BorderRadius = 20;
            this.radio3.BorderSize = 0;
            this.radio3.FlatAppearance.BorderSize = 0;
            this.radio3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio3.ForeColor = System.Drawing.Color.White;
            this.radio3.Image = ((System.Drawing.Image)(resources.GetObject("radio3.Image")));
            this.radio3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radio3.Location = new System.Drawing.Point(21, 402);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(156, 46);
            this.radio3.TabIndex = 89;
            this.radio3.Text = "THÊM SẢN PHẨM";
            this.radio3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radio3.TextColor = System.Drawing.Color.White;
            this.radio3.UseVisualStyleBackColor = false;
            this.radio3.Click += new System.EventHandler(this.radio3_Click);
            // 
            // btXoaHD
            // 
            this.btXoaHD.BackColor = System.Drawing.Color.Crimson;
            this.btXoaHD.BackgroundColor = System.Drawing.Color.Crimson;
            this.btXoaHD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btXoaHD.BorderRadius = 20;
            this.btXoaHD.BorderSize = 0;
            this.btXoaHD.FlatAppearance.BorderSize = 0;
            this.btXoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaHD.ForeColor = System.Drawing.Color.White;
            this.btXoaHD.Image = ((System.Drawing.Image)(resources.GetObject("btXoaHD.Image")));
            this.btXoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaHD.Location = new System.Drawing.Point(223, 483);
            this.btXoaHD.Name = "btXoaHD";
            this.btXoaHD.Size = new System.Drawing.Size(156, 46);
            this.btXoaHD.TabIndex = 87;
            this.btXoaHD.Text = "XÓA SẢN PHẨM";
            this.btXoaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoaHD.TextColor = System.Drawing.Color.White;
            this.btXoaHD.UseVisualStyleBackColor = false;
            this.btXoaHD.Click += new System.EventHandler(this.radio4_Click);
            // 
            // radio2
            // 
            this.radio2.BackColor = System.Drawing.Color.Crimson;
            this.radio2.BackgroundColor = System.Drawing.Color.Crimson;
            this.radio2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.radio2.BorderRadius = 20;
            this.radio2.BorderSize = 0;
            this.radio2.FlatAppearance.BorderSize = 0;
            this.radio2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2.ForeColor = System.Drawing.Color.White;
            this.radio2.Image = ((System.Drawing.Image)(resources.GetObject("radio2.Image")));
            this.radio2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radio2.Location = new System.Drawing.Point(21, 563);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(156, 46);
            this.radio2.TabIndex = 87;
            this.radio2.Text = "XÓA HÓA ĐƠN";
            this.radio2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radio2.TextColor = System.Drawing.Color.White;
            this.radio2.UseVisualStyleBackColor = false;
            this.radio2.Click += new System.EventHandler(this.radio2_Click);
            // 
            // radio1
            // 
            this.radio1.BackColor = System.Drawing.Color.Crimson;
            this.radio1.BackgroundColor = System.Drawing.Color.Crimson;
            this.radio1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.radio1.BorderRadius = 20;
            this.radio1.BorderSize = 0;
            this.radio1.FlatAppearance.BorderSize = 0;
            this.radio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.ForeColor = System.Drawing.Color.White;
            this.radio1.Image = ((System.Drawing.Image)(resources.GetObject("radio1.Image")));
            this.radio1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radio1.Location = new System.Drawing.Point(21, 483);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(156, 46);
            this.radio1.TabIndex = 88;
            this.radio1.Text = "SỬA SẢN PHẨM";
            this.radio1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radio1.TextColor = System.Drawing.Color.White;
            this.radio1.UseVisualStyleBackColor = false;
            this.radio1.Click += new System.EventHandler(this.radio1_Click);
            // 
            // ChiTietHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 641);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(957, 680);
            this.MinimumSize = new System.Drawing.Size(957, 680);
            this.Name = "ChiTietHDB";
            this.Text = "ChiTietHDB";
            this.Load += new System.EventHandler(this.ChiTietHDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Radio radio5;
        private Radio radio3;
        private Radio radio2;
        private Radio radio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.TextBox txtsohdb;
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Radio btXoaHD;
    }
}