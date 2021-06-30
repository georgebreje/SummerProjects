using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Answer
    {
        public int ChoiceCount { get; set; }
        public string[] Text = new string[1];
        public int CorrectChoiceIndex = 0;
        public Answer() { }
    }
}