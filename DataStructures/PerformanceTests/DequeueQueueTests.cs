using DataStructures.Queue;
using NUnit.Framework;

namespace DataStructures.PerformanceTests
{
    [TestFixture]
    public class QueueDequeueTests : TestBase
    {
        private const int Elements = 100000001;
        private ArrayQueue<int> _arrayQueue;
        private LinkedListQueue<int> _linkedListQueue;

        [SetUp]
        public override void Init()
        {
            _linkedListQueue = new LinkedListQueue<int>();
            _arrayQueue = new ArrayQueue<int>(Elements);

            for (var i = 0; i < Elements; i++)
            {
                _linkedListQueue.Enqueue(i * 10);
                _arrayQueue.Enqueue(i * 10);
            }
            base.Init();
        }

        [Test]
        public void LinkedListDeqeueEnqueueTest()
        {
            for (var i = 0; i < Elements - 1; i++)
            {
                _linkedListQueue.Dequeue();
            }
            Assert.AreEqual(1000000000, _linkedListQueue.Peek());
        }

        [Test]
        public void ArrayQueueDequeueTest()
        {
            for (var i = 0; i < Elements - 1; i++)
            {
                _arrayQueue.Dequeue();
            }
            Assert.AreEqual(1000000000, _arrayQueue.Peek());
        }
    }
}
