﻿using System;
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
            Quiz myQuiz = new Quiz(@"../../Quiz.txt");
            ParseData load = new ParseData(myQuiz);



        }
    }
}