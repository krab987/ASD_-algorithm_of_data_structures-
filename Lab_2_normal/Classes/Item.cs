using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_normal.Classes
{
    public class Item
    {
        //public Item left, right; //лівий правий 
        public char inf;  //інфа
        public Item left, right;

        public Item(char inf)
        {
            this.left = null;
            this.right = null;
            this.inf = inf;
        }

    }
}
