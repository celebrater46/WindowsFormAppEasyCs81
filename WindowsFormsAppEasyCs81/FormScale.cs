using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs81
{
    public partial class FormScale : Form
    {
        private Image img;
        private RadioButton rb1, rb2, rb3;
        private GroupBox gb;
        private int i;
        
        public FormScale()
        {
            InitializeComponent();
            this.Text = "拡大縮小やで！";
            this.Width = 300;
            this.Height = 300;
            img = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppEasyCs81\\WindowsFormsAppEasyCs81\\img\\sunsymbol3.png");

            rb1 = new RadioButton();
            rb1.Text = "普通やで";
            rb1.Dock = DockStyle.Bottom;
            
            rb2 = new RadioButton();
            rb2.Text = "拡大やで";
            rb2.Dock = DockStyle.Bottom;
            
            rb3 = new RadioButton();
            rb3.Text = "縮小やで";
            rb3.Dock = DockStyle.Bottom;

            rb1.Checked = true;

            gb = new GroupBox();
            gb.Text = "種類やで";
            gb.Dock = DockStyle.Bottom;

            rb1.Parent = gb;
            rb2.Parent = gb;
            rb3.Parent = gb;
            gb.Parent = this;

            rb1.Click += new EventHandler(ClickRb);
            rb2.Click += new EventHandler(ClickRb);
            rb3.Click += new EventHandler(ClickRb);
            this.Paint += new PaintEventHandler(PaintImg);
        }

        public void ClickRb(Object sender, EventArgs e)
        {
            RadioButton temp = (RadioButton) sender;
            if (temp == rb1)
            {
                i = 1;
            }
            else if (temp == rb2)
            {
                i = 2;
            }
            else if (temp == rb3)
            {
                i = 3;
            }
            this.Invalidate();
        }

        public void PaintImg(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (i == 1)
            {
                // g.DrawImage(img, 0, 0, img.Width, img.Height);
                g.DrawImage(img, 0, 0, img.Width, img.Height); // True Scale
            }
            else if (i == 2)
            {
                g.DrawImage(img, 0, 0, img.Width * 2, img.Height * 2);
            }
            else if (i == 3)
            {
                g.DrawImage(img, 0, 0, img.Width / 2, img.Height / 2);
            }
        }
    }
}