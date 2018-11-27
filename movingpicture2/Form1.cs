using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movingpicture2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
        }

        private void btnbutton2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
            }
        }
                                  
        private void btnbutton3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 5 < ClientRectangle.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
        }
    }
}