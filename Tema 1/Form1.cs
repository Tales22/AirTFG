using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;




namespace Tema_1
{
    public partial class Form1 : Form
    {
        private Capture capture;  //variable here

        public Form1()
        {
            InitializeComponent();
            capture = new Capture(0);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled); // toggle start/stop
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (Image nextFrame = capture.QueryFrame().ToBitmap())
            {
                pictureBox1.Image = nextFrame;
            }
        }
    }
}
