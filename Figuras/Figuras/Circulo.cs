using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Circulo
    {
        private double Radio;

        public Circulo()
        {
            Radio = 3;
        }

        public Circulo(double radio)
        {
            this.Radio = radio;
        }

        public double Radio1 { get => Radio; set => Radio = value; }

        public double Area()
        {
            double area = 3.1416 * (Math.Pow(Radio, 2));
            return area;
        }
    }
}
