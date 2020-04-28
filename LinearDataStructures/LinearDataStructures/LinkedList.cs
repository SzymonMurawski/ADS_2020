using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    class LinkedList
    {
        public LinkedListNode First { get; set; }
        public LinkedListNode Last { get; set; }
        public int Count { get; set; }
        public LinkedList()
        {
            First = null;
            Last = null;
            Count = 0;
        }
        // This function will insert new element at the start of the linked list
        public void AddAtStart(int data)
        {
            LinkedListNode NewNode = new LinkedListNode(data, First);
            First = NewNode;
            Count++;
            if(Last == null)
            {
                Last = NewNode;
            }
        }
        public void RemoveFromStart()
        {
            // Check if list is empty
            if(First == null)
            {
                return;
            }
            First = First.Next;
            Count--;
        }
    }
}
