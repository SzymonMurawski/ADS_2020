using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
