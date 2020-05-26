using Microsoft.VisualStudio.TestTools.UnitTesting;
using Heapsort;
using System;

namespace UnitTests
{
    [TestClass]
    public class HeapTests
    {
        [TestMethod]
        public void TestGetRoot()
        {
            Heap heap = new Heap(new int[] { 16,14,10,8,7,9,3,2,4,1});
            Assert.AreEqual(16, heap.GetRoot());
        }
        [TestMethod]
        public void TestGetNodeValue()
        {
            Heap heap = new Heap(new int[] { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 });
            Assert.AreEqual(8, heap.GetNodeValue(3));
            Assert.AreEqual(16, heap.GetNodeValue(0));
            Assert.AreEqual(1, heap.GetNodeValue(9));
        }
        [TestMethod]
        public void TestGetParentIndex()
        {
            Heap heap = new Heap(new int[] { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 });
            Assert.AreEqual(0, heap.GetParentIndex(1));
            Assert.AreEqual(1, heap.GetParentIndex(3));
            Assert.AreEqual(4, heap.GetParentIndex(9));
            Assert.AreEqual(2, heap.GetParentIndex(6));
        }
        [TestMethod]
        public void TestGetParentValue()
        {
            Heap heap = new Heap(new int[] { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 });
            Assert.AreEqual(16, heap.GetParentValue(1));
            Assert.AreEqual(14, heap.GetParentValue(3));
            Assert.AreEqual(7, heap.GetParentValue(9));
            Assert.AreEqual(10, heap.GetParentValue(6));
        }

        [TestMethod]
        public void TestGetLeftChildIndex()
        {
            Heap heap = new Heap(new int[] { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 });
            Assert.AreEqual(3, heap.GetLeftChildIndex(1));
            Assert.AreEqual(7, heap.GetLeftChildIndex(3));
            Assert.AreEqual(5, heap.GetLeftChildIndex(2));
            Assert.ThrowsException<IndexOutOfRangeException>(() => heap.GetLeftChildIndex(7));
        }
        [TestMethod]
        public void TestGetLeftChildValue()
        {
            Heap heap = new Heap(new int[] { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 });
            Assert.AreEqual(8, heap.GetLeftChildValue(1));
            Assert.AreEqual(2, heap.GetLeftChildValue(3));
            Assert.AreEqual(9, heap.GetLeftChildValue(2));
            Assert.ThrowsException<IndexOutOfRangeException>(() => heap.GetLeftChildValue(7));
        }

        [TestMethod]
        public void TestGetRightChildIndex()
        {
            Heap heap = new Heap(new int[] { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 });
            Assert.AreEqual(4, heap.GetRightChildIndex(1));
            Assert.AreEqual(8, heap.GetRightChildIndex(3));
            Assert.AreEqual(6, heap.GetRightChildIndex(2));
            Assert.ThrowsException<IndexOutOfRangeException>(() => heap.GetRightChildIndex(7));
        }
        [TestMethod]
        public void TestGetRightChildValue()
        {
            Heap heap = new Heap(new int[] { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 });
            Assert.AreEqual(7, heap.GetRightChildValue(1));
            Assert.AreEqual(4, heap.GetRightChildValue(3));
            Assert.AreEqual(3, heap.GetRightChildValue(2));
            Assert.ThrowsException<IndexOutOfRangeException>(() => heap.GetRightChildValue(7));
        }
        [TestMethod]
        public void TestHasLeftChild()
        {
            Heap heap = new Heap(new int[] { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 });
            Assert.AreEqual(true, heap.HasLeftChild(1));
            Assert.AreEqual(false, heap.HasLeftChild(5));
        }
        [TestMethod]
        public void TestHasRightChild()
        {
            Heap heap = new Heap(new int[] { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 });
            Assert.AreEqual(true, heap.HasRightChild(1));
            Assert.AreEqual(false, heap.HasRightChild(5));
        }
        [TestMethod]
        public void TestPop()
        {
            Heap heap = new Heap(new int[] { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 });
            Assert.AreEqual(16, heap.Pop());
            Assert.AreEqual(14, heap.GetRoot());
            Assert.AreEqual(14, heap.Pop());
            Assert.AreEqual(10, heap.GetRoot());
        }
        [TestMethod]
        public void TestCreateHeapSimple()
        {
            Heap heap = new Heap(new int[] { 1, 2, 3 });
            CollectionAssert.AreEqual(new int[] { 3, 2, 1}, heap.Array);
        }
        [TestMethod]
        public void TestHeapsort()
        {
            int[] array = new int[] { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 };
            Heap.Heapsort(array);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 7, 8, 9, 10, 14, 16 }, 
                array);
        }
    }
}
