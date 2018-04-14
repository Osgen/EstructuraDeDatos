using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elavador
{
    class Elavador
    {
        private int _pisoTotal;
        private int _pisoActual;
        private bool _estadoPuerta;

        public int PisoActual { get => _pisoActual;}
        public int PisoTotal { get => _pisoTotal;}

        public Elavador()
        {
            this._pisoActual = 1;
            this._estadoPuerta = false;
        }

        public Elavador(int pisosTotales)
        {
            this._pisoActual = 1;
            this._estadoPuerta = false;
            this._pisoTotal = pisosTotales;
        }

        private void Bajar()
        {
                cerrarPuerta();
                this._pisoActual--;
        }

        private void Subir()
        {     
                cerrarPuerta();
                this._pisoActual++;      
        }

        public void cerrarPuerta()
        {
            this._estadoPuerta = false;
        }

        public void AbrirPuerta()
        {
            this._estadoPuerta = true;
        }

        public void irAlPiso(int piso)
        {

            if(this._pisoActual>piso)
            {
                while(this._pisoActual>piso)
                {
                    Bajar();
                }                
            }
            else
            {
                while(this._pisoActual<piso)
                {
                    Subir();
                }
            }         
        }

        public override string ToString()
        {
            string puerta;
            if(this._estadoPuerta)
            {
                puerta = "Abierta";
            }
            else
            {
                puerta = "Cerrada";
            }
            return "Piso: "+this._pisoActual+Environment.NewLine+"Puerta: "+puerta;
        }
    }

   
}
