using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Cuadrado
    {
        private double Lado;

        public double lad { get => Lado; set => Lado = value; }

        public Cuadrado()
        {
            this.Lado = 10;
        }

        public Cuadrado(double lado)
        {
            this.Lado = lado;
        }

        public double Area()
        {
            double area = Math.Pow(Lado, 2);
            return area;
        }
    }
}
