using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Corredor
    {
        private int _pasos;
        private string _nombre;
        private static Random rnd; 

        public int Pasos { get => _pasos; set => _pasos = value; }
        public string Nombre { get => _nombre;}

        public Corredor(string nom)
        {
            rnd= new Random();
            this._nombre = nom;
            _pasos = 0;
        }

        public int avanzar()
        {
            return rnd.Next(1, 11);
        }

        public int Correr()
        {
            int random = avanzar();
            if (random == 1 || random == 2)
            {
                return  3;
            }
            else if(random == 3 || random == 4 || random == 5)
            {
                return 1;
            }
            else
            {
                return  2;
            }
        }
    }
}
