using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo
{
    class Estructuron
    {
        
        public Proceso inicio;

        public void agregarProceso(Proceso p)
        {
            if (inicio==null)
            {
                inicio = p;
            }
            else
            {
                agregar(inicio, p);
            }
        }

        private void agregar(Proceso lugar, Proceso p)
        {
            if(lugar.Sig==null)
            {
                lugar.Sig = p;
            }
            else
            {
                agregar(lugar.Sig, p);
            }
        }

        public int decrementar()
        {
            if(inicio==null)
            {
                return 0;
            }
            else
            {
                if(inicio.Ciclos<1)
                {
                    terminarProceso();
                    inicio.Ciclos--;
                    return 2;
                }
                else
                {
                    inicio.Ciclos--;
                    
                }
                return 1;
            }
        }

        private void terminarProceso()
        {
            inicio = inicio.Sig;
        }

        public int ciclosPendientes()
        {
            if(inicio==null)
            {
                return 0;
            }
            else
            {
                return contarPendientes(inicio);
            }
        }

        private int contarPendientes(Proceso p)
        {
            if(p.Sig==null)
            {
                return p.Ciclos;
            }
            else
            {
                return p.Ciclos + contarPendientes(p.Sig);
            }
        }

        public int procesosPendientes()
        {
            if (inicio == null)
            {
                return 0;
            }
            else
            {
                return procesosPendientes(inicio);
            }
        }

        private int procesosPendientes(Proceso p)
        {
            if (p.Sig == null)
            {
                return 1;
            }
            else
            {
                return 1 + procesosPendientes(p.Sig);
            }
        }
    }
}
