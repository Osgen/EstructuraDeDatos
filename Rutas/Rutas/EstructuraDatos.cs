using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutas
{
    
    class EstructuraDatos
    {
        Base inicio;

        private void agregar(Base lugar, Base b)
        {
            if(lugar.sig==inicio)
            {
                b.sig = inicio;
                lugar.sig = b;
            }
            else
            {
                agregar(lugar.sig, b);
            }
        }

        public void agregar(Base b)
        {
            if(inicio==null)
            {
                inicio = b;
                inicio.sig = inicio;
            }
            else
            {
                agregar(inicio, b);
            }
        }

        private Base buscar(Base b, string name)
        {
            if(b.sig==inicio)
            {
                return null;
            }
            else if(b.sig.Nombre==name)
            {
                return b.sig;
            }
            else
            {
                return buscar(b.sig, name);
            }
        }

        public Base buscar(string name)
        {
            if(inicio == null)
            {
                return null;
            }
            else if(inicio.Nombre==name)
            {
                return inicio;
            }
            else
            {
                return buscar(inicio, name);
            }
        }

        private Base eliminarUltimo (Base b)
        {
            Base temp;
            if(b.sig.sig==inicio)
            {
                temp = b.sig;
                b.sig = inicio;
                return temp;
            }
            else
            {
                return eliminarUltimo(b.sig);
            }
        }

        public Base eliminarUltimo()
        {
            Base temp;
            if(inicio==null)
            {
                return null;
            }
            else if(inicio.sig==inicio)
            {
                temp =inicio;
                inicio = null;
                return temp;
            }
            else
            {
                return eliminarUltimo(inicio);
            }
        }

        public Base eliminarInicio()
        {
            Base temp = inicio;
            while(temp.sig!=inicio)
            {
                temp = temp.sig;
            }
            temp.sig = inicio.sig;
            temp = temp.sig;
            inicio = inicio.sig;
            return temp;
        }

        private Base eliminar(Base b, string name)
        {
            Base temp;
            if(b.sig==inicio)
            {
                return null;
            }
            else if(b.sig.Nombre==name)
            {
                temp = b.sig;
                if (b.sig.sig==inicio)
                {
                    return eliminarUltimo();
                }
                else
                {
                    b.sig = b.sig.sig;
                    return temp;
                }
            }
            else
            {
                return eliminar(b.sig, name);
            }
        }

        public Base eliminar(string name)
        {
            if(inicio==null)
            {
                return null;
            }
            else if(inicio.Nombre==name)
            {
                return eliminarInicio();
            }
            else
            {
                return eliminar(inicio, name);
            }
        }

        private string listar(Base b)
        {
            if(b.sig==inicio)
            {
                return b.ToString() + Environment.NewLine ;
            }
            else
            {
                return b.ToString()+Environment.NewLine+listar(b.sig);
            }
        }

        public string listar()
        {
            if(inicio==null)
            {
                return null;
            }
            else if(inicio.sig==inicio)
            {
                return inicio.ToString();
            }
            else
            {
                return listar(inicio);
            }
        }

        public void insertar(Base b, int pos)
        {
            if(inicio!=null)
            {
                if(pos==1)
                {
                    Base temp = inicio;
                    while(temp.sig!=inicio)
                    {
                        temp = temp.sig;
                    }
                    
                    b.sig = inicio;
                    inicio = b;
                    temp.sig = b;
                }
                else
                {
                    Base temp = inicio;
                    int c = 2;
                    while (temp.sig!=inicio)
                    {
                        if(pos==c)
                        { 
                            b.sig = temp.sig;
                            temp.sig = b;
                            break;
                        }
                        else
                        {
                            temp = temp.sig;
                            c++;
                        }
                    }
                }
            }
            else
            {
                inicio = b;
                inicio.sig = inicio;
            }
            
        }

        private string cuantasBases(string bas)
        {
            Base temp = inicio;
            while (temp.Nombre != bas)
            {
                temp = temp.sig;
            }
            string names=temp.Nombre+"          ";
            while (temp.sig.Nombre != bas)
            {
                names += temp.sig.Nombre + "        ";
                temp = temp.sig;
            }
            return names;
        }

        public string ruta(string bas, string hInicio, string hFin)
        {
            string[] horaInicio = hInicio.Split(':');
            int horaIn = Convert.ToInt32( horaInicio[0] + horaInicio[1]);
            string[] horaFin = hFin.Split(':');
            int horaF = Convert.ToInt32(horaFin[0] + horaFin[1]);
            int[] hIn = new int[2];
            hIn[0] = Convert.ToInt32(horaInicio[0]);
            hIn[1] = Convert.ToInt32(horaInicio[1]);

            if (inicio==null)
            {
                return null;
            }
            else
            {
                Base temp = inicio;
                string tabla = cuantasBases(bas) + Environment.NewLine ;
                while(temp.Nombre!=bas)
                {
                    temp = temp.sig;
                }
                while (horaIn < horaF)
                {
                    tabla += hIn[0] + ":" + hIn[1] + "    ";
                    if ((hIn[1] + temp.Minutos) >= 60)
                    {
                        hIn[0]++;
                        hIn[1] = temp.Minutos - (60 - hIn[1]);
                    }
                    else
                    {
                        hIn[1] += temp.Minutos;
                    }
                    horaIn = Convert.ToInt32(Convert.ToString(hIn[0]) + Convert.ToString(hIn[1]));

                    if (temp.sig.Nombre == bas)
                    {
                        tabla += Environment.NewLine;
                    }
                    temp = temp.sig;
                }
                return tabla;
            }
        }
    }
}
