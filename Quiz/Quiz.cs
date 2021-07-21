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
            Questions = parser.Questions;
            Answers = parser.Answers;
            Score = CalculateTotalScore();
        }

        private float CalculateTotalScore()
        {
            float total = 0;
            foreach (Question q in Questions)
                total += q.Points;
            return total;
        }

        internal class QuizDataSet
        {
        }

        internal class QuizDataSetTableAdapters
        {
            internal class TableAdapterManager
            {
                internal void UpdateAll(QuizDataSet quizDataSet)
                {
                    throw new NotImplementedException();
                }
            }

            internal class QuizOneTableAdapter
            {
            }
        }
    }
}
