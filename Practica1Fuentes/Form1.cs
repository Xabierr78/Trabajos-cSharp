using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1Fuentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        
        private void button1_Click(object sender, EventArgs e)
        {

            Font currentFont = label1.Font;
            Font newFont = new Font(currentFont, FontStyle.Bold);
            label1.Font = newFont;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Font currentFont = label1.Font;
            Font newFont = new Font(currentFont, currentFont.Style | FontStyle.Italic);
            label1.Font = newFont;

          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font currentFont = label1.Font;
            Font newFont = new Font(currentFont, currentFont.Style | FontStyle.Underline);
            label1.Font = newFont;

        }
    }
}
