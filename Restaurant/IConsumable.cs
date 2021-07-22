using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    interface IConsumable
    {
        void AccessStock();
        void ReceivedOrder();   // modify qunatities and deliver it forward to client
    }
}
