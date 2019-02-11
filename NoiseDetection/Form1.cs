using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoiseDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                pictureBox1.ImageLocation = path;
            }
            pictureBox2.Image = FaindNoise.generateNoiseImage(openFileDialog1.FileName);
        }
    }
}
