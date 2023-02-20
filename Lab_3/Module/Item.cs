using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Module
{
    public class Item
    {
        int key;
        string inf;
        public string Inf 
        { 
            get { return inf; } 
            set
            {
                if (value != null)
                    inf = value;
            }
        }
        public Item Next { get; set; }

        public Item(int key, string inf)
        {
            this.key = key;
            this.inf = inf;
        }
        public Item(string inf)
        {
            this.inf = inf;
        }
        public override string ToString()
        {
            return ($"Key = {key.ToString()} Inf = {inf} | ");
        }
    }
}
