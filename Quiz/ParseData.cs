using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz
{
    public class ParseData
    {
        public string Path { get; set; }
        public List<Question> Questions = new List<Question>();
        public List<Answer> Answers = new List<Answer>();


        public ParseData(string path)
        {
            Path = path;
        }

        public void Parser()
        {
            int aCount = 0, choices = 0; // count of answers and each answer's choices 
            string[] data = new string[1];
            StreamReader load = new StreamReader(Path);
            string buffer;
            int questionCount = 0;

            while ((buffer = load.ReadLine()) != null)
            {
                if (buffer.Contains('?'))
                {
                    Questions.Add(new Question());
                    Questions[questionCount].Text = buffer;
                    questionCount++;
                }
                else
                {
                    // blank lines divide answers
                    if (buffer == "")
                    {
                        Answers.Add(new Answer());
                        Answers[aCount].ChoiceCount = choices; // each answer has different count of choices
                        choices = 0;    // incrementing choices from 0 each time a new answer is found
                        Answers[aCount].Text = data;
                        data = new string[1];

                    }
                    // using two arrays to store lines at the moment of reading
                    else
                    {
                        if (buffer.Contains('.'))
                            Answers[aCount].CorrectChoiceIndex = choices; // save index of the correct choice
                        data[choices] = buffer;
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
            }
        }

    }
}
