using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Quiz
    {
        private ParseData parser;
        public List<Question> Questions;
        public List<Answer> Answers;
        public float Score = 0;
        public Quiz(string path)
        {
            parser = new ParseData(path);
            Questions = this.parser.Questions;
            Answers = this.parser.Answers;
        }
    }
}
