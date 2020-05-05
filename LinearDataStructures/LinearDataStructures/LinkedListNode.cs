using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class LinkedListNode
    {
        public int Data { get; set; }
        public LinkedListNode Next { get; set; }
        public LinkedListNode(int data, LinkedListNode next)
        {
            Data = data;
            Next = next;
        }
    }
}
