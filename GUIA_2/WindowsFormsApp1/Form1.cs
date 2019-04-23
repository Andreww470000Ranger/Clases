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
    public partial class Form1 : Form
    {
        private MessageBoxButtons TipoDeBoton = MessageBoxButtons.OK;
        private MessageBoxIcon TipoDeIcono = MessageBoxIcon.Error;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == radioButton1)
            {
                TipoDeBoton = MessageBoxButtons.OK;
            }
            else if(sender == radioButton2)
            {
                TipoDeBoton = MessageBoxButtons.OKCancel;
            }
            else if(sender == radioButton3)
            {
                TipoDeBoton = MessageBoxButtons.YesNo;
            }
            else if(sender == radioButton4)
            {
                TipoDeBoton = MessageBoxButtons.YesNoCancel;
            }
            else if(sender == radioButton5)
            {
                TipoDeBoton = MessageBoxButtons.RetryCancel;
            }
            else
            {
                TipoDeBoton = MessageBoxButtons.AbortRetryIgnore;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == radioButton7)
            {
                TipoDeIcono = MessageBoxIcon.Information;
            }
            else if(sender == radioButton8)
            {
                TipoDeIcono = MessageBoxIcon.Exclamation;
            }
            else if(sender == radioButton9)
            {
                TipoDeIcono = MessageBoxIcon.Question;
            }
            else
            {
                TipoDeIcono = MessageBoxIcon.Error;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Mensaje que se mostrará","Titulo de la ventana", TipoDeBoton, TipoDeIcono);

            switch (result)
            {
                case DialogResult.OK:
                    label2.Text = "Se selecionó OK";
                break;

                case DialogResult.Cancel:
                    label2.Text = "Se selecionó Cancelar";
                break;

                case DialogResult.Yes:
                    label2.Text = "Se selecionó YES";
                break;

                case DialogResult.No:
                    label2.Text = "Se selecionó No";
                break;

                case DialogResult.Ignore:
                    label2.Text = "Se selecionó Ignorar";
                break;

                case DialogResult.Abort:
                    label2.Text = "Se selecionó Abortar";
                break;

                case DialogResult.Retry:
                    label2.Text = "Se selecionó Reintentar";
                break;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
