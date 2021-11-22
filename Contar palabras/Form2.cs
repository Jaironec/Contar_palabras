using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contar_palabras
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string derecho = textIngreso.Text;
            string revez="";
            this.textSalida.Clear();
            for (int x = derecho.Length - 1; x >= 0; x--)
            {
                revez += derecho[x];
            }
            Console.WriteLine($"{0}", revez);
            this.textSalida.Text = revez.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
