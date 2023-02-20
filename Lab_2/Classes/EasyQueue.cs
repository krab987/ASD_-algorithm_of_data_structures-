using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Classes
{
    public struct Item
    {
        public int left, right; //лівий правий 
        public char inf;  //інфа

        public Item(char inf)
        {
            this.left = -1;
            this.right = -1;
            this.inf = inf;
        }

    }
    public class EasyQueue
    {
        int head, tail;
        Item[] items;
        int count;

        public EasyQueue(int countElements)
        {
            count = 0;  // к-сть ел
            head = tail = -1;
            items = new Item[countElements];
        }

        public void EnQueue(Item el)
        {
            if (tail == items.Length - 1)  //нема міця - збільш на 1
                Array.Resize(ref items, items.Length + 1);

            if (count != 0) //if isnt empty
            {

                items[tail + 1].left = tail; // left of new -> previous
                items[tail].right = tail + 1; // right of prev -> new
                items[tail + 1].right = head; // right of new -> head
                items[head].left = tail + 1; // left og head -> newwwwwwwww ууууу
                tail++;  // здвиг на 1
                items[tail].inf = el.inf;  //заповнили даними

            }
            else // if  empty
            {
                tail = head = 0;
                items[tail].inf = items[head].inf = el.inf;
                items[0].right = items[0].left = tail;
            }
            count++;
        }
        public bool DeQueue()
        {
            bool res = true;
            if (count == 0) //nema el to del
            {
                res = false;
            }
            if (count == 1) //nema el to del
            {
                head = tail = -1;
            }
            else
            {
                head = items[head].right;  //здвиг голови вправо
                items[head].left = tail;  //голова ліво на хвіст
                items[tail].right = head;  //хвіст право на голову
                count--;
            }
            return res;
        }
        public override string ToString()/// рядок з інформацією зі стеку
        {
            string res = "res = ";
            for (int i = head; i <= tail; i++) // з поч до кінця
            {
                res += "\t" + items[i].inf;
            }
            //res += "\nleft";
            //for (int i = head; i <= tail; i++) // з поч до кінця
            //{
            //    res += "\t" + items[i].left;
            //}
            //res += "\nright";
            //for (int i = head; i <= tail; i++) // з поч до кінця
            //{
            //    res += "\t" + items[i].right;
            //}

           // res += "\n firstEl = " + Peek() + "\n maxEl = " + MaxEl() + "\ncount = " + Count();
            return res;
        }

        public string Peek()
        {
            return Convert.ToString(items[head].inf);
        }  //firstel
        public string Count()
        {
            return Convert.ToString(count);
        }  //kolEl
        public char MaxEl()  //макс ел по алфавіту
        {
            char[] mas = new char[items.Length];
            for(int i = 0; i < items.Length; i++)  //перекидали дані в чар масив, бо той не посортируємо
            {
                mas[i] = items[i].inf;  
            }
            Array.Sort(mas);  // сорт
            return mas[items.Length - 1];  //ретун останній last
        }
    }    
}




//public void EnQueue(T data)
//{
//    var item = new Item<T>(data); //new item

//            if (tail != null) //if isnt empty
//            {
//                item.left = tail;
//                item.right = head;
//                tail.right = item;
//                head.left = item;
//            }
//            else // if  empty
//            {
//                head = tail = item;
//                item.left = item.right = item;
//            }

//count++;
//tail = item; // tail become new item
//}
//public bool dequeue()
//{
//    bool res = true;
//    if (count == 0)
//    {
//        res = false;
//    }
//    else
//    {
//        head = head.right;
//        head.left = tail;
//        tail.right = head;
//        count--;
//    }
//    return res;
//}