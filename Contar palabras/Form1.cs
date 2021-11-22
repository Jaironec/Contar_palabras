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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            int i = 0;
            string frase = textIngreso.Text;
            this.textRespuesta.Clear();
            while (frase[i] == ' ') i++;
            if (frase[i] == '.') num--;
            while (frase[i] != '.')
            {
                if(frase[i]==' ')
                {
                    num++;
                    while (frase[i] == ' ') i++;
                    if (frase[i] == '.') num++;
                }
                else
                {
                    i++;
                }
            }
            num++;
            Console.WriteLine($"{0}", num);
            this.textRespuesta.Text = num.ToString();
        }

    }
    }