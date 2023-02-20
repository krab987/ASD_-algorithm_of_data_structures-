using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    public struct Elem
    {
        public int _L;
        public int _inf;
        public Elem(int inf)
        {
            this._L = -1;
            this._inf = inf;
        }
    }
    public class Stack
    {
        
        int _Top; // індекс вершини
        Elem [] _V; // вектор для звереження ел

        public Stack(int count) // конструктор стеку
        {
            _Top = -1;
            _V = new Elem[count];
        }
        public bool Push(Elem el) // дод ел
        {
            _Top++;
            if (_Top == _V.Length)
            {
                _Top--;
                return false;
            }
            _V[_Top]._L = _Top - 1; //зв'язок р з попереднім елементом
            _V[_Top]._inf = el._inf;
            return true;

        }
        public bool Pop() // видалення  ел
        {
            
            
            _Top--;
            return true;

        }
        public override string ToString()/// рядок з інформацією зі стеку
        {
            string res = "";
            if (_Top == -1)
                return res;
            res = "inf =\t";
            for (int i = _Top; i > -1;)
            {
                res += _V[i]._inf + "\t";
                i = _V[i]._L;

            }
            return res;

        }
        
    }
}
