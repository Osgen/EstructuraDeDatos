using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo
{
    class Proceso
    {
        private int _ciclos;
        private Proceso _sig;

        public int Ciclos { get { return _ciclos; }  set { _ciclos = value; } }

        public Proceso Sig { get { return _sig; } set { _sig = value; } }

    }
}
