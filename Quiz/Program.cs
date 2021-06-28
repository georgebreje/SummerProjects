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
            StreamReader qLoad = new StreamReader(@"../../QuestionsInput.txt");
            string buffer;
            List<Question> questions = new List<Question>();
            int qCount = 0;

            while ((buffer = qLoad.ReadLine()) != null)
            {
                questions.Add(new TFQuestion());
                questions[qCount].Text = buffer;
                qCount++;
            }

            foreach (TFQuestion q in questions)
                Console.WriteLine(q.Text);

            StreamReader aLoad = new StreamReader(@"../../AnswerInput.txt");
            string cushion;
            List<Answer> answers = new List<Answer>();
            int aCount = 0, choices = 0; // count of answers and each answer's choices 
            string[] data = new string[1];

            while ((cushion = aLoad.ReadLine()) != null)
            {
                // blank lines divide answers
                if (cushion == "")
                {
                    answers.Add(new Answer());
                    answers[aCount].ChoiceCount = choices; // each answer has different count of choices
                    choices = 0;    // incrementing choices for an answer
                    answers[aCount].Text = data;
                    data = new string[1];

                }
                // using two arrays to store lines at the moment of reading
                else
                {
                    data[choices] = cushion;
                    choices++;
                    string[] newData = new string[choices + 1];
                    for (int i = 0; i < choices; i++)
                    {
                        newData[i] = data[i];
                        data[i] = null;
                    }
                    data = newData;
                }
            }

            foreach (string s in answers[0].Text)
                Console.WriteLine(s);
        }
    }
}