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
            LinkedList list = new LinkedList();
            list.AddFirst(13);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(13, list.First.Data);
            Assert.AreEqual(13, list.Last.Data);
            list.AddFirst(20);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(20, list.First.Data);
            Assert.AreEqual(13, list.Last.Data);
        }
    }
}
