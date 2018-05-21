using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rutas
{
    public partial class Form1 : Form
    {
        EstructuraDatos rutas = new EstructuraDatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Base b = new Base(txtNombre.Text, Convert.ToInt32(txtMinutos.Text));
            rutas.agregar(b);
        }

        private void bttnListar_Click(object sender, EventArgs e)
        {
            txtTabla.Text= rutas.listar();
        }

        private void bttnBusName_Click(object sender, EventArgs e)
        {
            txtTabla.Text= rutas.buscar(txtBusName.Text).ToString();
        }

        private void bttnEliminarUltimo_Click(object sender, EventArgs e)
        {
            rutas.eliminarUltimo();
        }

        private void bttnEliminarInicio_Click(object sender, EventArgs e)
        {
            rutas.eliminarInicio();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            rutas.eliminar(txtBusName.Text);
        }

        private void bttnInsertar_Click(object sender, EventArgs e)
        {
            Base b = new Base(txtNombre.Text, Convert.ToInt32(txtMinutos.Text));
            rutas.insertar(b, Convert.ToInt32(txtPos.Text));
        }

        private void bttnRuta_Click(object sender, EventArgs e)
        {
           txtTabla.Text= rutas.ruta(txtNoBase.Text, txtHoraInicio.Text, txtHoraFin.Text);
        }
    }
}
