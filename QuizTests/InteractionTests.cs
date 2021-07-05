using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz.Tests
{
    [TestClass()]
    public class InteractionTests
    {
        [TestMethod()]
        public void ParseQuestionsFromTextTest()
        {
            // arrange 
            StreamReader load = new StreamReader(@"../../QuizInput.txt");
            Interaction interaction = new Interaction(load);

            // act
            interaction.ParsedQuestionsFromText();
            string[] actual = new string[3];
            for (int i = 0; i < 3; i++)
                actual[i] = interaction.Questions[i].Text;

            string[] expected =
            {
                "Are vaca aripi? 25",
                "Ursul are coada? 25",
                "In ce an suntem? 50"
            };
            // assert
            Assert.AreEqual(actual, expected);
        }
    }
}