using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Table
    {
        private int _count;
        public int CountPersons
        {
            get { return _count; }
            set { _count = value; }
        }
        public Table(int count)
        {
            _count = count;
        }
    }
}
