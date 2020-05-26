﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Heapsort;

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
    }
}
