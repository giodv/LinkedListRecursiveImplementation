namespace LeetCode.Exercises.Bloomberg.Easy
{
    public class MyStack
    {
        private Queue<int> myQueue;
        private Queue<int> myQueueFirst;

        public MyStack()
        {
            myQueueFirst = new Queue<int>();
        }

        public void Push(int x)
        {
            myQueue = new Queue<int>();
            
            //LIFO --> pushes elemenent to the top of the stack.
            this.myQueueFirst.Enqueue(x);
            var arr = this.myQueueFirst.ToArray();
            for (int i = myQueueFirst.Count - 1; i >= 0; i--)
            {
                myQueue.Enqueue(arr[i]);
            }
        }

        public int Pop()
        {
            myQueueFirst = new();
            //remove first element.
            var element = this.myQueue.Dequeue();
            
            var arr = this.myQueue.ToArray();
            for (int i = myQueue.Count - 1; i >= 0; i--)
            {
                myQueueFirst.Enqueue(arr[i]);
            }

            return element;
        }

        public int Top()
        {
            return this.myQueue.Peek();
        }

        public bool Empty()
        {
            return this.myQueueFirst.Count == 0;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}