using System;

namespace DataStructures.Queue
{
    public class LinkedListQueue<T>
    {
        private Node _front;
        private Node _rear;

        public LinkedListQueue()
        {
            _front = null;
            _rear = null;
        }

        public void Enqueue(T item)
        {
            if (_rear == null)
            {
                _rear = new Node(item);
                _front = _rear;
            }
            else
            {
                _rear.Next = new Node(item);
                _rear = _rear.Next;
            }
        }

        public T Dequeue()
        {
            if (_front == null) throw new InvalidOperationException("Queue is empty");
            return InnerDequeue();
        }

        public T Peek()
        {
            if (_front == null) throw new InvalidOperationException("Queue is empty");
            return _front.Value;
        }

        public bool TryDequeue(out T value)
        {
            if (_front == null)
            {
                value = default(T);
                return false;
            }
            value = InnerDequeue();
            return true;
        }

        private T InnerDequeue()
        {
            var result = _front.Value;
            _front = _front.Next;
            return result;
        }

        private class Node
        {
            public T Value { get; }
            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }
    }
}
