
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Ma"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HDNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(658, 42);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Thống kê hóa đơn";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 455);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 28);
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
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(12, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(658, 329);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 483);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormThongKeHoaDon";
            this.Text = "FormThongKeHoaDon";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HDNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DTToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
    }
}