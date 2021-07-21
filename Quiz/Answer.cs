using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Answer : IEnumerable<string>
    {
        public List<Choice> Choices { get; set; } = new List<Choice>();
        public Answer() { }
        public void TestDisplay()
        {
            foreach (Choice c in Choices)
                Console.WriteLine(c);
        }
        public class Choice
        {
            public bool IsCorrect { get; set; }
            
            private string _text;
            string Text
            {
                get
                {
                    return _text;
                }
                set
                {
                    _text = value;
                }
            }
            public Choice(string s)
            {
                _text = s;
            }

            public override string ToString()
            {
                return Text + " " + (IsCorrect ? "<-" : "X");
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            string current = Choices[0].ToString();
            for (int i = 0; i < Choices.Count; i++)
            {
                yield return current;
                current = Choices[i].ToString();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}