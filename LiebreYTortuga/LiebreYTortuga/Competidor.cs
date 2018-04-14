using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiebreYTortuga
{
    abstract class Competidor
    {
        //NUMERO RANDOM, DA PROBABILIDAD A CADA COMPETIDOR
        protected static Random rnd = new Random();

        //SE GENERA EL RANDOM A CADA COMPETIDOR
        public int avanzar()
        {
            return rnd.Next(1, 11);
        }
    }
}
