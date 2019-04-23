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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gFa, cti;

            cti = Convert.ToDouble(textBox1.Text);
            gFa = (cti * 1.8) + 32.0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double gCen, cti;

            cti = Convert.ToDouble(textBox1.Text);
            gCen = (cti * 32.0) + 1.8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
