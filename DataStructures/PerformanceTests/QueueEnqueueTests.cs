using DataStructures.Queue;
using NUnit.Framework;

namespace DataStructures.PerformanceTests
{
    [TestFixture]
    public class QueueEnqueueTests : TestBase
    {
        private const int Elements = 100000001;

        [Test]
        public void LinkedListQueueEnqueueTest()
        {
            var queue = new LinkedListQueue<int>();
            for (var i = 0; i < Elements; i++)
            {
                queue.Enqueue(i * 10);
            }
            Assert.AreEqual(0, queue.Peek());
        }

        [Test]
        public void ArrayQueueEnqueueTest()
        {
            var queue = new ArrayQueue<int>(Elements);
            for (var i = 0; i < Elements; i++)
            {
                queue.Enqueue(i * 10);
            }
            Assert.AreEqual(0, queue.Peek());
        }
    }
}
