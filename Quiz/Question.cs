using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public interface Question
    {
        string Text { get; set; }
        int Points { get; set; }
    }
}
