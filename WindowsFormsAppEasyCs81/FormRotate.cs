using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs81
{
    public partial class FormRotate : Form
    {
        private Image img;
        
        public FormRotate()
        {
            InitializeComponent();
            this.Text = "画像テストやで！";
            this.Width = 250;
            this.Height = 200;

            img = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppEasyCs81\\WindowsFormsAppEasyCs81\\img\\sunsymbol3.png");
            // img.Width = 32;
            // img.Height = 32;

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
            // g.DrawImage(img, 0, 0);
            g.DrawImage(img, 0, 0, img.Width, img.Height); // True Scale
        }
    }
}