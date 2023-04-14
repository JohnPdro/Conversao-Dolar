using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversao_Dolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxReal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBoxDolar.Text == "")
            {
                MessageBox.Show("Por favor insira um valor!", "Aviso!", MessageBoxButtons.OK);
                textBoxDolar.Focus();
                return;
            }

            textBoxReal.Text = (Convert.ToDouble(textBoxDolar.Text) * 4.94).ToString();


        }

        private void textBoxDolar_TextChanged(object sender, EventArgs e)
        {
            
           

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxReal.Clear();
            textBoxDolar.Clear();
        }
    }
}
