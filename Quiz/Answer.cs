using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public enum AnswerType
    {
        Custom,
        Choice
    }
    public class Answer
    {
        public int ChoiceCount { get; set; }
        public string[] Text = new string[1];
        public AnswerType Type { get; set; }
        public Answer() { }
        public void Display()
        {
            foreach(string s in Text)
                Console.WriteLine(s);
        }
    }
}