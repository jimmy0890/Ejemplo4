using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool contenido = true;
        public int i=5265;
        public int [] miarreglo = {1,5,6,2};
        public string texto;
        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "Hello World";
            textBox2.Text = contenido.ToString();
            textBox3.Text = i.ToString();
            for (int j=0; j<miarreglo.Length; j++)
            {
                texto = texto + " " + miarreglo[j].ToString();
            }
            textBox4.Text = texto;
        }

    }
}
