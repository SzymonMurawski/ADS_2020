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
        // public int Count { get; set; }
        public int Count { get { return List.Count; } }
        public Queue()
        {
            List = new LinkedList();
        }
        public void Enqueue(int data)
        {
            List.AddLast(data);
        }
        public int Dequeue()
        {
            int data = List.First.Data;
            List.RemoveFirst();
            return data;
        }
        public int Peek()
        {
            throw new NotImplementedException();
        }
    }
}
