using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonHelloWorld_Click(object sender, EventArgs e)
        {
            LabelHello.Text = "Hola, Mundo!";
            LabelHello.BackColor = Color.BlueViolet;
            LabelHello.TextAlign = ContentAlignment.MiddleCenter;
            LabelHello.BorderStyle = BorderStyle.FixedSingle; 
            
            
        }

        private void LabelHello_Click(object sender, EventArgs e)
        {



        }
    }
}
