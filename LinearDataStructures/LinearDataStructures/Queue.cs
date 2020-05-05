﻿using System;
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
            List.AddLast(data);
            Count++;
        }
        public int Dequeue()
        {
            int data = List.First.Data;
            List.RemoveFirst();
            Count--;
            return data;
        }
        public int Peek()
        {
            throw new NotImplementedException();
        }
    }
}
