
namespace BTL
{
    partial class FormHDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHDB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radio5 = new BTL.Radio();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.datetime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txthdb = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbmanhanvien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txttennhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmakhachhang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttongtien = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(390, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 641);
            this.panel1.TabIndex = 62;
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
            this.dataGridView1.Size = new System.Drawing.Size(551, 641);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
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
            this.radio5.Location = new System.Drawing.Point(287, 502);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(40, 40);
            this.radio5.TabIndex = 63;
            this.radio5.TextColor = System.Drawing.Color.White;
            this.radio5.UseVisualStyleBackColor = false;
            this.radio5.Click += new System.EventHandler(this.radio5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.guna2Button4);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.txttongtien);
            this.panel2.Controls.Add(this.guna2HtmlLabel8);
            this.panel2.Controls.Add(this.txtmakhachhang);
            this.panel2.Controls.Add(this.txttennhanvien);
            this.panel2.Controls.Add(this.cbmanhanvien);
            this.panel2.Controls.Add(this.txthdb);
            this.panel2.Controls.Add(this.datetime);
            this.panel2.Controls.Add(this.guna2HtmlLabel7);
            this.panel2.Controls.Add(this.guna2HtmlLabel1);
            this.panel2.Controls.Add(this.guna2HtmlLabel6);
            this.panel2.Controls.Add(this.radio5);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.guna2HtmlLabel4);
            this.panel2.Controls.Add(this.guna2HtmlLabel3);
            this.panel2.Controls.Add(this.guna2HtmlLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 641);
            this.panel2.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(44, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(283, 39);
            this.guna2HtmlLabel1.TabIndex = 97;
            this.guna2HtmlLabel1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 54);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(78, 27);
            this.guna2HtmlLabel2.TabIndex = 99;
            this.guna2HtmlLabel2.Text = "Số HDB :";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 115);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(96, 27);
            this.guna2HtmlLabel3.TabIndex = 99;
            this.guna2HtmlLabel3.Text = "Ngày Bán :";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 172);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(136, 27);
            this.guna2HtmlLabel4.TabIndex = 100;
            this.guna2HtmlLabel4.Text = "Mã Nhân Viên :";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(12, 233);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(139, 27);
            this.guna2HtmlLabel6.TabIndex = 102;
            this.guna2HtmlLabel6.Text = "Tên Nhân Viên :";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(10, 294);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(150, 27);
            this.guna2HtmlLabel7.TabIndex = 103;
            this.guna2HtmlLabel7.Text = "Mã Khách Hàng :";
            // 
            // datetime
            // 
            this.datetime.Checked = true;
            this.datetime.FillColor = System.Drawing.Color.White;
            this.datetime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime.Location = new System.Drawing.Point(169, 115);
            this.datetime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 36);
            this.datetime.TabIndex = 104;
            this.datetime.Value = new System.DateTime(2022, 11, 14, 19, 8, 56, 121);
            // 
            // txthdb
            // 
            this.txthdb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthdb.DefaultText = "";
            this.txthdb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txthdb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txthdb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthdb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthdb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthdb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txthdb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthdb.Location = new System.Drawing.Point(169, 54);
            this.txthdb.Name = "txthdb";
            this.txthdb.PasswordChar = '\0';
            this.txthdb.PlaceholderText = "";
            this.txthdb.SelectedText = "";
            this.txthdb.Size = new System.Drawing.Size(200, 36);
            this.txthdb.TabIndex = 105;
            // 
            // cbmanhanvien
            // 
            this.cbmanhanvien.BackColor = System.Drawing.Color.Transparent;
            this.cbmanhanvien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmanhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmanhanvien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmanhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmanhanvien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbmanhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbmanhanvien.ItemHeight = 30;
            this.cbmanhanvien.Location = new System.Drawing.Point(169, 172);
            this.cbmanhanvien.Name = "cbmanhanvien";
            this.cbmanhanvien.Size = new System.Drawing.Size(200, 36);
            this.cbmanhanvien.TabIndex = 106;
            this.cbmanhanvien.SelectedIndexChanged += new System.EventHandler(this.cbmanhanvien_SelectedIndexChanged);
            this.cbmanhanvien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbmanhanvien_KeyPress);
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttennhanvien.DefaultText = "";
            this.txttennhanvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttennhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttennhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttennhanvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttennhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttennhanvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttennhanvien.Location = new System.Drawing.Point(169, 233);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.PasswordChar = '\0';
            this.txttennhanvien.PlaceholderText = "";
            this.txttennhanvien.SelectedText = "";
            this.txttennhanvien.Size = new System.Drawing.Size(200, 36);
            this.txttennhanvien.TabIndex = 107;
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmakhachhang.DefaultText = "";
            this.txtmakhachhang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmakhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmakhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmakhachhang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmakhachhang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmakhachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmakhachhang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmakhachhang.Location = new System.Drawing.Point(169, 294);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.PasswordChar = '\0';
            this.txtmakhachhang.PlaceholderText = "";
            this.txtmakhachhang.SelectedText = "";
            this.txtmakhachhang.Size = new System.Drawing.Size(200, 36);
            this.txtmakhachhang.TabIndex = 108;
            // 
            // txttongtien
            // 
            this.txttongtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttongtien.DefaultText = "";
            this.txttongtien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttongtien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttongtien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttongtien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttongtien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttongtien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttongtien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttongtien.Location = new System.Drawing.Point(169, 360);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.PasswordChar = '\0';
            this.txttongtien.PlaceholderText = "";
            this.txttongtien.SelectedText = "";
            this.txttongtien.Size = new System.Drawing.Size(200, 36);
            this.txttongtien.TabIndex = 111;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(12, 360);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(111, 27);
            this.guna2HtmlLabel8.TabIndex = 110;
            this.guna2HtmlLabel8.Text = "TỔNG TIỀN  :";
            // 
            // guna2Button4
            // 
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BorderRadius = 21;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Salmon;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.Location = new System.Drawing.Point(204, 575);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(180, 45);
            this.guna2Button4.TabIndex = 115;
            this.guna2Button4.Text = "XÓA HÓA ĐƠN";
            this.guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderRadius = 21;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Salmon;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(10, 429);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(372, 45);
            this.guna2Button3.TabIndex = 114;
            this.guna2Button3.Text = "THÊM SẢN PHẨM VÀO CHI TIẾT HÓA ĐƠN BÁN";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Salmon;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Location = new System.Drawing.Point(10, 575);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 113;
            this.guna2Button2.Text = "SỬA HÓA ĐƠN";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Salmon;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(12, 502);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 112;
            this.guna2Button1.Text = "THÊM HÓA ĐƠN";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(941, 641);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(957, 680);
            this.MinimumSize = new System.Drawing.Size(957, 680);
            this.Name = "FormHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá Đơn Bán";
            this.Load += new System.EventHandler(this.FormHDB_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Radio radio5;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime;
        private Guna.UI2.WinForms.Guna2TextBox txtmakhachhang;
        private Guna.UI2.WinForms.Guna2TextBox txttennhanvien;
        private Guna.UI2.WinForms.Guna2ComboBox cbmanhanvien;
        private Guna.UI2.WinForms.Guna2TextBox txthdb;
        private Guna.UI2.WinForms.Guna2TextBox txttongtien;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}