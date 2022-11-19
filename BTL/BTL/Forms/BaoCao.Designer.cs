namespace BTL.Forms
{
    partial class BaoCao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHĐToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dsKHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKetQua = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnTke = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.txtInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboQuy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbQuy = new System.Windows.Forms.Label();
            this.lbTgian = new System.Windows.Forms.Label();
            this.lbOutPut = new System.Windows.Forms.Label();
            this.btnBaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem1,
            this.danhSáchHĐToolStripMenuItem,
            this.MenuItem3,
            this.dsKHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 673);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem1
            // 
            this.MenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.Size = new System.Drawing.Size(268, 26);
            this.MenuItem1.Text = "3 sản phẩm bán chạy nhất theo NV";
            this.MenuItem1.Click += new System.EventHandler(this.MenuItem1_Click);
            // 
            // danhSáchHĐToolStripMenuItem
            // 
            this.danhSáchHĐToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchHĐToolStripMenuItem.Name = "danhSáchHĐToolStripMenuItem";
            this.danhSáchHĐToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.danhSáchHĐToolStripMenuItem.Text = "Danh sách HĐ và tổng tiền theo NCC và tháng ";
            this.danhSáchHĐToolStripMenuItem.Click += new System.EventHandler(this.MenuItem2_Click);
            // 
            // MenuItem3
            // 
            this.MenuItem3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItem3.Name = "MenuItem3";
            this.MenuItem3.Size = new System.Drawing.Size(163, 26);
            this.MenuItem3.Text = "Doanh thu theo quý";
            this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
            // 
            // dsKHToolStripMenuItem
            // 
            this.dsKHToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsKHToolStripMenuItem.Name = "dsKHToolStripMenuItem";
            this.dsKHToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.dsKHToolStripMenuItem.Text = "Danh sách khách hàng không mua theo tháng";
            this.dsKHToolStripMenuItem.Click += new System.EventHandler(this.dsKHToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKetQua);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1251, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.AllowUserToResizeColumns = false;
            this.dgvKetQua.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKetQua.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKetQua.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKetQua.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQua.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKetQua.Location = new System.Drawing.Point(3, 30);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.RowHeadersVisible = false;
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.RowTemplate.Height = 24;
            this.dgvKetQua.Size = new System.Drawing.Size(1245, 286);
            this.dgvKetQua.TabIndex = 0;
            this.dgvKetQua.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKetQua.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKetQua.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKetQua.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKetQua.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKetQua.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKetQua.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKetQua.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKetQua.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKetQua.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKetQua.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKetQua.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKetQua.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvKetQua.ThemeStyle.ReadOnly = true;
            this.dgvKetQua.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKetQua.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKetQua.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKetQua.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKetQua.ThemeStyle.RowsStyle.Height = 24;
            this.dgvKetQua.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKetQua.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnXuatExcel.BorderRadius = 10;
            this.btnXuatExcel.BorderThickness = 2;
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatExcel.FillColor = System.Drawing.SystemColors.ControlText;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnXuatExcel.HoverState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXuatExcel.Location = new System.Drawing.Point(1076, 310);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(160, 38);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnTke
            // 
            this.btnTke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTke.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnTke.BorderRadius = 10;
            this.btnTke.BorderThickness = 2;
            this.btnTke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTke.FillColor = System.Drawing.SystemColors.ControlText;
            this.btnTke.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTke.ForeColor = System.Drawing.Color.White;
            this.btnTke.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnTke.HoverState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTke.Location = new System.Drawing.Point(627, 310);
            this.btnTke.Name = "btnTke";
            this.btnTke.Size = new System.Drawing.Size(160, 38);
            this.btnTke.TabIndex = 2;
            this.btnTke.Text = "Thống Kê";
            this.btnTke.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.BorderRadius = 10;
            this.btnLamMoi.BorderThickness = 2;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnLamMoi.HoverState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(859, 310);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(160, 38);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtInput
            // 
            this.txtInput.BorderRadius = 5;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.DefaultText = "";
            this.txtInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInput.Location = new System.Drawing.Point(194, 24);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.PasswordChar = '\0';
            this.txtInput.PlaceholderText = "";
            this.txtInput.SelectedText = "";
            this.txtInput.Size = new System.Drawing.Size(275, 54);
            this.txtInput.TabIndex = 4;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbInput.Location = new System.Drawing.Point(23, 39);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(76, 25);
            this.lbInput.TabIndex = 6;
            this.lbInput.Text = "Tên NV";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.BorderRadius = 5;
            this.dateTimePicker.Checked = true;
            this.dateTimePicker.FillColor = System.Drawing.Color.Black;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePicker.ForeColor = System.Drawing.Color.White;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(859, 24);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(269, 54);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.Value = new System.DateTime(2022, 11, 15, 12, 57, 6, 583);
            // 
            // cboQuy
            // 
            this.cboQuy.BackColor = System.Drawing.Color.Transparent;
            this.cboQuy.BorderRadius = 5;
            this.cboQuy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboQuy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboQuy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboQuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboQuy.ItemHeight = 30;
            this.cboQuy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboQuy.Location = new System.Drawing.Point(194, 28);
            this.cboQuy.Name = "cboQuy";
            this.cboQuy.Size = new System.Drawing.Size(166, 36);
            this.cboQuy.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboQuy);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.lbQuy);
            this.panel1.Controls.Add(this.lbTgian);
            this.panel1.Controls.Add(this.lbOutPut);
            this.panel1.Controls.Add(this.lbInput);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.btnTke);
            this.panel1.Controls.Add(this.btnXuatExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 354);
            this.panel1.TabIndex = 3;
            // 
            // lbQuy
            // 
            this.lbQuy.AutoSize = true;
            this.lbQuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbQuy.Location = new System.Drawing.Point(48, 39);
            this.lbQuy.Name = "lbQuy";
            this.lbQuy.Size = new System.Drawing.Size(48, 25);
            this.lbQuy.TabIndex = 6;
            this.lbQuy.Text = "Quý";
            // 
            // lbTgian
            // 
            this.lbTgian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTgian.AutoSize = true;
            this.lbTgian.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbTgian.Location = new System.Drawing.Point(622, 39);
            this.lbTgian.Name = "lbTgian";
            this.lbTgian.Size = new System.Drawing.Size(95, 25);
            this.lbTgian.TabIndex = 6;
            this.lbTgian.Text = "Thời gian";
            // 
            // lbOutPut
            // 
            this.lbOutPut.AutoEllipsis = true;
            this.lbOutPut.AutoSize = true;
            this.lbOutPut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbOutPut.Location = new System.Drawing.Point(23, 248);
            this.lbOutPut.Name = "lbOutPut";
            this.lbOutPut.Size = new System.Drawing.Size(209, 25);
            this.lbOutPut.TabIndex = 6;
            this.lbOutPut.Text = "Tổng Tiền Nhập Hàng";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaoCao.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnBaoCao.BorderRadius = 10;
            this.btnBaoCao.BorderThickness = 2;
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaoCao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaoCao.FillColor = System.Drawing.SystemColors.ControlText;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnBaoCao.HoverState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBaoCao.Location = new System.Drawing.Point(396, 310);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(160, 38);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(27, 235);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(27, 18);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = "Quý";
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaoCao";
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHĐToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dsKHToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcel;
        private Guna.UI2.WinForms.Guna2Button btnTke;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtInput;
        private System.Windows.Forms.Label lbInput;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private Guna.UI2.WinForms.Guna2ComboBox cboQuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbQuy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label lbTgian;
        private System.Windows.Forms.Label lbOutPut;
        private Guna.UI2.WinForms.Guna2Button btnBaoCao;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKetQua;
    }
}