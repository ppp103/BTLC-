﻿namespace BTL.DangNhapDangKi
{
    partial class DangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txttk = new BTL.DangNhapDangKi.textboxhide();
            this.txtemail = new BTL.DangNhapDangKi.textboxhide();
            this.radio1 = new BTL.Radio();
            this.txtconfirmpass = new BTL.DangNhapDangKi.Textboxxx();
            this.txtpass = new BTL.DangNhapDangKi.Textboxxx();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Xác Nhận Lại Mật Khẩu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên Đăng Nhập:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(540, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttk
            // 
            this.txttk.BackColor = System.Drawing.SystemColors.Window;
            this.txttk.BorderColor = System.Drawing.Color.Red;
            this.txttk.BorderSize = 2;
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.ForeColor = System.Drawing.Color.DimGray;
            this.txttk.Location = new System.Drawing.Point(278, 328);
            this.txttk.Margin = new System.Windows.Forms.Padding(4);
            this.txttk.Multiline = false;
            this.txttk.Name = "txttk";
            this.txttk.Padding = new System.Windows.Forms.Padding(7);
            this.txttk.PasswordChar = false;
            this.txttk.Size = new System.Drawing.Size(282, 31);
            this.txttk.TabIndex = 25;
            this.txttk.Texts = "";
            this.txttk.UnderlinedStyle = true;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Window;
            this.txtemail.BorderColor = System.Drawing.Color.Red;
            this.txtemail.BorderSize = 2;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.DimGray;
            this.txtemail.Location = new System.Drawing.Point(278, 247);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Multiline = false;
            this.txtemail.Name = "txtemail";
            this.txtemail.Padding = new System.Windows.Forms.Padding(7);
            this.txtemail.PasswordChar = false;
            this.txtemail.Size = new System.Drawing.Size(282, 31);
            this.txtemail.TabIndex = 24;
            this.txtemail.Texts = "";
            this.txtemail.UnderlinedStyle = true;
            // 
            // radio1
            // 
            this.radio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.radio1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.radio1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.radio1.BorderRadius = 20;
            this.radio1.BorderSize = 0;
            this.radio1.FlatAppearance.BorderSize = 0;
            this.radio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radio1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.ForeColor = System.Drawing.Color.White;
            this.radio1.Location = new System.Drawing.Point(164, 594);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(190, 33);
            this.radio1.TabIndex = 22;
            this.radio1.Text = "ĐĂNG KÝ";
            this.radio1.TextColor = System.Drawing.Color.White;
            this.radio1.UseVisualStyleBackColor = false;
            this.radio1.Click += new System.EventHandler(this.radio1_Click);
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.BackColor = System.Drawing.SystemColors.Window;
            this.txtconfirmpass.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.txtconfirmpass.BorderSize = 2;
            this.txtconfirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtconfirmpass.Location = new System.Drawing.Point(278, 503);
            this.txtconfirmpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfirmpass.Multiline = false;
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.Padding = new System.Windows.Forms.Padding(7);
            this.txtconfirmpass.PasswordChar = false;
            this.txtconfirmpass.Size = new System.Drawing.Size(282, 31);
            this.txtconfirmpass.TabIndex = 19;
            this.txtconfirmpass.Texts = "";
            this.txtconfirmpass.UnderlinedStyle = true;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.Window;
            this.txtpass.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.txtpass.BorderSize = 2;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtpass.Location = new System.Drawing.Point(278, 419);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Multiline = false;
            this.txtpass.Name = "txtpass";
            this.txtpass.Padding = new System.Windows.Forms.Padding(7);
            this.txtpass.PasswordChar = false;
            this.txtpass.Size = new System.Drawing.Size(282, 31);
            this.txtpass.TabIndex = 20;
            this.txtpass.Texts = "";
            this.txtpass.UnderlinedStyle = true;
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 639);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtconfirmpass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangKi";
            this.Text = "DangKi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Textboxxx txtpass;
        private Textboxxx txtconfirmpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Radio radio1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private textboxhide txtemail;
        private textboxhide txttk;
    }
}