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
            LinkedList<int> ll = new LinkedList<int>();
            ll.RemoveFirst();
            ll.AddFirst(1123);
            ll.AddFirst(233);
            ll.AddFirst(128);
            ll.RemoveFirst();
            ll.RemoveFirst();
            ll.RemoveFirst();
            ll.RemoveFirst();
        }
    }
}
