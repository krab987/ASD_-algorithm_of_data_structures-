using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_normal.Classes
{
    public class EasyQueue
    {
        Item head, tail;
        int count;

        public EasyQueue()
        {
            head = null;
            tail = null;
            count = 0;  // к-сть ел
        }
        
        public void EnQueue(Item el)
        {
            if (tail != null) //if isnt empty
            {
                el.left = tail; // left of new -> previous
                el.right = head;// right of new -> head
                tail.right = el; // right of prev -> new
                head.left = el; // left of head -> new

                tail = el; //здвиг хвоста
            }
            else // if  empty
            {
                el.left = el.right = tail = head = el;
            }
            count++;
        }
        public bool DeQueue()
        {
            bool res = true;
            if (tail == null) //nema el to del
            {
                res = false;
            }
            else if (count == 1) //one el to delete
            {
                head = tail = null;
                count--;
            }
            else
            {
                head = head.right; //здвиг голови вправо
                head.left = tail;  //голова ліво на хвіст
                tail.right = head;  //хвіст право на голову
                count--;
            }
            return res;
        }
        public char MaxEl()  //макс ел по алфавіту
        {
            char[] mas = new char[count];
            int indexMas = 0;

            for (Item i = head; i != tail; i = i.right)
            {
                mas[indexMas] = i.inf;
                indexMas++;
            }

            Array.Sort(mas);  // сорт
            return mas[mas.Length - 1];  //ретун first el in mas
        }
        public override string ToString()/// рядок з інформацією зі черги
        {
            string res = "res = ";
            for(Item i = head; i != tail; i = i.right)
            {
                res += " " + i.inf;
            }
            res += " " + tail.inf;
            res += "\nMax el =" + MaxEl();
            return res;
        }

        public char Peek()
        {
            return head.inf;
        }  //firstel
        public int Count()
        {
            return count;
        }  //kolEl
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