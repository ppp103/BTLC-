namespace BTL.DangNhapDangKi
{
    partial class Quenmatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quenmatkhau));
            this.radio1 = new BTL.Radio();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxhide1 = new BTL.DangNhapDangKi.textboxhide();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.radio1.Location = new System.Drawing.Point(138, 382);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(179, 33);
            this.radio1.TabIndex = 32;
            this.radio1.Text = "LẤY LẠI MẬT KHẨU";
            this.radio1.TextColor = System.Drawing.Color.White;
            this.radio1.UseVisualStyleBackColor = false;
            this.radio1.Click += new System.EventHandler(this.radio1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Kết Quả :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(427, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxhide1
            // 
            this.textboxhide1.BackColor = System.Drawing.SystemColors.Window;
            this.textboxhide1.BorderColor = System.Drawing.Color.Red;
            this.textboxhide1.BorderSize = 2;
            this.textboxhide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxhide1.ForeColor = System.Drawing.Color.DimGray;
            this.textboxhide1.Location = new System.Drawing.Point(108, 252);
            this.textboxhide1.Margin = new System.Windows.Forms.Padding(4);
            this.textboxhide1.Multiline = false;
            this.textboxhide1.Name = "textboxhide1";
            this.textboxhide1.Padding = new System.Windows.Forms.Padding(7);
            this.textboxhide1.PasswordChar = false;
            this.textboxhide1.Size = new System.Drawing.Size(316, 31);
            this.textboxhide1.TabIndex = 34;
            this.textboxhide1.Texts = "";
            this.textboxhide1.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Email:";
            // 
            // Quenmatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(239)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(466, 436);
            this.Controls.Add(this.textboxhide1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quenmatkhau";
            this.Text = "Quenmatkhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Radio radio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private textboxhide textboxhide1;
        private System.Windows.Forms.Label label2;
    }
}