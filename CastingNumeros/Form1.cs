using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CastingNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxEntero.Text = "0";
            textBoxReal.Text = "0"; 
        }

        private void btnEntero_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxEntero.Text);
            float b = float.Parse(textBoxReal.Text);

            int resultadoIntDoble = a * 2;
            int resultadoIntMitad = a / 2;

            textBoxDoble.Text = resultadoIntDoble.ToString();
            textBoxMitad.Text = resultadoIntMitad.ToString();




        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            float b = float.Parse(textBoxReal.Text);
            float resultadoFloatDoble = b * 2;
            float resultadoFloatMitad = b / 2;

            textBoxDoble.Text = resultadoFloatDoble.ToString();
            textBoxMitad.Text = resultadoFloatMitad.ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
