using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_window.Module
{
    public class Chapter
    {
        string nameChapter;
        Chapter nextChapter;
        Sentence begin, end;
        public Chapter NextChapter 
        { 
            get { return nextChapter; }
            set { nextChapter = value; }
        }

        public Chapter(string nameChapter)
        {
            this.nameChapter = nameChapter;
            nextChapter = null;
        }

        void AddSentence(string s)
        {
            Sentence sentance = new Sentence(s);
            if (end == null) 
                begin = end = null;
            else
            {
                end.NextSentence = sentance;
                end = sentance;
            }
        }
        public override string ToString()
        {
            string res = "Chapter: ";
            for (Sentence t = begin; t != null; t = t.NextSentence)
                res += t.ToString();

            res += "\n";
            return res;
        }
    }
}
