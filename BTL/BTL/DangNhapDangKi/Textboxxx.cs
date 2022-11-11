using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace BTL.DangNhapDangKi
{
    public partial class Textboxxx : UserControl
    {
        private System.Drawing.Color borderColor = System.Drawing.Color.MediumAquamarine;
        private int borderSize = 2;
        private bool underlinedStyle = false;

        public Textboxxx()
        {
            InitializeComponent();
        }
        [Category("tb Code advance")]
        public System.Drawing.Color BorderColor { get { return borderColor; } set { borderColor = value;this.Invalidate(); } }
        [Category("tb Code advance")]
        public int BorderSize { get { return borderSize; } set { borderSize = value; this.Invalidate(); } }
        [Category("tb Code advance")]
        public bool UnderlinedStyle { get { return underlinedStyle; } set { underlinedStyle = value; this.Invalidate(); } }
        [Category("tb Code advance")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
        [Category("tb Code advance")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
       
        [Category("tb Code advance")]
        public  string Texts 
        { get { return textBox1.Text; }
            set { textBox1.Text = value; }
      }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            using (System.Drawing.Pen penBorder = new System.Drawing.Pen(borderColor, borderSize))
            {
                penBorder.Alignment=  System.Drawing.Drawing2D.PenAlignment.Center;
                if (underlinedStyle) 
                {
                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F,this.Height-0.5F);

                }
            }
        }
        protected override void OnResize(EventArgs e)//ghi de
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if(textBox1.Multiline==false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top+this.Padding.Bottom;
            }
        }

    }
}
