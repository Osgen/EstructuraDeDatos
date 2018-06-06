using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesAlgoritmicas
{
    class Arbol
    {
        Dato raiz;

        public void agregar(string s)
        {
            Dato cosa;
            for(int i =0; i<s.Length; i++)
            {
                cosa = new Dato(s[i]);
                agregar(cosa);
            }
        }

        private void agregar(Dato d)
        {
            if(raiz ==null)
            {
                raiz = d;
            }
            else
            {
                agregar(raiz, d);
            }
        }

        private void agregar(Dato lugar, Dato d)
        {
            if(lugar.Sig==null)
            {
                d.Ant = lugar;
                lugar.Sig = d;
            }
            else
            {
                agregar(lugar.Sig, d);
            }
        }

        public Boolean crearArbol()
        {
            if(raiz!=null)
            {
                arbol(raiz, '*', '/');
                // raiz = raiz.Sig;
                arbol(raiz, '+', '-');
                //raiz = raiz.Sig;
                Dato temp = raiz;
                
            }
            return false;
        }

        private Boolean arbol(Dato lugar, char a, char b)
        {
            bool control = false ;
            if(lugar!=null && lugar.Sig!=null)
            {
                if (lugar.Sig.Cosa == a || lugar.Sig.Cosa == b)
                {
                    control = true;
                    lugar.Sig.Izq = lugar.Sig.Ant;
                    lugar.Sig.Der = lugar.Sig.Sig;
                    if (lugar.Sig.Sig.Sig != null)
                    {
                        lugar.Sig.Sig = lugar.Sig.Sig.Sig;
                        lugar.Sig.Sig.Ant = lugar.Sig;
                    }
                    else
                    {
                        lugar.Sig.Sig = null;
                    }

                    if(lugar.Ant!=null)
                    {
                        lugar.Sig.Ant = lugar.Ant;
                        lugar.Sig.Ant.Sig = lugar.Sig;
                    }
                    else
                    {
                        lugar.Sig.Ant = null;
                        raiz = raiz.Sig;
                    }
                }
                arbol(lugar.Sig,a,b);
            }
            return control;
        }

        public string preOrder()
        {
            if(raiz!=null)
            {
                return preOrder(raiz);
            }
            return null;
        }

        private string preOrder(Dato raiz)
        {
            string str = "";
            if(raiz!=null)
            {
                str += raiz.Cosa + preOrder(raiz.Izq)+ preOrder(raiz.Der);
            }
            return str;
        }

        public string postOrder()
        {
            if (raiz != null)
            {
                return postOrder(raiz);
            }
            return null;
        }

        private string postOrder(Dato raiz)
        {
            string str = "";
            if (raiz != null)
            {
                str += postOrder(raiz.Izq) + postOrder(raiz.Der) + raiz.Cosa;
            }
            return str;
        }

        public int resolverPreOrder(string s)
        {
            Stack<int> lifo = new Stack<int>();
            for(int i =s.Length-1; i>-1; i--)
            {
                if(s[i]=='*')
                {
                    lifo.Push((lifo.Pop() * lifo.Pop()));
                }
                else if(s[i]=='/')
                {
                    lifo.Push((lifo.Pop() / lifo.Pop()));
                }
                else if(s[i]=='+')
                {
                    lifo.Push((lifo.Pop() + lifo.Pop()));
                }
                else if(s[i]=='-')
                {
                    lifo.Push((lifo.Pop() - lifo.Pop()));
                }
                else
                {
                    lifo.Push((int)char.GetNumericValue(s[i]));
                }
            }

            return lifo.Pop();
        }

        public int resolverPostOrder(string s)
        {
            Stack<int> lifo = new Stack<int>();
            int a;
            int b;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    a = lifo.Pop();
                    b = lifo.Pop();
                    lifo.Push((b * a));
                }
                else if (s[i] == '/')
                {
                    a = lifo.Pop();
                    b = lifo.Pop();
                    lifo.Push((b / a));
                }
                else if (s[i] == '+')
                {
                    a = lifo.Pop();
                    b = lifo.Pop();
                    lifo.Push((b + a));
                }
                else if (s[i] == '-')
                {
                    a = lifo.Pop();
                    b = lifo.Pop();
                    lifo.Push((b - a));
                }
                else
                {
                    lifo.Push((int)char.GetNumericValue(s[i]));
                }
            }

            return lifo.Pop();
        }
    }
}
