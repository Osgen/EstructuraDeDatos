using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizPrac
{
    public partial class Form1 : Form
    {
        Matriz mat = new Matriz();
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnLlenar_Click(object sender, EventArgs e)
        {
            mat.llenar();
        }

        private void bttnMostrar_Click(object sender, EventArgs e)
        {
            txtMatriz.Text= mat.mostrar();
        }

        private void bttnLlenarColumna_Click(object sender, EventArgs e)
        {
            mat.llenarColumna();
        }

        private void bttnLlenarInverso_Click(object sender, EventArgs e)
        {
            mat.llenarInverso();
        }

        private void bttnDP_Click(object sender, EventArgs e)
        {
            txtMatriz.Text = mat.mostrarDP();
        }

        private void bttnMostrarDs_Click(object sender, EventArgs e)
        {
            txtMatriz.Text = mat.mostrarDS();
        }

        private void bttnAbajoDP_Click(object sender, EventArgs e)
        {
            txtMatriz.Text = mat.mostrarAbajoDP();
        }

        private void bttnAbajoDS_Click(object sender, EventArgs e)
        {
            txtMatriz.Text = mat.mostrarAbajoDS();
        }

        private void bttnGiroDP_Click(object sender, EventArgs e)
        {
            mat.espejoMatrizDP();
        }

        private void bttnGiroDS_Click(object sender, EventArgs e)
        {
            mat.espejoMatrizDS();
        }
    }
}
