
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

        public int GetRightChildIndex(int nodeIndex)
        {
            int childIndex = 2 * nodeIndex + 2;
            if (childIndex < Size)
            {
                return childIndex;
            }
            else
            {
                throw new IndexOutOfRangeException("Index not in heap");
            }
        }

        public int GetRightChildValue(int nodeIndex)
        {
            return GetNodeValue(GetRightChildIndex(nodeIndex));
        }

        public bool HasLeftChild(int nodeIndex)
        {
            int childIndex = 2 * nodeIndex + 1;
            if (childIndex < Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRightChild(int nodeIndex)
        {
            try
            {
                GetRightChildIndex(nodeIndex);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int Pop()
        {
            int output = GetRoot();
            Size--;
            Array[0] = Array[Size];
            SiftDown(0);
            return output;
        }

        private void SiftDown(int nodeIndex)
        {
            int indexOfChildWithMaxValue = -1;
            if (HasLeftChild(nodeIndex) && HasRightChild(nodeIndex))
            {
                indexOfChildWithMaxValue = GetLeftChildValue(nodeIndex) > GetRightChildValue(nodeIndex) ?
                    GetLeftChildIndex(nodeIndex) : GetRightChildIndex(nodeIndex);
            } else if (HasLeftChild(nodeIndex))
            {
                indexOfChildWithMaxValue = GetLeftChildIndex(nodeIndex);
            } else if (HasRightChild(nodeIndex))
            {
                indexOfChildWithMaxValue = GetRightChildIndex(nodeIndex);
            } else
            {
                return;
            }
            if (GetNodeValue(nodeIndex) < GetNodeValue(indexOfChildWithMaxValue))
            {
                Swap(nodeIndex, indexOfChildWithMaxValue);
                SiftDown(indexOfChildWithMaxValue);
            }
        }

        private void Swap(int node1Index, int node2Index)
        {
            int temp = GetNodeValue(node1Index);
            Array[node1Index] = GetNodeValue(node2Index);
            Array[node2Index] = temp;
        }
    }
}
