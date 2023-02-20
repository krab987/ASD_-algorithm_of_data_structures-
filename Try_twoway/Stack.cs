using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public struct Elem
    {
        public int _L,_R;//  адреси на правий і лівий елемент
        public int _inf;// інф поле
        public Elem(int inf)
        {
            this._L = -1;
            this._R = -1;
            this._inf = inf;
        }
    }

    public class Stack
    {
        
        int _Top; // індекс вершини
        Elem [] _V; // вектор для збереження ел

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
            _V[_Top]._L = _Top - 1; //зв'язок з попереднім елементом
            _V[_Top]._R = _Top + 1; // зв'язок з настурним елементом
            _V[_Top]._inf = el._inf;
            return true;

        }
        public bool Pop() // видалення  ел
        {
            if (_Top == -1)
                return false;
            
            _Top--;
            return true;
        }
        public override string ToString()/// рядок з інформацією зі стеку
        {
            string res = "";
            string left  = "";
            string right = "";

            if (_Top == -1)
            {
                return res + left + right;
            }
                
            res = "inf =\t";
            left = "\nL = \t";
            right = "\nR = \t";

            for (int i = 0; i < _Top;)
            {
                res += _V[i]._inf + "\t";
                left += _V[i]._L + "\t";
                right += _V[i]._R + "\t";

                i = _V[i]._R;

            }
            return res + left + right;
        }

    }
}
