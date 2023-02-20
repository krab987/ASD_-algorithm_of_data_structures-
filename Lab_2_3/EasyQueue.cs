using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    public class EasyQueue<T>
    {
        private T[] mas;
        private Item<T> head;
        private Item<T> tail;

        public int count { get; private set; }
        public EasyQueue() { }
        public EasyQueue(int size)
        {
            T[] mas = new T[size];
            count = 0;
        }
        public void EnQueue(T data)
        {
            var item = new Item<T>(data); //new item
            
            if (tail != null) //if isnt empty
            {
                item.left = tail;
                item.right = head;
                tail.right = item;
                head.left = item;
            }
            else // if  empty
            {
                head = tail = item;
                item.left = item.right = item;
            }
            
            count++;
            tail = item; // tail become new item
        }
        public bool DeQueue()
        {
            bool res = true;
            if (count == 0)
            {
                res = false;
            }
            else
            {
                head = head.right;
                head.left = tail;
                tail.right = head;
                count--;
            }
            return res;
        }

        public override string ToString()
        {
            string res = "";
            

            for(string temp = Convert.ToString(head); temp != Convert.ToString(tail); temp = Convert.ToString(head.right))
            {
                res += temp;
            }

            return res;
        }
    }
}
