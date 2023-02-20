
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_normal
{
    public class Item
    {
        public Item left; //лівий правий 
        public int inf;  //інфа

        public Item(int inf)
        {
            this.left = null;
            this.inf = inf;
        }
    }
}
