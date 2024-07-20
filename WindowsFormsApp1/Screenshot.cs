using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Screenshot : Form
    {
        public Screenshot()
        {
            InitializeComponent();
            pictureBox1.Image = Form1.image;
        }

        public Screenshot(Image scr)
        {
            InitializeComponent();
            pictureBox1.Image = scr;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
