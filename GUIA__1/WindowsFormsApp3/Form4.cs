using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        int x, N, suma;

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            N = int.Parse(textBox1.Text);

            for(x = 1; x <= N; x++)
            {
                suma = x + suma;
                if(checkBox1.Checked == true)
                {
                    listBox1.Items.Add("Sumando " + x + " suma parcial " + suma);
                }
            }

        }
    }
}
