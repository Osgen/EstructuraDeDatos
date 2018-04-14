using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizPrac
{
    class Matriz
    {
        public int[,] matr = new int[5, 5];

        public void llenar()
        {
            int n = 1;
            for(int y =0; y<5; y++)
            {
                for(int x=0; x<5; x++)
                {
                    matr[y, x] = n++;
                }
            }
        }

        public void llenarColumna()
        {
            int n = 1;
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    matr[y, x] = n++;
                }
            }
        }

        public void llenarInverso()
        {
            int n = 1;
            for (int y = 4; y >-1; y--)
            {
                for (int x = 4; x >-1; x--)
                {
                    matr[y, x] = n++;
                }
            }
        }

        public string mostrar()
        {
            string str="";
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    str += matr[y, x] + "     ";
                }
                str += Environment.NewLine;
            }
            return str;
        }

        public string mostrarDP()
        {
            string str = "";
            for (int y = 0; y < 5; y++)
            {
               str += matr[y, y] + "     ";     
            }
            return str;
        }

        public string mostrarDS()
        {
            string str = "";
            for (int x = 4; x>-1 ; x--)
            {
                str += matr[((5-x)-1), x] + "     ";
            }
            return str;
        }

        public string mostrarAbajoDP()
        {
            string str = "";
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if((y-x)>0)
                    {
                        str += matr[y, x] + "     ";
                    }
                }
                str += Environment.NewLine;
            }
            return str;
        }

        public string mostrarAbajoDS()
        {
            string str = "";
            for (int x = 1; x < 5; x++)
            {
                for (int y = (5-x); y < 5; y++)
                {
                        str += matr[y, x] + "     ";
                }
                str += Environment.NewLine;
            }
            return str;
        }

        public void espejoMatrizDP()
        {
            int u = 0;
            for(int y = u; y<5; y++)
            {
                for(int x =(y+1); x<5; x++)
                {
                    int temp = matr[y, x];
                    matr[y, x] = matr[x, y];
                    matr[x, y] = temp;
                    u++;
                }
            }
        }

        public void espejoMatrizDS()
        {
            int u = 0;
            for (int y = u; y < 5; y++)
            {
                for (int x = 0; x < (5-y); x++)
                {
                    Console.WriteLine("[" + y+ ","+x+"], ["+(4-x)+","+(4-y)+"]");
                    int temp = matr[y, x];
                    matr[y, x] = matr[(4-x), (4-y)];
                    matr[(4-x),(4-y)] = temp;
                    u++;
                }
            }

            Console.WriteLine("done");
        }

    }
}
