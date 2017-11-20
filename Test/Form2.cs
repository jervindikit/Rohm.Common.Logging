using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form2 : Form
    {
        Image img = Image.FromFile(@"C:\Users\JERVIN-SYSTEM\Pictures\LOGO\REQUEST.jpg");
        //Image img = Image.FromFile(@"C:\Users\JERVIN-SYSTEM\Desktop\STAMP\Stamp.jpg");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Width = img.Width + 40;
            this.Height = img.Height + 63;
            pictureBox1.Image = img;
        }
    }
}
