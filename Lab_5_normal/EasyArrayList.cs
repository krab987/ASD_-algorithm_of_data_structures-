using Lab_5_normal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_normal
{
    public class EasyArrayList
    {
        ArrayList myArrayList;

        public EasyArrayList()
        {
            myArrayList = new ArrayList();

        }
        public void AddEl(EasyQueue el) 
        {
            myArrayList.Add(el);
        }

        public override string ToString()
        {
            string res = "";
            int num = 0;
            foreach (EasyQueue el in myArrayList)
            {
                num++;
                res += "TOP " + Convert.ToString(num)+ ":";
                res += el.ToString() + "\n";
            }
                
            return res;
        }

    }
}