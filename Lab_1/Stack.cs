using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public struct Elem
    {
        public int left, right;//  адреси на правий і лівий елемент
        public int inf;// інф поле
        public Elem(int inf)
        {
            this.left = -1;
            this.right = -1;
            this.inf = inf;
        }
    }
    public class Stack
    {

        int top; // індекс вершини
        Elem[] mas; // вектор для збереження ел

        public Stack(int count) // конструктор стеку
        {
            top = -1; // ставлю вершину -1 бо ел пока нема
            mas = new Elem[count]; // mas виділив для нього память
        }
        public void Push(Elem el) // дод ел
        {
            top++;
            if (top == mas.Length) // якщо дійшли до кінця ресаййз
            {
                Array.Resize(ref mas, mas.Length + 1);
            }
            mas[top].left = top - 1; //зв'язок з попереднім елементом
            mas[top].right = top + 1; // зв'язок з настурним елементом
            mas[top].inf = el.inf; //  заповнили інфою
        }
        public bool Pop() // видалення  ел
        {
            bool check = true;
            if (top == -1) //  якщо нема ел
                check = false;

            top--; // вернули верщшину на 1 назад
            return check;
        }
        public string Peek()
        {
            return Convert.ToString(mas[0].inf);
        }
        public int MaxEl()
        {
            int max = mas[0].inf;
            for (int i = 0; i <= top; i++) // з поч до кінця
            {
                if(mas[i].inf > max)
                {
                    max = mas[i].inf; 
                }
            }

            return max;
        }
        public string Count()
        {
            return Convert.ToString(top + 1);
        }


        public override string ToString()/// рядок з інформацією зі стеку
        {
            string smas = "res = ";
            for (int i = 0; i <= top; i++) // з поч до кінця
            {
                smas += "\t" + mas[i].inf;
            }
            //smas += "\n firstEl = " + Peek() + "\n maxEl = " + MaxEl() + "\ncount = " + Count();
            return smas;
        }
        public string Average()
        {
            double sum = 0;
            for (int i = 0; i <= top; i++) // з поч до кінця
            {
                sum += mas[i].inf;
                //i = mas[i].right; // і++ - але по вказівнику направо тобто на 1 вперед
            }
            double av = sum / (top + 1); 
            string average = Convert.ToString(Math.Round(av, 2)); // round
            average = "average = " + average;

            return average;

        }
        public bool IsEmpty(Elem e)
        {
            bool res = false;
            if(top == -1)
            {
                res = true;
            }
            return res;
        }

    }
}
/*
    public override string ToString()/// рядок з інформацією зі стеку
    {
        double average = 0;
        string res = "";
        string left = "";
        string right = "";

        string all;

        if (top == -1) // ел нема
        {
            all = "";
        }
        else
        {

            res = "inf =\t";
            left = "\nL = \t";
            right = "\nR = \t";

            for (int i = 0; i <= top;) // з поч до кінця
            {
                average += mas[i].inf;

                res += mas[i].inf + "\t";
                left += mas[i].left + "\t";
                right += mas[i].right + "\t";

                i = mas[i].right; // і++ - але по вказівнику направо тобто на 1 вперед

            }
            average = average / (top+1); // ділимо на ксть ел
            string ser_arif = Convert.ToString(Math.Round(average, 2)); // round
            ser_arif = "\naverage = " + ser_arif;

            all = res + left + right + ser_arif + "\n" + Convert.ToString(top);
        }
        return all;
    }
}
*/

