using lab_5_normal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_normal.Module
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

        public void AddEl(EasyQueue el) 
        {
            myArrayList.Add(el);
        }

        public override string ToString()
        {
            string res = "";
            foreach (EasyQueue el in myArrayList)
            {
                res += el.ToString() + "\n";
            }
                
            return res;
        }

    }
}


//public void RemoveEl2(int i, int j)// remove from i list j pidlist
//{
//    (myArrayList[i] as EasyLinkedList).RemoveEl((myArrayList[i] as EasyLinkedList).Find(j));
//}