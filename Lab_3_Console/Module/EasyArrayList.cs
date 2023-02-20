using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Console.Module
{
    public class EasyArrayList
    {
        ArrayList myArrayList;

        public EasyArrayList()
        {
            myArrayList = new ArrayList();
        }
        public ArrayList MyArrayList
        {
            get { return myArrayList; }
            set { myArrayList = value; }
        }
        public void AddEl(EasyList el)
        {
            myArrayList.Add(el);    
        }
        public void AddEl(EasyList el, int index)
        {
            myArrayList.Insert(index, el);
        }
        public void RemoveEl(EasyList el)
        {
            if(el.MyList.Count != 0)
                el.MyList.Clear();
            myArrayList.Remove(el);
        }
        public void RemoveEl(int index)
        {
            if ((MyArrayList[index] as EasyList).MyList.Count != 0)
                (MyArrayList[index] as EasyList).MyList.Clear();
            MyArrayList.RemoveAt(index);
        }
        public void RemoveEl(int i,int j)// remove from i list j pidlist
        {
            (MyArrayList[i] as EasyList).RemoveEl(j);
        }
        public override string ToString()
        {
            string res = " ";
            if (MyArrayList.Count > 0)
                foreach (object obj in MyArrayList)
                    res += obj.ToString() + "\n";
            return res;
        }
    }
}
