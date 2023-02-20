using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_window.Module
{
    public class Sentence
    {
        string nameSentance;
        Sentence nextSentence;
        Word begin, end;

        public Sentence NextSentence 
        { 
            get { return nextSentence; }
            set { nextSentence = value; }

        }

        public Sentence(string s)
        {
            nameSentance = s;
            nextSentence = null;
        }
        void AddWord(string s)
        {
            Word word = new Word(s);    
            if (end == null)
                begin = end = null;
            else
            {
                end.NextWord = word;
                end = word;
            }
        }
        public override string ToString()
        {
            string res = "Sentance: ";
            for (Word t = begin; t != null; t = t.NextWord)
                res += t.ToString();

            res += "\n";
            return res;
        }


    }
}
