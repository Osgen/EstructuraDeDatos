using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutas
{
    class Base
    {
        private string _nombre;
        private int _minutos;
        public Base sig;

        public int Minutos { get { return _minutos; } }
        public string Nombre { get { return _nombre; } }

        public Base(string nombre, int min)
        {
            _nombre = nombre;
            _minutos = min;
        }

        public override string ToString()
        {
            return _nombre + ": " + _minutos;
        }
    }
}
