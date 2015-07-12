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
        Image<Bgr, Byte> im;
        Capture cap;
        public Form1()
        {
            InitializeComponent();
            cap = new Capture(); // conexión con la primera cámara
            // o cap = new Capture(0); -- idéntico al anterior
            // o cap = new Capture(“miVideo.avi”); -- carga un vídeo
        }

        private void button1_Click(object sender, EventArgs e)
        {
            im = cap.QueryFrame();
            // im = cap.RetieveBgrFrame(); -- EmguCV 2.4 en adelante
            imageBox1.Image = im;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            cap.Dispose(); 
        }
    }
}
