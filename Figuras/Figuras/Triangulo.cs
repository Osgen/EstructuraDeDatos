using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Triangulo
    {
        private double Base;
        private double Altura;

        public double bas1 { get => Base; set =>Altura= value; }
        public double Altura1 { get => Altura; set => Altura = value; }

        public Triangulo()
        {
            this.Base = 10;
            this.Altura = 30;
        }

        public Triangulo(double bas, double altura)
        {
            this.Base = bas;
            this.Altura = altura;
        }

        public double Area()
        {
            double area = (Base * Altura) / 2;
            return area;
        }
    }
}
