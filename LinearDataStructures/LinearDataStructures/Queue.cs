using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class Queue<GenericType>
    {
        private LinkedList<GenericType> List { get; set; }
        // public int Count { get; set; }
        public int Count { get { return List.Count; } }
        public Queue()
        {
            List = new LinkedList<GenericType>();
        }
        public void Enqueue(GenericType data)
        {
            List.AddLast(data);
        }
        public GenericType Dequeue()
        {
            GenericType data = List.First.Data;
            List.RemoveFirst();
            return data;
        }
        public int Peek()
        {
            throw new NotImplementedException();
        }
    }
}
