using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearDataStructures;

namespace UnitTestProject1
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestAddFirst()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(13);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(13, list.First.Data);
            Assert.AreEqual(13, list.Last.Data);
            list.AddFirst(20);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(20, list.First.Data);
            Assert.AreEqual(13, list.Last.Data);
        }
        [TestMethod]
        public void TestAddLast()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(13);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(13, list.First.Data);
            Assert.AreEqual(13, list.Last.Data);
            list.AddLast(20);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(13, list.First.Data);
            Assert.AreEqual(20, list.Last.Data);
        }
    }
}
