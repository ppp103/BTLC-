
namespace BTL
{
    partial class FormThongKeHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HDNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(233, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HDBToolStripMenuItem,
            this.HDNToolStripMenuItem,
            this.DTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 393);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HDBToolStripMenuItem
            // 
            this.HDBToolStripMenuItem.Name = "HDBToolStripMenuItem";
            this.HDBToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.HDBToolStripMenuItem.Text = "Hóa đơn bán";
            this.HDBToolStripMenuItem.Click += new System.EventHandler(this.HDBToolStripMenuItem_Click);
            // 
            // HDNToolStripMenuItem
            // 
            this.HDNToolStripMenuItem.Name = "HDNToolStripMenuItem";
            this.HDNToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.HDNToolStripMenuItem.Text = "Hóa đơn nhập";
            this.HDNToolStripMenuItem.Click += new System.EventHandler(this.HDNToolStripMenuItem_Click);
            // 
            // DTToolStripMenuItem
            // 
            this.DTToolStripMenuItem.Name = "DTToolStripMenuItem";
            this.DTToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.DTToolStripMenuItem.Text = "Doanh thu";
            this.DTToolStripMenuItem.Click += new System.EventHandler(this.DTToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(958, 272);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label2.MinimumSize = new System.Drawing.Size(958, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(958, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "THỐNG KÊ HÓA ĐƠN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormThongKeHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongKeHoaDon";
            this.Load += new System.EventHandler(this.FormThongKeHoaDon_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HDNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DTToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}