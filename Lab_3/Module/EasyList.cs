using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Module
{
    public class EasyList
    {
        int indList;
        List<Item> myList;
        public int IndList
        {
            get { return indList; } 
            set { indList = value; }
        }
        public List<Item> MyList
        {
            get { return myList; }  
            set { myList = value; }
        }
        public EasyList(int indList)
        {
            this.indList = indList;
            myList = new List<Item>();
        }

        public void AddEl(Item el)
        {
            myList.Add(el);
        }
        public void AddEl(Item el, int index)
        {
            myList.Insert(index,el);
        }
        public void RemoveEl(Item el)
        {
            myList.Remove(el);
        }
        public void RemoveEl(int index)
        {
            myList.RemoveAt(index);
        }

        public override string ToString()
        {
            string res = indList.ToString()+" -> ";
            if (MyList.Count > 0)
                foreach (Item el in MyList)
                    res += el.ToString();
            return res;
        }
    }
}
