using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiebreYTortuga
{
    class Liebre:Competidor
    {
        private int _pasos;

        public int Pasos { get { return _pasos; } }

        //AVANZAN DE ACUERDO A LA PROBABILIDAD
        public void correr()
        {
            int prob = avanzar();
            if (prob < 3)
            {
                //Dormido
            }
            else if (prob < 6)
            {
                _pasos += 1;
            }
            else if(prob <8)
            {
                _pasos += 9;
            }
            else if(prob <9)
            {
                _pasos -= 12;
            }
            else
            {
                _pasos -= 2;
            }
        }
        //SE TERMINA LA CARRERA, PARA PODER VOLVER A CORRER
        public void finDeCarrera()
        {
            _pasos = 0;
        }
    }
}
