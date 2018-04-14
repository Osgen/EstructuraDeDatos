using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Dados
{
    public partial class Form1 : Form
    {
        Dado d;
        Dado dad;
        public Form1()
        {
            InitializeComponent();
            d = new Dado();
            dad = new Dado();
        }



        public string resultadoUnDado(int[] c)
        {
            string s = "";
            for (int i = 0; i < 6; i++)
            {
                s += "Cara " + (i + 1) + ", cayo: " + c[i] + " veces" + Environment.NewLine;
            }
            return s;
        }

        public void tirarUnaVez(int [] c)
        {
             c[d.Lanzar()-1]++;
        }

        public string tirar100()
        {
            int[] _cantidad = new int[] { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 100; i++)
            {
                tirarUnaVez(_cantidad);
            }
            return resultadoUnDado(_cantidad);
        }

        private void bttnTirar_Click(object sender, EventArgs e)
        {
            txtRes.Text = tirar100();
        }

        public void tirarDosVeces(int[] s)
        {
            int sum = d.Lanzar() + d.Lanzar();
            s[sum-2]++;
        }

        public string resultadosDosDados(int[] s)
        {
            string str = "";
            for (int i = 0; i < 11; i++)
            {
                str += "Resultado: " + (i + 2) + ", cayo: " + s[i] + " veces" + Environment.NewLine;
            }
            return str;
        }

        public string tirar2veces100()
        {
            int[] _suma = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 100; i++)
            {
                tirarDosVeces(_suma);
            }
            return resultadosDosDados(_suma);
        }

        public void bttn2Dados_Click(object sender, EventArgs e)
        {
            txtRes.Text = tirar2veces100();
        }

        public string tirar2D()
        {   
            int[] _suma = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 100; i++)
            {
                tirar2D(_suma);
            }
            return res2D(_suma);
        }

        public void tirar2D(int[] sum)
        {
            int suma = d.Lanzar() + dad.Lanzar();
            sum[suma - 2]++;
        }

        public string res2D(int[] sum)
        {
            string str = "";
            for (int i = 0; i < 11; i++)
            {
                str += "Resultado: " + (i + 2) + ", cayo: " + sum[i] + " veces" + Environment.NewLine;
            }
            return str;
        }

        public void bttn2D_Click(object sender, EventArgs e)
        {
            txtRes.Text = tirar2D();
        }
    }
}
