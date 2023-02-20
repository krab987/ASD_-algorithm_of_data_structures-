using lab_5.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Module
{
    public class ItemQueue
    {
        public Item left; //лівий правий 
        public int inf;  //інфа

        public ItemQueue(int inf)
        {
            this.left = null;
            this.inf = inf;
        }

        public static implicit operator ItemQueue(Item v)
        {
            throw new NotImplementedException();
        }
    }
}
