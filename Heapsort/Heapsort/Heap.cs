
using System;

namespace Heapsort
{
    public class Heap
    {
        public int[] Array { get; set; }
        public int Size { get; set; }
        public Heap(int[] array)
        {
            Array = array;
            Size = array.Length;
            //TODO: implement Floyd's algorithm for creating a heap from an array
        }

        public int GetRoot()
        {
            return GetNodeValue(0);
        }

        public int GetNodeValue(int nodeIndex)
        {
            return Array[nodeIndex];
        }

        public int GetParentIndex(int nodeIndex)
        {
            return (nodeIndex - 1) / 2;
        }

        public int GetParentValue(int nodeIndex)
        {
            return GetNodeValue(GetParentIndex(nodeIndex));
        }

        public int GetLeftChildIndex(int nodeIndex)
        {
            int childIndex = 2 * nodeIndex + 1;
            if (childIndex < Size)
            {
                return childIndex;
            } else
            {
                throw new IndexOutOfRangeException("Index not in heap");
            }
           
        }

        public int GetLeftChildValue(int nodeIndex)
        {
            return GetNodeValue(GetLeftChildIndex(nodeIndex));
        }
    }
}
