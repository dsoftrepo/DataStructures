using System;

namespace DataStructures.Stack
{
    public class LinkedListStack<T>
    {
        private int _count;
        private bool Empty => _count == 0;
        private Node _peak;

        public LinkedListStack()
        {
            _count = 0;
        }

        public void Push(T item)
        {
            _peak = Empty ? new Node(item) : new Node(item, _peak);
            _count++;
        }

        public T Pop()
        {
            if (Empty) throw new InvalidOperationException("Stack is empty");
            return InnerPop();
        }

        public T Peek()
        {
            if (Empty) throw new InvalidOperationException("Stack is empty");
            return _peak.Value;
        }

        public bool TryPop(out T value)
        {
            if (Empty)
            {
                value = default(T);
                return false;
            }
            value = InnerPop();
            return true;
        }

        private T InnerPop()
        {
            T topItem = _peak.Value;
            _peak = _peak.OneBelow;
            _count--;
            return topItem;
        }

        private class Node
        {
            public T Value { get; }
            public Node OneBelow { get;}

            public Node(T value)
            {
                Value = value;
                OneBelow = null;
            }

            public Node(T value, Node peak)
            {
                Value = value;
                OneBelow = peak;
            }
        }
    }
}
