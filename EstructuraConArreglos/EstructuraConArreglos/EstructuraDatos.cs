using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraConArreglos
{
    class EstructuraDatos
    {
        private static Producto[] _vector= new Producto[15];
        private static int index=0;

        public void agregar(Producto p)
        {
            _vector[index] = p;
            index++;
        }

        public Producto buscar(int id)
        {
            for(int i =0; i<index; i++)
            {
                if(_vector[i].id==id)
                {
                    return _vector[i];
                }
            }
            return null;
        }

        public void eliminar(int id)
        {
            for (int i = 0; i < index; i++)
            {
                if (_vector[i].id == id)
                {
                    _vector[i] = _vector[index-1];
                    index--;
                }
            }
        }

        public void insertar(Producto p,int pos)
        {
            int n = _vector.Length-1;
            for(int i=pos; i<_vector.Length-1; i++)
            {
                _vector[n] = _vector[n - 1];
                n--;
            }
            _vector[pos] = p;
            index++;
        }

        public string listar()
        {
            string str = "";
            for(int i =0; i<index; i++)
            {
                str += _vector[i].ToString()+Environment.NewLine; 
            }
            return str;
        }
    }
}
