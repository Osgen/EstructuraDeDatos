using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaBits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Boolean Sensor1(int numero)
        {   
            numero >>= 7;
            numero &= 1;
            return numero == 1 ? true : false;
        }

        public void SetSensor1(int numero)
        {
            if (Sensor1(numero))
            {
                pbSensor1.Image = imgSensor1.Images[0];
            }
            else
            {
                pbSensor1.Image = imgSensor1.Images[1];
            }
        }

        public Boolean Sensor2(int numero)
        {
            numero >>= 6;
            numero &= 1;
            return numero == 1 ? true : false;
        }

        public void SetSensor2(int numero)
        {
            if(Sensor2(numero))
            {
                pbSensor2.Image = imgSensor2.Images[0];
            }
            else
            {
                pbSensor2.Image = imgSensor2.Images[1];
            }
        }

        public int NivelEstanque(int numero)
        {
            numero >>= 4;
            numero &= 3;
            return numero;
        }

        public void setEstanque(int numero)
        {
            pbEstanque.Image = imgEstanque.Images[NivelEstanque(numero)];
        }

        public int DireccionViento(int numero)
        {
            numero >>= 1;
            numero &= 7;
            return numero;
        }

        public void SetDireccion(int numero)
        {
            pbDireccion.Image = imgDireccion.Images[DireccionViento(numero)];
        }

        public int GetDia(int numero)
        {
            numero >>= 8;
            numero &= 31;
            return numero;
        }

        public int GetMes(int numero)
        {
            numero >>= 13;
            numero &= 15;
            return numero;
        }

        public int GetAño(int numero)
        {
            numero >>= 17;
            numero &= 127;
            return numero+1900;
        }

        public string GetFecha(int numero)
        {
            string fecha = GetAño(numero) + "/" + GetMes(numero) + "/" + GetDia(numero);
            return fecha;
        }

        private void bttnProcesar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtEntrada.Text);
            SetSensor1(numero);
            SetSensor2(numero);
            setEstanque(numero);
            lblFechaLectura.Text = GetFecha(numero);
            SetDireccion(numero);
        }

        public int ValorMes(int numero)
        {
            numero <<= 5;
            return numero;
        }

        public int ValorAño(int numero)
        {
            numero <<= 9;
            return numero;
        }

        public void setFecha()
        {
            string[] fecha = txtAjustar.Text.Split('/');
            txtAjustarFecha.Text= Convert.ToString(Convert.ToInt32(fecha[0]) + ValorMes(Convert.ToInt32(fecha[1])) + ValorAño((Convert.ToInt32(fecha[2]) - 1900)));
        }

        private void bttnAjustarFecha_Click(object sender, EventArgs e)
        {
            setFecha();
        }
    }
}
