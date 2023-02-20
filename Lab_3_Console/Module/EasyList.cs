using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Console.Module
{
    public class EasyList
    {
        int indList;
        List<Element> myList;
        public int IndList
        {
            get { return indList; } 
            set { indList = value; }
        }
        public List<Element> MyList
        {
            get { return myList; }  
            set { myList = value; }
        }
        public EasyList(int indList)
        {
            this.indList = indList;
            myList = new List<Element>();
        }

        public void AddEl(Element el)
        {
            myList.Add(el);
        }
        public void AddEl(Element el, int index)
        {
            myList.Insert(index,el);
        }
        public void RemoveEl(Element el)
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
                foreach (Element el in MyList)
                    res += el.ToString();
            return res;
        }
    }
}
