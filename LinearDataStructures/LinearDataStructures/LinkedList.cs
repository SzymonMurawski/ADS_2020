using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class LinkedList
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
        public void AddFirst(int data)
        {
            LinkedListNode NewNode = new LinkedListNode(data, First);
            First = NewNode;
            Count++;
            if(Last == null)
            {
                Last = NewNode;
            }
        }
        public void RemoveFirst()
        {
            // Check if list is empty
            if(First == null)
            {
                return;
            }
            First = First.Next;
            Count--;
        }
        public void AddLast(int data)
        {
            LinkedListNode NewNode = new LinkedListNode(data, null);
            if(Last == null) // there are no elements in List
            {
                First = NewNode;
                Last = NewNode;
            } else // there are some elements in our list
            {
                Last.Next = NewNode;
                Last = NewNode;
            }
            Count++;
        }
        public void RemoveLast()
        {

        }

    }
}
