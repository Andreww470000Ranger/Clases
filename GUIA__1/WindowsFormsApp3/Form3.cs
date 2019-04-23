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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Total = 0;

            if(radioButton1.Checked == true)
            {
                Total = Total + 50.00;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }

            if (radioButton2.Checked == true)
            {
                Total = Total + 100.00;
                radioButton1.Checked = false;
                radioButton3.Checked = false;
            }

            if (radioButton3.Checked == true)
            {
                Total = Total + 150.00;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }

            if(checkBox1.Checked == true)
            {
                Total = Total + 5.00;
            }

            if (checkBox2.Checked == true)
            {
                Total = Total + 15.00;
            }

            if (checkBox3.Checked == true)
            {
                Total = Total + 20.00;
            }

            MessageBox.Show("El gasto por el envío es de: $" + Total);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
