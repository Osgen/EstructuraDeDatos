using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numPerf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Anliza el numero
        public Boolean numeroPerf(int n)
        {
            int suma = 0;
            for(int i=1; i<n; i++)
            {
                if(n%(n-i)==0)
                {
                    suma += (n - i);
                }
            }

            //Si es perfecto el numero
                return suma==n?true:false;
        }

        public void Ejecutar()
        {
            string numeros = "";
            for (int i = 1; i < 10000; i++)
            {
                if (numeroPerf(10000 - i))
                {
                    numeros += Convert.ToString(10000 - i) + ", ";
                }
            }

            textBox1.Text = numeros;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejecutar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //NADA
        }
    }
}
