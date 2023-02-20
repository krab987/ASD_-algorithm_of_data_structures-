using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR
{
    public class Item
    {
        public Item left, right; //лівий правий 
        public int inf;  //інфа
        public int key;
        public Item(int inf, int key)
        {
            this.key = key; ;
            this.left = null;
            this.right = null;
            this.inf = inf;
        }

    }
}
