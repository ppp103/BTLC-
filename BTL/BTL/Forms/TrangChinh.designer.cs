﻿
namespace HomePage
{
    partial class TrangChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChinh));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnNhapHoaDonBan = new FontAwesome.Sharp.IconButton();
            this.panelTkeHoaDon = new System.Windows.Forms.Panel();
            this.btnHoaDonNhap = new FontAwesome.Sharp.IconButton();
            this.btnHoaDonBan = new FontAwesome.Sharp.IconButton();
            this.btnTkeHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnNhapHang = new FontAwesome.Sharp.IconButton();
            this.btnTkeHangHoa = new FontAwesome.Sharp.IconButton();
            this.iconHome = new FontAwesome.Sharp.IconButton();
            this.panelBlank = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerTkeHoaDon = new System.Windows.Forms.Timer(this.components);
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.iconTieuDe = new FontAwesome.Sharp.IconButton();
            this.panelForm = new System.Windows.Forms.Panel();
            this.iconLogOut = new FontAwesome.Sharp.IconButton();
            this.iconGear = new FontAwesome.Sharp.IconButton();
            this.iconBell = new FontAwesome.Sharp.IconButton();
            this.iconTwitter = new FontAwesome.Sharp.IconButton();
            this.iconIns = new FontAwesome.Sharp.IconButton();
            this.iconFacebook = new FontAwesome.Sharp.IconButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelTkeHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.PeachPuff;
            this.panelSideMenu.Controls.Add(this.btnNhapHoaDonBan);
            this.panelSideMenu.Controls.Add(this.panelTkeHoaDon);
            this.panelSideMenu.Controls.Add(this.btnNhapHang);
            this.panelSideMenu.Controls.Add(this.btnTkeHangHoa);
            this.panelSideMenu.Controls.Add(this.iconHome);
            this.panelSideMenu.Controls.Add(this.panelBlank);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(289, 806);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnNhapHoaDonBan
            // 
            this.btnNhapHoaDonBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapHoaDonBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapHoaDonBan.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnNhapHoaDonBan.FlatAppearance.BorderSize = 0;
            this.btnNhapHoaDonBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnNhapHoaDonBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnNhapHoaDonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHoaDonBan.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnNhapHoaDonBan.ForeColor = System.Drawing.Color.Black;
            this.btnNhapHoaDonBan.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
            this.btnNhapHoaDonBan.IconColor = System.Drawing.Color.DimGray;
            this.btnNhapHoaDonBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapHoaDonBan.IconSize = 25;
            this.btnNhapHoaDonBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHoaDonBan.Location = new System.Drawing.Point(0, 363);
            this.btnNhapHoaDonBan.Name = "btnNhapHoaDonBan";
            this.btnNhapHoaDonBan.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.btnNhapHoaDonBan.Size = new System.Drawing.Size(289, 65);
            this.btnNhapHoaDonBan.TabIndex = 9;
            this.btnNhapHoaDonBan.Text = "Lập hóa đơn bán";
            this.btnNhapHoaDonBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHoaDonBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapHoaDonBan.UseVisualStyleBackColor = true;
            this.btnNhapHoaDonBan.Click += new System.EventHandler(this.btnNhapHoaDonBan_Click);
            // 
            // panelTkeHoaDon
            // 
            this.panelTkeHoaDon.Controls.Add(this.btnHoaDonNhap);
            this.panelTkeHoaDon.Controls.Add(this.btnHoaDonBan);
            this.panelTkeHoaDon.Controls.Add(this.btnTkeHoaDon);
            this.panelTkeHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTkeHoaDon.Location = new System.Drawing.Point(0, 295);
            this.panelTkeHoaDon.MaximumSize = new System.Drawing.Size(0, 204);
            this.panelTkeHoaDon.MinimumSize = new System.Drawing.Size(0, 68);
            this.panelTkeHoaDon.Name = "panelTkeHoaDon";
            this.panelTkeHoaDon.Size = new System.Drawing.Size(289, 68);
            this.panelTkeHoaDon.TabIndex = 4;
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.BackColor = System.Drawing.Color.MistyRose;
            this.btnHoaDonNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDonNhap.FlatAppearance.BorderSize = 0;
            this.btnHoaDonNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnHoaDonNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnHoaDonNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonNhap.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnHoaDonNhap.IconColor = System.Drawing.Color.DimGray;
            this.btnHoaDonNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDonNhap.IconSize = 25;
            this.btnHoaDonNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDonNhap.Location = new System.Drawing.Point(0, 136);
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            this.btnHoaDonNhap.Padding = new System.Windows.Forms.Padding(30, 0, 21, 0);
            this.btnHoaDonNhap.Size = new System.Drawing.Size(289, 68);
            this.btnHoaDonNhap.TabIndex = 1;
            this.btnHoaDonNhap.Text = "Hóa đơn nhập";
            this.btnHoaDonNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDonNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDonNhap.UseVisualStyleBackColor = false;
            this.btnHoaDonNhap.Click += new System.EventHandler(this.btnHoaDonNhap_Click);
            // 
            // btnHoaDonBan
            // 
            this.btnHoaDonBan.BackColor = System.Drawing.Color.MistyRose;
            this.btnHoaDonBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDonBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDonBan.FlatAppearance.BorderSize = 0;
            this.btnHoaDonBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnHoaDonBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnHoaDonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonBan.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnHoaDonBan.IconColor = System.Drawing.Color.DimGray;
            this.btnHoaDonBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDonBan.IconSize = 25;
            this.btnHoaDonBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDonBan.Location = new System.Drawing.Point(0, 68);
            this.btnHoaDonBan.Name = "btnHoaDonBan";
            this.btnHoaDonBan.Padding = new System.Windows.Forms.Padding(30, 0, 21, 0);
            this.btnHoaDonBan.Size = new System.Drawing.Size(289, 68);
            this.btnHoaDonBan.TabIndex = 0;
            this.btnHoaDonBan.Text = "Hóa đơn bán";
            this.btnHoaDonBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDonBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDonBan.UseVisualStyleBackColor = false;
            this.btnHoaDonBan.Click += new System.EventHandler(this.btnHoaDonBan_Click);
            // 
            // btnTkeHoaDon
            // 
            this.btnTkeHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTkeHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTkeHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnTkeHoaDon.FlatAppearance.BorderSize = 0;
            this.btnTkeHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnTkeHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnTkeHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTkeHoaDon.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnTkeHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnTkeHoaDon.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btnTkeHoaDon.IconColor = System.Drawing.Color.DimGray;
            this.btnTkeHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTkeHoaDon.IconSize = 25;
            this.btnTkeHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTkeHoaDon.Location = new System.Drawing.Point(0, 0);
            this.btnTkeHoaDon.Name = "btnTkeHoaDon";
            this.btnTkeHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.btnTkeHoaDon.Size = new System.Drawing.Size(289, 68);
            this.btnTkeHoaDon.TabIndex = 0;
            this.btnTkeHoaDon.Text = "Thống kê hóa đơn";
            this.btnTkeHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTkeHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTkeHoaDon.UseVisualStyleBackColor = true;
            this.btnTkeHoaDon.Click += new System.EventHandler(this.btnTkeHoaDon_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapHang.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnNhapHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnNhapHang.ForeColor = System.Drawing.Color.Black;
            this.btnNhapHang.IconChar = FontAwesome.Sharp.IconChar.PersonArrowDownToLine;
            this.btnNhapHang.IconColor = System.Drawing.Color.DimGray;
            this.btnNhapHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapHang.IconSize = 25;
            this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.Location = new System.Drawing.Point(0, 230);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.btnNhapHang.Size = new System.Drawing.Size(289, 65);
            this.btnNhapHang.TabIndex = 3;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnTkeHangHoa
            // 
            this.btnTkeHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTkeHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTkeHangHoa.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnTkeHangHoa.FlatAppearance.BorderSize = 0;
            this.btnTkeHangHoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnTkeHangHoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnTkeHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTkeHangHoa.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnTkeHangHoa.ForeColor = System.Drawing.Color.Black;
            this.btnTkeHangHoa.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnTkeHangHoa.IconColor = System.Drawing.Color.DimGray;
            this.btnTkeHangHoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTkeHangHoa.IconSize = 25;
            this.btnTkeHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTkeHangHoa.Location = new System.Drawing.Point(0, 165);
            this.btnTkeHangHoa.Name = "btnTkeHangHoa";
            this.btnTkeHangHoa.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.btnTkeHangHoa.Size = new System.Drawing.Size(289, 65);
            this.btnTkeHangHoa.TabIndex = 2;
            this.btnTkeHangHoa.Text = "Thống kê hàng hóa";
            this.btnTkeHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTkeHangHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTkeHangHoa.UseVisualStyleBackColor = true;
            this.btnTkeHangHoa.Click += new System.EventHandler(this.btnTkeHangHoa_Click);
            // 
            // iconHome
            // 
            this.iconHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconHome.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.iconHome.FlatAppearance.BorderSize = 0;
            this.iconHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.iconHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.iconHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconHome.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.iconHome.ForeColor = System.Drawing.Color.Black;
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconHome.IconColor = System.Drawing.Color.DimGray;
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.IconSize = 25;
            this.iconHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconHome.Location = new System.Drawing.Point(0, 100);
            this.iconHome.Name = "iconHome";
            this.iconHome.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.iconHome.Size = new System.Drawing.Size(289, 65);
            this.iconHome.TabIndex = 4;
            this.iconHome.Text = "Trang chủ";
            this.iconHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconHome.UseVisualStyleBackColor = true;
            this.iconHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelBlank
            // 
            this.panelBlank.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBlank.Location = new System.Drawing.Point(0, 0);
            this.panelBlank.Name = "panelBlank";
            this.panelBlank.Size = new System.Drawing.Size(289, 100);
            this.panelBlank.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(37, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.logo_Click);
            // 
            // timerTkeHoaDon
            // 
            this.timerTkeHoaDon.Interval = 5;
            this.timerTkeHoaDon.Tick += new System.EventHandler(this.timerTkeHoaDon_Tick);
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.MistyRose;
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Location = new System.Drawing.Point(289, 0);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1512, 18);
            this.panelTieuDe.TabIndex = 1;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieuDe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTieuDe.Location = new System.Drawing.Point(299, 6);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(134, 31);
            this.labelTieuDe.TabIndex = 1;
            this.labelTieuDe.Text = "Trang chủ";
            // 
            // iconTieuDe
            // 
            this.iconTieuDe.FlatAppearance.BorderSize = 0;
            this.iconTieuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTieuDe.ForeColor = System.Drawing.Color.DarkSalmon;
            this.iconTieuDe.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconTieuDe.IconColor = System.Drawing.Color.DimGray;
            this.iconTieuDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTieuDe.IconSize = 35;
            this.iconTieuDe.Location = new System.Drawing.Point(226, 6);
            this.iconTieuDe.Name = "iconTieuDe";
            this.iconTieuDe.Size = new System.Drawing.Size(54, 36);
            this.iconTieuDe.TabIndex = 0;
            this.iconTieuDe.UseVisualStyleBackColor = true;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.ForeColor = System.Drawing.Color.DimGray;
            this.panelForm.Location = new System.Drawing.Point(289, 18);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1512, 788);
            this.panelForm.TabIndex = 5;
            // 
            // iconLogOut
            // 
            this.iconLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconLogOut.FlatAppearance.BorderSize = 0;
            this.iconLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.iconLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLogOut.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconLogOut.IconColor = System.Drawing.Color.DimGray;
            this.iconLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogOut.IconSize = 35;
            this.iconLogOut.Location = new System.Drawing.Point(1062, 4);
            this.iconLogOut.Name = "iconLogOut";
            this.iconLogOut.Size = new System.Drawing.Size(40, 41);
            this.iconLogOut.TabIndex = 8;
            this.iconLogOut.UseVisualStyleBackColor = true;
            this.iconLogOut.Click += new System.EventHandler(this.iconLogOut_Click_1);
            // 
            // iconGear
            // 
            this.iconGear.FlatAppearance.BorderSize = 0;
            this.iconGear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.iconGear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGear.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconGear.IconColor = System.Drawing.Color.DimGray;
            this.iconGear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGear.IconSize = 35;
            this.iconGear.Location = new System.Drawing.Point(1002, 4);
            this.iconGear.Name = "iconGear";
            this.iconGear.Size = new System.Drawing.Size(40, 41);
            this.iconGear.TabIndex = 8;
            this.iconGear.UseVisualStyleBackColor = true;
            // 
            // iconBell
            // 
            this.iconBell.FlatAppearance.BorderSize = 0;
            this.iconBell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.iconBell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBell.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconBell.IconColor = System.Drawing.Color.DimGray;
            this.iconBell.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBell.IconSize = 35;
            this.iconBell.Location = new System.Drawing.Point(940, 4);
            this.iconBell.Name = "iconBell";
            this.iconBell.Size = new System.Drawing.Size(40, 41);
            this.iconBell.TabIndex = 8;
            this.iconBell.UseVisualStyleBackColor = true;
            // 
            // iconTwitter
            // 
            this.iconTwitter.FlatAppearance.BorderSize = 0;
            this.iconTwitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.iconTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTwitter.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            this.iconTwitter.IconColor = System.Drawing.Color.DimGray;
            this.iconTwitter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTwitter.IconSize = 35;
            this.iconTwitter.Location = new System.Drawing.Point(831, 4);
            this.iconTwitter.Name = "iconTwitter";
            this.iconTwitter.Size = new System.Drawing.Size(40, 41);
            this.iconTwitter.TabIndex = 8;
            this.iconTwitter.UseVisualStyleBackColor = true;
            // 
            // iconIns
            // 
            this.iconIns.FlatAppearance.BorderSize = 0;
            this.iconIns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.iconIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconIns.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            this.iconIns.IconColor = System.Drawing.Color.DimGray;
            this.iconIns.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconIns.IconSize = 35;
            this.iconIns.Location = new System.Drawing.Point(771, 4);
            this.iconIns.Name = "iconIns";
            this.iconIns.Size = new System.Drawing.Size(40, 41);
            this.iconIns.TabIndex = 8;
            this.iconIns.UseVisualStyleBackColor = true;
            // 
            // iconFacebook
            // 
            this.iconFacebook.FlatAppearance.BorderSize = 0;
            this.iconFacebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.iconFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconFacebook.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.iconFacebook.IconColor = System.Drawing.Color.DimGray;
            this.iconFacebook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFacebook.IconSize = 35;
            this.iconFacebook.Location = new System.Drawing.Point(710, 4);
            this.iconFacebook.Name = "iconFacebook";
            this.iconFacebook.Size = new System.Drawing.Size(40, 41);
            this.iconFacebook.TabIndex = 8;
            this.iconFacebook.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.iconLogOut);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.iconTieuDe);
            this.panelHeader.Controls.Add(this.labelTieuDe);
            this.panelHeader.Controls.Add(this.iconTwitter);
            this.panelHeader.Controls.Add(this.iconGear);
            this.panelHeader.Controls.Add(this.iconBell);
            this.panelHeader.Controls.Add(this.iconFacebook);
            this.panelHeader.Controls.Add(this.iconIns);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(289, 18);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1512, 212);
            this.panelHeader.TabIndex = 9;
            // 
            // TrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1801, 806);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTieuDe);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "TrangChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nước hoa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelTkeHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private FontAwesome.Sharp.IconButton iconHome;
        private FontAwesome.Sharp.IconButton btnTkeHangHoa;
        private FontAwesome.Sharp.IconButton btnHoaDonNhap;
        private FontAwesome.Sharp.IconButton btnHoaDonBan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerTkeHoaDon;
        private FontAwesome.Sharp.IconButton btnTkeHoaDon;
        private System.Windows.Forms.Panel panelTkeHoaDon;
        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Label labelTieuDe;
        private FontAwesome.Sharp.IconButton iconTieuDe;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelBlank;
        private FontAwesome.Sharp.IconButton btnNhapHang;
        private FontAwesome.Sharp.IconButton iconFacebook;
        private FontAwesome.Sharp.IconButton iconLogOut;
        private FontAwesome.Sharp.IconButton iconGear;
        private FontAwesome.Sharp.IconButton iconBell;
        private FontAwesome.Sharp.IconButton iconTwitter;
        private FontAwesome.Sharp.IconButton iconIns;
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton btnNhapHoaDonBan;
    }
}
