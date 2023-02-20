using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_window.Module
{
    public class Book
    {
        Chapter begin,end;
        string title;
        public Book(string title)
        {
            this.title = title;
            begin = null;
            end = null;
        }

        public void AddChapter(string s)
        {
            Chapter chapter = new Chapter(s); 
            if(end == null)
            {
                begin = end = chapter;
            }
            else
            {
                end.NextChapter = chapter;
                end = chapter;
            }
                
        }
        public override string ToString()
        {
            string res = "Book: ";
            for (Chapter t = begin; t != null; t = t.NextChapter)
                res += t.ToString();

            res += "\n";
            return res;
        }
    }
}
