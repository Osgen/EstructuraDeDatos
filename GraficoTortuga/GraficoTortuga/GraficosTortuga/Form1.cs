using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficosTortuga
{
    public partial class Form1 : Form
    {
        Tortuga t = new Tortuga();
        public Form1()
        {
            InitializeComponent();
            lblFlecha.Text= t.Direccion;
        }

        private void bttnEmpezar_Click(object sender, EventArgs e)
        {
            t.empezar();
        }

        private void bttnAvanzar_Click(object sender, EventArgs e)
        {
            for(int i=0; i< Convert.ToInt32(txtAvanzar.Text);i++)
            {
                t.avanzar();

            }
        }

        private void bttnMostrar_Click(object sender, EventArgs e)
        {
            txtPiso.Text = t.ToString();
        }

        private void bttnPB_Click(object sender, EventArgs e)
        {
            t.bajarPluma();
        }

        private void bttnGirarD_Click(object sender, EventArgs e)
        {
            lblFlecha.Text= t.giroDerecha();
        }

        private void bttnGirarI_Click(object sender, EventArgs e)
        {
            lblFlecha.Text= t.giroIzquierda();
        }

        private void bttnPA_Click(object sender, EventArgs e)
        {
            t.subirPluma();
        }
    }
}
