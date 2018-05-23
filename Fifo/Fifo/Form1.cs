using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifo
{
    public partial class Form1 : Form
    {
        private static Random rnd = new Random();
        private Estructuron procesador = new Estructuron();
        public Form1()
        {
            InitializeComponent();
        }

        private string simular()
        {
            string str;
            int cicloseEnCero=0;
            int control;
            int procesosCompletados=0;
            for(int i=0; i<300; i++)
            {
                procesador.agregarProceso(nuevoProceso());
                control = procesador.decrementar();
                if (control==0)
                {
                    cicloseEnCero++;
                }
                else if(control==2)
                {
                    procesosCompletados++;
                }
            }

            str = "La cola estuvo vacia en: " + cicloseEnCero+" ciclos"+Environment.NewLine;
            str += "Se atendieron " + procesosCompletados + " procesos" + Environment.NewLine;
            str += "Faltaron " + procesador.ciclosPendientes() + " ciclos para terminar" + Environment.NewLine;
            str += "Faltaron " + procesador.procesosPendientes() + " procesos pendiendes";
            return str;
        }

        private Proceso nuevoProceso()
        {
            if(rnd.Next(-1, 100)<36)
            {
                Proceso p = new Proceso();
                p.Ciclos = cilosNecesarios();
                return p ;
            }
            return null;
        }

        private int cilosNecesarios()
        {
            return rnd.Next(3, 14);
        }

        private void bttnSimular_Click(object sender, EventArgs e)
        {
            txtInfo.Text = simular();
        }
    }
}
