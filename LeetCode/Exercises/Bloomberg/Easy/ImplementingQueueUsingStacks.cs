namespace LeetCode.Exercises.Bloomberg.Easy
{
    public class ImplementingQueueUsingStacks
    {
        public class MyQueue
        {
            private Stack<int> _myStack;
            private Stack<int> _myPrivateStack;

            public MyQueue()
            {
                _myStack = new Stack<int>();
                _myPrivateStack = new Stack<int>();
            }

            public int[] Push(int x)
            {
                _myStack = new();

                _myPrivateStack.Push(x);

                foreach (var element in _myPrivateStack)
                {
                    _myStack.Push(element);
                }

                return _myStack.ToArray();
            }

            public int Pop()
            {
                //remove first element of the list.
                var removedElement = _myStack.Pop();
                _myPrivateStack = new();
                foreach (var element in _myStack)
                {
                    _myPrivateStack.Push(element);
                }

                return removedElement;
            }

            public int Peek()
            {
                return _myStack.Peek();
            }

            public bool Empty()
            {
                return _myStack.Count == 0;
            }
        }
    }
}