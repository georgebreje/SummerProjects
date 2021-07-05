using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Solver
    {
        private Random rnd = new Random();
        public float GainedPoints { get; set; }
        private Quiz toSolve;
        public Solver(Quiz quiz) 
        {
            toSolve = quiz;
            StartSolving();
        }
        public void StartSolving()
        {
            int select = 0;
            for(int i = 0; i < toSolve.Questions.Count; i++)
            {
                select = rnd.Next(toSolve.Answers[i].Text.Count); // select a random answer
                if (toSolve.Answers[i].Text[select].Contains('.'))     // if answer's correct
                    GainedPoints += toSolve.Questions[i].Points / toSolve.Answers[i].CorrectChoice; // add the amount of points divided by the number of correct answers
            }
        }
    }
}
