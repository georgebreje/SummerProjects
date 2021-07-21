using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz myQuiz = new Quiz(@"../../QuizInput.txt");
            Solver solver = new Solver(myQuiz);

            //Answer a = new Answer();
            //a.Choices.Add(new Answer.Choice("a"));
            //a.Choices.Add(new Answer.Choice("b."));
            //a.Choices.Add(new Answer.Choice("c"));
            //a.Choices.Add(new Answer.Choice("d"));

            //a.TestDisplay();
            
            //Console.WriteLine(solver.GainedPoints);
        }
    }
}