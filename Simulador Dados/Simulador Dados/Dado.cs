using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Dados
{
    class Dado
    {
        private static Random rnd;

        public Dado()
        {
            rnd = new Random();
        }

        public int Lanzar()
        {
            return rnd.Next(0, 6)+1;
        }    
    }
}
