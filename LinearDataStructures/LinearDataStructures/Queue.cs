using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class Queue
    {
        private LinkedList List { get; set; }
        public int Count { get; set; }
        public Queue()
        {
            Count = 0;
            List = new LinkedList();
        }
        public void Enqueue(int data)
        {
            throw new NotImplementedException();
        }
        public int Dequeue()
        {
            throw new NotImplementedException();
        }
        public int Peek()
        {
            throw new NotImplementedException();
        }
    }
}
