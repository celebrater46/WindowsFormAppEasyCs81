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
        private Button btn1, btn2;
        public Form1()
        {
            InitializeComponent();
            this.Text = "画像テストやで！";
            this.Width = 250;
            this.Height = 200;

            btn1 = new Button();
            btn1.Text = "Rotate";
            btn1.Width = 40;
            btn1.Height = 20;

            btn1.Click += new EventHandler(ClickBtn);
        }

        public void ClickBtn(Object sender, EventArgs e)
        {
            Button temp = (Button) sender;
            if (temp == btn1)
            {
                FormRotate fr = new FormRotate();
                fr.ShowDialog();
            }
            else
            {
                FormScale fs = new FormScale();
                fs.ShowDialog();
            }
        }
    }
}