using System;

namespace DataStructures.Stack
{
    public class LinkedListStack<T>
    {
        private int _count;
        private bool _empty {
            get { return _count == 0; }
        }
        private Node _peak;

        public LinkedListStack()
        {
            _count = 0;
        }

        public void Push(T item)
        {
            _peak = _empty ? new Node(item) : new Node(item, _peak);
            _count++;
        }

        public T Pop()
        {
            if (_empty) throw new InvalidOperationException("Stack is empty");
            return InnerPop();
        }

        public T Peek()
        {
            if (_empty) throw new InvalidOperationException("Stack is empty");
            return _peak.Value;
        }

        public bool TryPop(out T value)
        {
            if (_empty)
            {
                value = default(T);
                return false;
            }
            value = InnerPop();
            return true;
        }

        private T InnerPop()
        {
            var popedItem = _peak.Value;
            _peak = _peak.OneBelow;
            _count--;
            return popedItem;
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
