using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraConArreglos
{
    public partial class Form1 : Form
    {
        EstructuraDatos inventario = new EstructuraDatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto(Convert.ToInt32(txtID.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtCosto.Text));
            inventario.agregar(p);
        }

        private void bttnListar_Click(object sender, EventArgs e)
        {
            txtLista.Text= inventario.listar();
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            if(inventario.buscar(Convert.ToInt32(txtBuscar.Text))!=null)
            {
                txtLista.Text= inventario.buscar(Convert.ToInt32(txtBuscar.Text)).ToString();
            }
            else
            {
                txtLista.Text = "NO ENCONTRADO";
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            inventario.eliminar(Convert.ToInt32(txtEliminar.Text));
        }

        private void bttnInsertar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto(Convert.ToInt32(txtID.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtCosto.Text));
            inventario.insertar(p, Convert.ToInt32(txtInsertar.Text));
        }
    }
}
