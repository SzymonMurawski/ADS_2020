using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearDataStructures;

namespace UnitTestProject1
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void TestEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(11);
            Assert.AreEqual(1, queue.Count);
            queue.Enqueue(12);
            Assert.AreEqual(2, queue.Count);
        }
        [TestMethod]
        public void TestDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(11);
            queue.Enqueue(12);
            int element = queue.Dequeue();
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(11, element);
            element = queue.Dequeue();
            Assert.AreEqual(0, queue.Count);
            Assert.AreEqual(12, element);
        }
    }
}
