using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Module
{
    public class EasyLinkedList
    {
        int indList;
        LinkedList<Item> myList;
        
        public LinkedList<Item> MyList
        {
            get { return myList; }
            set { myList = value; }
        }
        public EasyLinkedList(int indList)
        {
            this.indList = indList;
            myList = new LinkedList<Item>();
        }
        
        public void AddFirstEl(Item el)
        {
            myList.AddFirst(el);
        }
        public void AddLastEl(Item el)
        {
            myList.AddLast(el);
        }

        public void RemoveEl(Item el)
        {
            myList.Remove(el);
        }
        public void RemoveFirstEl()
        {
            myList.RemoveFirst();
        }
        public void RemoveLastEl()
        {
            myList.RemoveLast();
        }

        public Item Find(string s)
        {
            Item res = null;
            foreach (Item it in myList)
            {
                if (it.Inf == s)
                {
                    res = it;           
                }
            }
            return res;
        }



        public override string ToString()
        {
            string res = indList.ToString() + " -> ";
            if (MyList.Count > 0)
                foreach (Item el in MyList)
                    res += el.ToString();
            return res;
        }
    }
}



//public void AddAfterEl(string s, Item el)
//{
//    LinkedListNode<Item> p = myList.Find(Find(s));
//    myList.AddAfter(p, el);
//}
//public void AddBeforeEl(string s, Item el)
//{
//    LinkedListNode<Item> p = myList.Find(Find(s));
//    myList.AddBefore(p, el);
//}