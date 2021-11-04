using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs81
{
    public partial class Form1 : Form
    {
        private Image img;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "画像テストやで！";
            this.Width = 250;
            this.Height = 200;

            img = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppEasyCs81\\WindowsFormsAppEasyCs81\\img\\sunsymbol3.png");

            this.Click += new EventHandler(ClickForm);
            this.Paint += new PaintEventHandler(PaintForm);
        }

        public void ClickForm(Object sender, EventArgs e)
        {
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.Invalidate();
        }

        public void PaintForm(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(img, 0, 0);
        }
    }
}