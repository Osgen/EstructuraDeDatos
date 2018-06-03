using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtencionProcesos
{
    public partial class Form1 : Form
    {
        public static Random rnd = new Random();
        private Procesador procesador = new Procesador();

        public Form1()
        {
            InitializeComponent();      
        }

        private string simular()
        {
            string str;
            int cicloseEnCero = 0;
            int control;
            int procesosCompletados = 0;
            for (int i = 0; i < 300; i++)
            {
                nuevoProceso();
                control = procesador.decrementar();
                if(control==-1)
                {
                    cicloseEnCero++;
                }
                else
                {
                    procesosCompletados += control;
                }
            }

            str = "La cola estuvo vacia en: " + cicloseEnCero + " ciclos" + Environment.NewLine;
            str += "Se atendieron " + procesosCompletados + " procesos" + Environment.NewLine;
            str += "Faltaron " + procesador.ciclosPendientes() + " ciclos para terminar" + Environment.NewLine;
            str += "Faltaron " + procesador.procesosPendientes() + " procesos pendiendes";
            return str;
        }

        private void nuevoProceso()
        {
            if(rnd.Next(-1,100)<36)
            {
                procesador.agregar(new Proceso(rnd.Next(3, 14)));
            }

        }

        private void bttnSimular_Click(object sender, EventArgs e)
        {
            txtSimulacion.Text = simular();
        }
    }
}
