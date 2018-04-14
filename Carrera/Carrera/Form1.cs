using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
            
        }

        private string Carreritas(Corredor c1, Corredor c2)
        {
            string res="";
            while(c1.Pasos<100 && c2.Pasos<100)
            {
                c1.Pasos += c1.Correr();
                c2.Pasos += c2.Correr();
                res += c1.Nombre + " esta en: " + c1.Pasos + Environment.NewLine +
                    c2.Nombre + " esta en: " + c2.Pasos + Environment.NewLine;
            }
            if(c1.Pasos>=100 && c2.Pasos>=100)
            {
                res += "EMPATE";
            }
            else if(c1.Pasos<c2.Pasos)
            {
                res += "EL GANADOR ES: " + c2.Nombre;
            }
            else
            {
                res += "EL GANADOR ES: " + c1.Nombre;
            }
            return res;
        }

        private void bttnComenzar_Click(object sender, EventArgs e)
        {
            string c1 = txtC1.Text;
            string c2 = txtC2.Text;
            Corredor cc1 = new Corredor(c1);
            Corredor cc2 = new Corredor(c2);
            txtRes.Text= Carreritas(cc1, cc2);
        }
    }
}
