using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiebreYTortuga
{
    class Tortuga : Competidor
    {
        private int _pasos;
        //SE PUEDEN OBSERVAR LOS PASOS PERO NO ASIGNAR
        public int Pasos {get{return _pasos ;} }
        //SE AVANZ DE ACUERDO A LA PROBABILIDAD
        public void correr()
        {
            if(avanzar()<3)
            {
                _pasos -= 6;
            }
            else if(avanzar()<6)
            {
                _pasos += 1;
            }
            else
            {
                _pasos += 3;
            }
        }
        //ASIGNAR PASOS A 0, VOLVER A EMPEZAR OTRA CARRERA
        public void finDeCarrera()
        {
            _pasos = 0;
        }
    }
}
