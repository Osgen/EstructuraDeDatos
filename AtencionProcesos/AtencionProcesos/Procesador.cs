using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionProcesos
{
    class Procesador
    {
        Proceso inicio;

        public void agregar(Proceso p)
        {
            if(inicio==null)
            {
                inicio = p;
                inicio.Sig = inicio;
            }
            else
            {
                agregar(inicio, p);
            }
        }

        private void agregar(Proceso lugar, Proceso p)
        {
            if(lugar.Sig==inicio)
            {
                lugar.Sig = p;
                lugar.Sig = inicio;
            }
            else
            {
                agregar(lugar.Sig, p);
            }
        }

        public int decrementar()
        {
            int c = 0;
            if(inicio ==null)
            {
                c = -1;
            }
            else if(inicio.Sig!=inicio)
            {
                inicio.Ciclos--;
                if(inicio.Ciclos<1)
                {
                    Proceso temp=inicio;
                    while(temp.Sig!=inicio)
                    {
                        temp = temp.Sig;
                    }
                    inicio = inicio.Sig;
                    temp.Sig = inicio;
                    c++;
                }
                c += decrementar(inicio);
            }
            else
            {
                inicio.Ciclos--;
                if (inicio.Ciclos < 1)
                {
                    inicio = null;
                    c++;
                }
            }
            return c;
            
        }

        private int decrementar(Proceso lugar)
        {
            int c = 0;
            if(lugar.Sig!=inicio)
            {
                lugar.Sig.Ciclos--;
                if(lugar.Sig.Ciclos<1)
                { 
                    lugar.Sig = lugar.Sig.Sig;
                    c++;
                }
                c +=decrementar(lugar.Sig);
            }
            return c;
        }

        public  int ciclosPendientes()
        {
            int c = 0;
            if(inicio!=null)
            {
                Proceso temp = inicio;

                while (temp.Sig != inicio)
                {
                    c += temp.Ciclos;
                    temp = temp.Sig;
                }
                if(inicio==inicio)
                {
                    c = 1;
                }
            }
            return c;
        }

        public int procesosPendientes()
        {
            int c = 0;
            if(inicio!=null)
            {
                Proceso temp = inicio;
                while (temp.Sig != inicio)
                {
                    c++;
                    temp = temp.Sig;
                }
                if (inicio == inicio)
                {
                    c = 1;
                }
            }
     
            return c;
        }
    }
}
