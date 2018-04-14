using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elavador
{
    public partial class Form1 : Form
    {
        Elavador el = new Elavador(6);
        Button oldBut = new Button();
        public Form1()
        {
            InitializeComponent();
           
        }

        public void ColorearBoton(object sen)
        {
            oldBut.BackColor = Color.Transparent;
            oldBut.Enabled = true;
            oldBut= (Button)sen;
            Button but = (Button)sen;
            but.BackColor = Color.LightGreen;
            but.Enabled = false;
        }

        private void bttnP1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            el.irAlPiso(Convert.ToInt32(bt.Text));
            txtElevador.Text = el.ToString();
            ColorearBoton(sender);
            
        }

        private void bttnAbrir_Click(object sender, EventArgs e)
        {
            el.AbrirPuerta();
            txtElevador.Text = el.ToString();
        }

        private void bttnCerrar_Click(object sender, EventArgs e)
        {
            el.cerrarPuerta();
            txtElevador.Text = el.ToString();
        }
    }
}
