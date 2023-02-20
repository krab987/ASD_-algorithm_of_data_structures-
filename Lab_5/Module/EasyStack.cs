using Lab_5.Module;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab_5.Module
{
    public class EasyStack
    {
        Item top;
        public EasyStack() 
        {
            top = null;
        }
        public void Push(int inf, EasyQueue easyQueue)
        {
            Item temp = new Item(inf);
            Item last;
            if (top != null)
            {
                last = top.left;
                while (last.left != top)
                    last = last.left;
                temp.left = top;
                last.left = temp;
            }
            else
            {
                temp.left = temp;
                temp.left.easyQueue = easyQueue;
            }
            top = temp;
            top.easyQueue = easyQueue;
        }
        public string StringTop()
        {
            string res = "\n\n";
            if (top == null) return res;
            Item el = top;
            do
            {
                res += $"Vertex #{el.inf}";
                res = el.easyQueue.String(res) + "\n";
                el = el.left;
            } while (el != top);
            return res;
        }
    }
}
