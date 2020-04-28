using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.AddAtStart(1123);
            ll.AddAtStart(233);
            ll.AddAtStart(128);
            ll.RemoveFromStart();
            ll.RemoveFromStart();
            ll.RemoveFromStart();
            ll.RemoveFromStart();
        }
    }
}
