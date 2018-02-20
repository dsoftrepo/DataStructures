using System;

namespace DataStructures.Stack
{
    public class ArrayStack<T>
    {
        private T[] _stack;
        private int _peakItemIndex;

        public ArrayStack(int size)
        {
            _peakItemIndex = -1;
            _stack = new T[size];
        }

        public void Push(T item)
        {
            if (_peakItemIndex<0)
            {
                _stack[0] = item;
                _peakItemIndex = 0;
            }
            else
            {
                if (_stack.Length <= _peakItemIndex + 1)
                {
                    Array.Resize(ref _stack, _stack.Length * 2);
                }
                _stack[++_peakItemIndex] = item;
            }
        }

        public T Pop()
        {
            if (_peakItemIndex <= -1) throw new InvalidOperationException("Stack is empty");
            return InnerPop();
        }

        public T Peek()
        {
            if (_peakItemIndex <= -1) throw new InvalidOperationException("Stack is empty");
            return _stack[_peakItemIndex];
        }
        
        public bool TryPop(out T value)
        {
            if (_peakItemIndex <= -1)
            {
                value = default(T);
                return false;
            }

            value = InnerPop();
            return true;
        }

        private T InnerPop()
        {
            var popValue = _stack[_peakItemIndex--];
            _stack[_peakItemIndex] = default(T);
            return popValue;
        }
    }
}
