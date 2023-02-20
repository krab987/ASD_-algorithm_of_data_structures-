using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_window.Module
{
    public class Word
    {
        Word nextWord;
        string word;
        public Word NextWord
        {
            get { return NextWord; }
            set { NextWord = value; }

        }
        public Word(string word) 
        {
            nextWord = null;
            this.word = word;
        }

        public override string ToString()
        {
            return word;
        }
    }
}
