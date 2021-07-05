using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Answer
    {
        public List<string> Text = new List<string>();
        public int CorrectChoice { get; set; }
        public Answer() { }
    }
}