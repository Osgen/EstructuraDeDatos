using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesAlgoritmicas
{
    class Dato
    {
        private char _cosa;
        private Dato _izq;
        private Dato _der;
        private Dato _ant;
        private Dato _sig;

        public Dato Izq { get { return _izq; } set { _izq = value; } }
        public Dato Der { get { return _der; } set { _der = value; } }
        public Dato Ant { get { return _ant; } set { _ant = value; } }
        public Dato Sig { get { return _sig; } set { _sig = value; } }
        public char Cosa { get { return _cosa; } }

        public Dato(char cosa)
        {
            _cosa = cosa;
        }


    }
}
