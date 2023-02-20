
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab_5_normal
{
    public class EasyQueue
    {
        Item head, tail;
        
        public EasyQueue()
        {
            head = tail = null;
        }

        public void Enqueue(int inf)
        {
            Item temp = new Item(inf);
            if (tail != null)
            {
                temp.left = tail;
                head.left = temp;
            }
            else
            {
                head = temp.left = temp;
            }
            tail = temp;
        }
        public override string ToString()
        {
            string res = "";
            if (tail != null)
            {
                Item el = head;
                do
                {
                    res += " - " + (el.inf).ToString();
                    el = el.left;
                } while (el != head);
            }
            return res;
        }
    }
}
