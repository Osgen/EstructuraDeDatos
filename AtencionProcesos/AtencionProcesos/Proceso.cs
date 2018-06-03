using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionProcesos
{
    class Proceso
    {
        private int _ciclos;
        private Proceso _sig;

        public int Ciclos { get => _ciclos; set => _ciclos = value; }
        public Proceso Sig { get => _sig; set => _sig = value; }

        public Proceso(int ciclos)
        {
            _ciclos = ciclos;
        }
    }
}
