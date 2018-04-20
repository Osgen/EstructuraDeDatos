using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficosTortuga
{
    class Tortuga
    {
        static private int[] _pos;
        static private int _direc;
        static private int _pluma;
        static private int[,] _piso;

        private string[] _flecha;

        public string Direccion { get { return _flecha[(_direc/2)-1]; } }
            
        public Tortuga()
        {
            _piso = new int[20, 20];
            _flecha = new string[4] { "↓", " ←", "→", " ↑" };
            _pos = new int[2];
            _pluma = 0;
            _pos[0] = 0 ;
            _pos[1] = 0;
            _direc = 6;
            
        }

        public void empezar()
        {
            for (int y = 0; y < _piso.GetLength(0); y++)
            {
                for (int x = 0; x < _piso.GetLength(0); x++)
                {
                    _piso[y, x] = 0;
                }
            }
        }

        public void bajarPluma()
        {
            _pluma = 1;
            _piso[_pos[1], _pos[0]] = _pluma;
        }

        public void subirPluma()
        {
            _pluma = 0;
        }

        public void avanzar()
        {
            int[] lastPos= new int[2] {_pos[0],_pos[1]};
            //PINTAR POS ANTERIOR
            /*
            if (_pluma == 1)
            {
                _piso[_pos[1], _pos[0]] = _pluma;
            }
            */
                if (_direc == 8)
                {
                    _pos[1]--;

                }
                else if (_direc == 2)
                {
                    _pos[1]++;

                }
                else if (_direc == 6)
                {
                    _pos[0]++;

                }
                else if (_direc == 4)
                {
                    _pos[0]--;

                }

            if (_pos[0] < 20 && _pos[1] < 20 && _pos[0] > -1 && _pos[1] > -1)
            {
                //SI PINTA SU MISMO LUGAR
                if (_pluma == 1)
                {
                    _piso[_pos[1], _pos[0]] = _pluma;
                }
            }
            else
            {
                _pos[0] = lastPos[0];
                _pos[1] = lastPos[1];
            }
            Console.WriteLine(_pos[0] + "," + _pos[1]);
        }

        public string giroDerecha()
        {
            if (_direc == 8)
            {
                _direc = 6;
            }
            else if (_direc == 6)
            {
                _direc = 2;
            }
            else if (_direc == 2)
            {
                _direc = 4;
            }
            else if (_direc == 4)
            {
                _direc = 8;
            }
            return _flecha[(_direc / 2) - 1];
        }

        public string giroIzquierda()
        {
            if (_direc == 8)
            {
                _direc = 4;
            }
            else if (_direc == 4)
            {
                _direc = 2;
            }
            else if (_direc == 2)
            {
                _direc = 6;
            }
            else if (_direc == 6)
            {
                _direc = 8;
            }
            return _flecha[(_direc / 2) - 1];
        }

        public override string ToString()
        {
            string str = "";
            for(int y=0; y<_piso.GetLength(0); y++)
            {
                for(int x=0; x< _piso.GetLength(1); x++)
                {
                    str += _piso[y, x]+"      ";
                }
                str += Environment.NewLine+Environment.NewLine;
            }
            return str;
        }
    }
}
