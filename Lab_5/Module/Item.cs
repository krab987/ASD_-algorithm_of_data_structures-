using lab_5.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Module
{
    public class Item
    {
        public EasyQueue easyQueue;
        public Item left; //лівий правий 
        public int inf;  //інфа

        public Item(int inf)
        {
            this.left = null;
            this.inf = inf;
        }

        public static implicit operator Item(ItemQueue v)
        {
            throw new NotImplementedException();
        }
    }
}
