using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Reactangulo
    {
        private double Base;
        private double Altura;

        public Reactangulo()
        {
            Base = 10;
            Altura = 5;
        }

        public Reactangulo(double bas,double altura )
        {
            this.Base = bas;
            this.Altura = altura;
        }

        public double Base1 { get => Base; set => Base = value; }
        public double Altura1 { get => Altura; set => Altura = value; }

        public double Area()
        {
            double area = Base * Altura;
            return area;
        }
    }
}
