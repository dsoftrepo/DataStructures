using DataStructures.Stack;
using NUnit.Framework;

namespace DataStructures.PerformanceTests
{
    [TestFixture]
    public class StackPushTests : TestBase
    {
        private const int Elements = 100000001;

        [Test]
        public void ArrayStackPushTest()
        {
            var arrayStack = new ArrayStack<int>(100);

            for (var i = 0; i < Elements; i++)
            {
                arrayStack.Push(i*10);
            }
            Assert.AreEqual(1000000000, arrayStack.Peek());
        }

        [Test]
        public void LinkedListStackPushTest()
        {
            var linkedListStackStack = new LinkedListStack<int>();
            for (var i = 0; i < Elements; i++)
            {
                linkedListStackStack.Push(i * 10);
            }
            Assert.AreEqual(1000000000, linkedListStackStack.Peek());
        }
    }
}
