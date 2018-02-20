using DataStructures.Stack;
using NUnit.Framework;

namespace DataStructures.PerformanceTests
{
    [TestFixture]
    public class StackPopTests : TestBase
    {
        private const int Elements = 100000001;
        private ArrayStack<int> _arrayStack;
        private LinkedListStack<int> _linkedListStackStack;

        [SetUp]
        public override void Init()
        {
            _arrayStack = new ArrayStack<int>(100);
            _linkedListStackStack = new LinkedListStack<int>();

            for (var i = 0; i < Elements; i++)
            {
                _arrayStack.Push(i * 10);
                _linkedListStackStack.Push(i * 10);
            }

            base.Init();
        }

        [Test]
        public void ArrayStackPushTest()
        {
            for (var i = 0; i < Elements-1; i++)
            {
                _arrayStack.Pop();
            }

            Assert.AreEqual(0, _arrayStack.Peek());
        }

        [Test]
        public void LinkedListStackPushTest()
        {
            for (var i = 0; i < Elements-1; i++)
            {
                _linkedListStackStack.Pop();
            }

            Assert.AreEqual(0, _linkedListStackStack.Peek());
        }
    }
}
