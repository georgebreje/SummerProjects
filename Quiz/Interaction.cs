using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz
{
    public class Interaction
    {
        public List<Question> Questions = new List<Question>();

        public List<Answer> Answers = new List<Answer>();

        private StreamReader load;

        public Interaction(StreamReader load)
        {
            this.load = load;
            ParseDataFromText();
        }

        private void ParseDataFromText()
        {
            string buffer;
            int index = -1;

            while ((buffer = load.ReadLine()) != null)
            {
                if (buffer.Contains('?'))
                {
                    Question q = new Question();
                    q.Text = buffer;
                    q.Points = PointsParser(buffer);
                    Questions.Add(q);
                    Answers.Add(new Answer());      // same number of questions/answers
                    index++;
                }
                else
                {
                    Answers[index].Choices.Add(new Answer.Choice(buffer));
                    int i = Answers[index].Choices.Count - 1;
                    if (buffer.Contains('.'))
                        Answers[index].Choices[i].IsCorrect = true;


                    //Answers[index].Text.Add(buffer);
                    //if (buffer.Contains('.'))
                    //    Answers[index].CorrectChoice++;
                }
            }
        }

        private int PointsParser(string line)
        {
            int points = 0;
            foreach (char c in line)
                if (Char.IsDigit(c))
                    points = points * 10 + ((int)c - (int)'0');

            return points;
        }

        public void DisplayQuestion()
        {

        }
    }
}
