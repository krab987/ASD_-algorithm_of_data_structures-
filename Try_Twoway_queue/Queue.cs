using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Try_Twoway_queue;

public struct Elem //інформація в списку
{
    public int _left, _right;//  адреси на правий і лівий елемент
    public int _inf;// інф поле
    public Elem(int inf) // конструктор структури
    {
        this._left = -1;
        this._right = -1;
        this._inf = inf;
    }
}

public class Queue
{

    int _tail, _head; // індекс голови і хвоста
    Elem[] _mas; // вектор для збереження ел
    int _count;
    public Queue(int count) // конструктор черги
    {
        _tail = _head = -1;
        _mas = new Elem[count]; // _mas виділив для нього память
        _count = 0; //ксть ел в черзі
    }
    public void EnQueue(Elem el) // дод ел
    {

        if (_count == _mas.Length + 1)
        {
            Array.Resize(ref _mas, _mas.Length + 1);
        }

        _count++;
        _tail++;

        if (_tail < _mas.Length)
        {
            _mas[_tail] = el;
            if (_count > 1)
            {
                _mas[_tail]._left = _tail - 1;  // лізий зв'язок
                _mas[_tail - 1]._right = _tail; // правий зв'язок
            }
            if (_head == -1)
                _head = _tail;
        }
        else if (_head > 0)
        {
            _tail = 0;
        }
        _mas[_tail] = el;
        _mas[_tail]._left = _mas.Length - 1;
        _mas[_tail - 1]._right = _tail;
    }
    public bool DeQueue() // видалення  ел
    {
        bool check = true;
        _count--;

        if (_head == _tail)//  сдибалися
        {
            _head = _tail = -1;
            check = false;
        }
        else
        {
            _head = _mas[_head]._right;
            _mas[_head]._left = -1; // розрив зв'язка 
        }

        return check;
    }
    public override string ToString()/// рядок з інформацією 
    {
        string result = "";

        result += "\n left = ";
        for (int i = _head; i >= 0; i++) // з поч до кінця
        {
            if (i == _mas.Length)
                i = 0;

            result += "\t" + _mas[i]._left;
        }
        result += "\n res = ";
        for (int i = _head; i >= 0; i++) // з поч до кінця
        {
            if (i == _mas.Length)
                i = 0;

            result += "\t" + _mas[i]._inf;
        }
        result += "\n right = ";
        for (int i = _head; i >= 0; i++) // з поч до кінця
        {
            if (i == _mas.Length)
                i = 0;

            result += "\t" + _mas[i]._right;
        }
        result += "\n" + _count;

        //result += "|n" + Peek() + "|n" + MaxEl() + "|n" + Count();

        if (_tail == -1)
        {
            result = "Queue is empty";
        }
        return result;
    }


    //public string Max_el()
    //{
    //    double sum = 0;
    //    for (int i = 0; i <= _top; i++) // з поч до кінця
    //    {
    //        sum += _mas[i]._inf;
    //        //i = _mas[i]._right; // і++ - але по вказівнику направо тобто на 1 вперед
    //    }
    //    double av = sum / (_top + 1);
    //    string average = Convert.ToString(Math.Round(av, 2)); // round
    //    average = "average = " + average;

    //    return average;

    //}
}




















//public string Average()
//{
//    double sum = 0;
//    for (int i = 0; i <= _top; i++) // з поч до кінця
//    {
//        sum += _mas[i]._inf;
//        //i = _mas[i]._right; // і++ - але по вказівнику направо тобто на 1 вперед
//    }
//    double av = sum / (_top + 1); 
//    string average = Convert.ToString(Math.Round(av, 2)); // round
//    average = "average = " + average;

//    return average;

//}



/*
    public override string ToString()/// рядок з інформацією зі стеку
    {
        double average = 0;
        string res = "";
        string left = "";
        string right = "";

        string all;

        if (_top == -1) // ел нема
        {
            all = "";
        }
        else
        {

            res = "inf =\t";
            left = "\nL = \t";
            right = "\nR = \t";

            for (int i = 0; i <= _top;) // з поч до кінця
            {
                average += _mas[i]._inf;

                res += _mas[i]._inf + "\t";
                left += _mas[i]._left + "\t";
                right += _mas[i]._right + "\t";

                i = _mas[i]._right; // і++ - але по вказівнику направо тобто на 1 вперед

            }
            average = average / (_top+1); // ділимо на ксть ел
            string ser_arif = Convert.ToString(Math.Round(average, 2)); // round
            ser_arif = "\naverage = " + ser_arif;

            all = res + left + right + ser_arif + "\n" + Convert.ToString(_top);
        }
        return all;
    }
}
*/

