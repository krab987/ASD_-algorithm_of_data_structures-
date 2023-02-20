using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    public class Item<T>
    {
        public T data { get; set; }
        public Item<T> left { get; set; }
        public Item<T> right { get; set; }


        public Item(T data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
