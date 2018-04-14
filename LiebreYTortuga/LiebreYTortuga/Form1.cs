using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiebreYTortuga
{
    public partial class Form1 : Form
    {
        Liebre l;
        Tortuga t;
        public Form1()
        {
            InitializeComponent();

            l = new Liebre();
            t = new Tortuga();
        }

        public string Carrera(int meta)
        {
            string str = "";
            //CORRER HASTA QUE ALGUNO LLEGE A LA META
           while(l.Pasos<80 && t.Pasos<80)
            {
                l.correr();
                str += "Liebre esta en: " + l.Pasos + Environment.NewLine;
                t.correr();
                str += "Tortuga esta en: " + t.Pasos + Environment.NewLine;
            }
           //SE DECIDE SI FUE EMPATE O NO
           if(l.Pasos>79 && t.Pasos>79)
            {
                str += "EMPATE";

            }
           else if(l.Pasos>t.Pasos)
            {
                str += "GANA LIEBRE";
            }
           else
            {
                str += "GANA TORTUGA";
            }
            l.finDeCarrera();
            t.finDeCarrera();
            return str;
        }

        public void bttnCarrera_Click(object sender, EventArgs e)
        {
            txtRes.Text= Carrera(80);
        }
    }
}
