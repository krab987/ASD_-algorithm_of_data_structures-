using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR
{
    public class EasyStack
    {
        //Допрацьовано: стек тепер зберігае елменти типу Item, де є інформація цисла та посилання на лівий елемент - тепер стек є стеком а не масивом так сказати

        Item top; // індекс вершини

        public EasyStack() // конструктор стеку
        {

        }

        public void Push(int el, int key) // дод ел
        {
            Item item = new Item(el, key);
            item.left = top;
            top = item;
        }
        public bool Pop() // видалення  ел
        {
            bool check = true;
            if (top == null)//  якщо нема ел
                check =  false;

            top = top.left;// вернули верщшину на 1 назад
            return check;
        }

        //підрахунок кількості елементів
        public int getCount()
        {
            int res = 0;

            for (Item el = top; el != null; el = el.left)
            {
                res++;
            }
            return res;
        }
        //check is expty or no
        public bool IsEmpty()
        {
            if (top != null)
                return false;
            return true;
        }
        public double Peek()
        {
            int res = 0;
            for (Item el = top; el != null; el = el.left)
            {
                if(el.left == null)
                {
                    res = el.inf;
                }
            }

            return res;
        }
        public int CountEl()
        {
            int res = 0;
            for (Item el = top; el != null; el = el.left)
            {
                res++;
            }
            return res;
        }

        public override string ToString()
        {
            string res = "";
            for (Item el = top; el != null; el = el.left)
            {
                res += el.inf + "\t";
            }
            return res;
        }

    }
}