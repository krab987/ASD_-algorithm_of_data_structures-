using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_window.Module
{
    public class Tree
    {
        Item firstEl;
        Item tail;
        public Item FirstEl { get { return firstEl; } }
        /// <summary>
        /// Пустий конструктор
        /// </summary>
        public Tree() 
        {
            firstEl = new Item("Книга");
            tail = firstEl;
        }

        public void AddLeft(Item el)
        {
            if (tail.left == null)
            {
                tail.left = el;
                if(tail.right == null)
                    tail = el;
            }
        }
        public void AddRight(Item el)
        {
            if (tail.right == null)
            {
                tail.right = el;
                if (tail.left == null)
                    tail = el;
            }
        }
        public Item Find(Item el, string inf)
        {
            if (el == null) //якщо пусто - записали пустоту
                tail = null;
            else if (el.inf == inf) //совпало - цей записали
                tail = el;
            else
            {
                tail = Find(el.left, inf); //пішли вліво

                if (tail == null) // якщо там пусто
                    tail = Find(el.right, inf); //пішли вправо
            }
            return tail;
        }
        public Item FindFather(Item el, Item elSon)
        {
            if (el == null) //якщо пусто - записали пустоту
                tail = null;
            else if (el.left == elSon || el.right == elSon) //совпало - цей записали
                tail = el;
            else
            {
                tail = FindFather(el, elSon); //пішли вліво

                if (tail == null) // якщо там пусто
                    tail = FindFather(el, elSon); //пішли вправо
            }
            return tail;
        }

        public void Remove(ref Item root, string inf)
        {
            tail = Find(root, inf);

            if (tail == null)
                throw new Exception("Item wasn't found");

            Item father = FindFather(root, tail);

            if (father == null)
                tail = null;
            else if (father.left.inf == inf)
                father.left = null;
            else
                father.right = null;
        }
        public string koString()
        {
            string res = firstEl.inf;

            //Item elsLeft = firstEl;
            //while (firstEl != null)
            //{
            //    firstEl = firstEl.left;
            //    Item root = firstEl.left;
            //    while (root != null)
            //    {
            //        res += " " + root.inf;
            //        root = root.right;
            //    } 
            //    res += "\n";
            //}
            Item begin;

            for (Item i = firstEl.left; i != null; i = i.right)
            {
                if (i.left != null)
                    begin = i;
                res += " " + i.inf;
            }

            for (Item i = firstEl; i != null; i = i.left)
            {
                for(Item j = i; j != null; j = j.right)
                {
                    res += " " + j.inf;
                }
                res += "\n";
            }

            return res;

        }
        public void TreeToString(Item el, ref string res)
        {
            if (el != null)
            {
                res += el.inf;
                TreeToString(el.left, ref res);
                TreeToString(el.right, ref res);
            }
        }
        public override string ToString()
        {
            string res = "";
            TreeToString(firstEl, ref res);
            return res;
        }
    }
}
