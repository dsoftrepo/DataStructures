using System;

namespace DataStructures.Queue
{
    public class ArrayQueue<T>
    {
        private readonly T[] _array;
        private int _front;
        private int _rear;
        private readonly int _max;
        private int _count;
        private bool _empty
        {
            get { return _count == 0; }
        }

        public ArrayQueue(int size)
        {
            _array = new T[size];
            _front = 0;
            _rear = -1;
            _max = size;
            _count = 0;
        }

        public void Enqueue(T item)
        {
            if (_count == _max)
            {
                throw new InvalidOperationException("Queue overflow");
            }
            
            _rear = (_rear + 1) % _max;
            _array[_rear] = item;
            _count++;
        }

        public bool TryDequeue(out T value)
        {
            if (_empty)
            {
                value = default(T);
                return false;
            }

            value = InnerDequeue();
            return true;
        }

        public T Dequeue()
        {
            if (_empty)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return InnerDequeue();
        }
        public T Peek()
        {
            if (_empty) throw new InvalidOperationException("Queue is empty");
            return _array[_front];
        }

        private T InnerDequeue()
        {
            var result = _array[_front];
            _front = (_front + 1) % _max;
            _count--;
            return result;
        }
    }
}
