using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Console.Module
{
    public class Element
    {
        int key;
        string inf;
        Element next;

        public int Key { get { return key; } }
        public string Inf { get { return inf; } }
        public Element Next { get { return next; } }
        public Element(int key, string inf)
        {
            this.key = key;
            this.inf = inf;
            next = null;
        }   
        public override string ToString()
        {
            return ($"Key = {key.ToString()} Inf = {inf} ");
        }

    }
}
