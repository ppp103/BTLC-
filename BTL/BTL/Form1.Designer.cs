
namespace BTL
{
    partial class Form1
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
            this.btnThongKeHoaDon = new System.Windows.Forms.Button();
            this.btnHDB = new System.Windows.Forms.Button();
            this.btnThanhToanLuong = new System.Windows.Forms.Button();
            this.btnNhapHangHoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThongKeHoaDon
            // 
            this.btnThongKeHoaDon.Location = new System.Drawing.Point(12, 297);
            this.btnThongKeHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKeHoaDon.Name = "btnThongKeHoaDon";
            this.btnThongKeHoaDon.Size = new System.Drawing.Size(159, 46);
            this.btnThongKeHoaDon.TabIndex = 0;
            this.btnThongKeHoaDon.Text = "Thống Kê Hóa Đơn";
            this.btnThongKeHoaDon.UseVisualStyleBackColor = true;
            this.btnThongKeHoaDon.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHDB
            // 
            this.btnHDB.Location = new System.Drawing.Point(12, 390);
            this.btnHDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHDB.Name = "btnHDB";
            this.btnHDB.Size = new System.Drawing.Size(159, 46);
            this.btnHDB.TabIndex = 0;
            this.btnHDB.Text = "Hóa Đơn Bán";
            this.btnHDB.UseVisualStyleBackColor = true;
            this.btnHDB.Click += new System.EventHandler(this.btnHDB_Click);
            // 
            // btnThanhToanLuong
            // 
            this.btnThanhToanLuong.Location = new System.Drawing.Point(12, 538);
            this.btnThanhToanLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToanLuong.Name = "btnThanhToanLuong";
            this.btnThanhToanLuong.Size = new System.Drawing.Size(159, 46);
            this.btnThanhToanLuong.TabIndex = 0;
            this.btnThanhToanLuong.Text = "Thanh Toán Lương";
            this.btnThanhToanLuong.UseVisualStyleBackColor = true;
            this.btnThanhToanLuong.Click += new System.EventHandler(this.btnThanhToanLuong_Click);
            // 
            // btnNhapHangHoa
            // 
            this.btnNhapHangHoa.Location = new System.Drawing.Point(12, 206);
            this.btnNhapHangHoa.Name = "btnNhapHangHoa";
            this.btnNhapHangHoa.Size = new System.Drawing.Size(159, 46);
            this.btnNhapHangHoa.TabIndex = 1;
            this.btnNhapHangHoa.Text = " Nhập Hàng Hóa";
            this.btnNhapHangHoa.UseVisualStyleBackColor = true;
            this.btnNhapHangHoa.Click += new System.EventHandler(this.btnNhapHangHoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 804);
            this.Controls.Add(this.btnNhapHangHoa);
            this.Controls.Add(this.btnThanhToanLuong);
            this.Controls.Add(this.btnHDB);
            this.Controls.Add(this.btnThongKeHoaDon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThongKeHoaDon;
        private System.Windows.Forms.Button btnHDB;
        private System.Windows.Forms.Button btnThanhToanLuong;
        private System.Windows.Forms.Button btnNhapHangHoa;
    }
}

