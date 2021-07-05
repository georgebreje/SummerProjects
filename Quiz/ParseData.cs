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
        private string path;

        public List<Question> Questions = new List<Question>();

        public List<Answer> Answers = new List<Answer>();

        public ParseData(string path)
        {
            this.path = path;
            ParsingProcess();
        }

        private void ParsingProcess()
        {
            StreamReader load = new StreamReader(path);
            Interaction interaction = new Interaction(load);

            Questions = interaction.Questions;
            Answers = interaction.Answers;
        }

    }
}
