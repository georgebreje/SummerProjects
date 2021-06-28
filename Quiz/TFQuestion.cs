using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class TFQuestion : Question  //true or false
    {
        public string Text { get; set; }
        public int Points { get; set; }

        public TFQuestion()
        {

        }

    }
}
