using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class LinkedListNode<GenericType>
    {
        public GenericType Data { get; set; }
        public LinkedListNode<GenericType> Next { get; set; }
        public LinkedListNode(GenericType data, LinkedListNode<GenericType> next)
        {
            Data = data;
            Next = next;
        }
    }
}
