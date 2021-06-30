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
            ParseData Quiz = new ParseData(@"../../Quiz.txt");
            Quiz.Parser();

            // act
            var actual = Quiz.Questions[0].Text;
            var expected = "Are vaca aripi?";

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}