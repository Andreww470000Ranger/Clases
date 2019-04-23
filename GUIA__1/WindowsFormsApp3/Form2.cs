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
    public partial class Form2 : Form
    { 
        public Form2()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Aqua;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Usuario, passw;

            Usuario = textBox1.Text.TrimEnd();

            passw = textBox2.Text.TrimEnd();

            if(Usuario == "UTEC" && passw == "programacion1")
            {
                MessageBox.Show("Bienvenido al sistema de la UTEC");
            }
            else
            {
                MessageBox.Show("Datos ingresados de manera erronea");
            }

            if(Usuario == "" || passw == "")
            {
                MessageBox.Show("No se pueden dejar campos en blanco...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
