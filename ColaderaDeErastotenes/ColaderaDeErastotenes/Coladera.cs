using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaderaDeErastotenes
{
    class Coladera
    {
        private int[] _numeros;


        public Coladera()
        {

        }

        //SE LLENA EL ARRAY CON UNICAMENTE 1, RECIBIENDO COMO PARAMETRO EL RANGO MAX DEL ARRAY
        public void llenar(int rangoMax)
        {
            _numeros = Enumerable.Repeat(1, rangoMax).ToArray();
        }

        //SE PASA POR EL ARRAY QUE INICIALMENTE TODOS SUS VALORES SON 1
        public void colar()
        {
            for(int i=2; i< _numeros.Length-1; i++)
            {
                //SI ES 1, SE ANALIZAN TODOS LOS PRIMOS SUPERIORES
                if(_numeros[i]==1)
                {
                    divisoresDeN(i);
                }
            }
        }
        //SE ENCUENTRA LOS DIVISORES DE UN NUMERO Y SE ARIGNA AL ARRAY COMO NUMERO 0
        public void divisoresDeN(int i)
        {
            for (int j = (i + 1); j < _numeros.Length - 1; j++)
            {
                if (j % i == 0)
                {
                    _numeros[j] = 0;
                }
            }
        }
    
        //REGRESA UN STRING CON TODOS LOS NUMERO ENTEROS PRIMOS, BUSCANDO EN EL ARRAY LOS QUE AUN TENGAN UN NUMERO 1
        public string enterosPrimos(int n)
        {
            llenar(n);
            colar();
            string str = "";
            for (int i = 1; i < _numeros.Length - 1; i++)
            {
                if (_numeros[i] == 1)
                {
                    str += i + ", ";
                }
            }
            return str;
        }
    }
}
