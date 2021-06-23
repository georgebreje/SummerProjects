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
            StreamReader load = new StreamReader(@"../../QuestionsInput.txt");
            string buffer;
            List<Question> questionlist = new List<Question>();
            int i = 0;
            while((buffer = load.ReadLine()) != null)
            {
                questionlist.Add(new TFQuestion());
                questionlist[i].Text = buffer;
                i++;
            }

            foreach(TFQuestion q in questionlist)
                Console.WriteLine(q.Text);
        }
    }
}