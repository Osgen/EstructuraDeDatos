using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpresionesAlgoritmicas
{
    public partial class Form1 : Form
    {
        Arbol arb = new Arbol();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            arb.agregar(txtValor.Text);
            arb.crearArbol();
        }

        private void bttnPreOrder_Click(object sender, EventArgs e)
        {
            txtPreOrder.Text = arb.preOrder();
            txtResultadoPre.Text=Convert.ToString(arb.resolverPreOrder(txtPreOrder.Text));
        }

        private void bttnPostOrder_Click(object sender, EventArgs e)
        {
            txtPostOrder.Text = arb.postOrder();
            txtResultadoPost.Text = Convert.ToString(arb.resolverPostOrder(txtPostOrder.Text));
        }
    }
}
