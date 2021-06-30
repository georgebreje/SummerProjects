using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Tests
{
    [TestClass()]
    public class ParseDataTests
    {
        [TestMethod()]
        public void ParserTest()
        {
            // arrange
            Quiz myQuiz = new Quiz(@"../../Quiz.txt");

            // act
            var actual = myQuiz.Score;
            var expected = 100;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}