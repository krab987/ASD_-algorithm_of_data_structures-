using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Module
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
        public void AddEl(EasyLinkedList el) //add
        {
            myArrayList.Add(el);    
        }
        public void AddEl(int index, EasyLinkedList el) //add by index
        {
            myArrayList.Insert(index, el);
        }
        public void RemoveEl(EasyLinkedList el) //remove
        {
            if(el.MyList.Count != 0)
                el.MyList.Clear();
            myArrayList.Remove(el);
        }
        public void RemoveEl(int index)
        {
            if ((MyArrayList[index] as EasyLinkedList).MyList.Count != 0)
                (MyArrayList[index] as EasyLinkedList).MyList.Clear();
            MyArrayList.RemoveAt(index);
        }

        public void RemoveEl(int i, string j)// remove from i list j pidlist
        {
            (myArrayList[i] as EasyLinkedList).RemoveEl((myArrayList[i] as EasyLinkedList).Find(j));
        }
        public void AddFirstElem(int i, Item el)// remove from i list j pidlist
        {
            (myArrayList[i] as EasyLinkedList).AddFirstEl(el);
        }
        public void AddLastElem(int i, Item el)// remove from i list j pidlist
        {
            (myArrayList[i] as EasyLinkedList).AddLastEl(el);
        }
    }
}



//public void AddElBefore(int i, string j, Item e)// remove from i list j pidlist
//{
//    (myArrayList[i] as EasyLinkedList).AddBeforeEl((j, e));
//}
//public void AddElAfter(int i, string j, Item el)// remove from i list j pidlist
//{
//    (myArrayList[i] as EasyLinkedList).AddAfterEl((j, el));
//}



//public override string ToString()
//{
//    string res = " ";
//    if (MyArrayList.Count > 0)
//        foreach (object obj in MyArrayList)
//            res += obj.ToString() + "\n";
//    return res;
//}