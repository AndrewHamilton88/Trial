using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stage_Picture_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Image RotateImage(Image img)
        {
            //create an object that we can use to examine an image file
            using (img)
            {
                //rotate the picture by 90 degrees and re-save the picture as a Jpeg
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            return img;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RotateImage(pictureBox1.Image);
        }
    }
}
