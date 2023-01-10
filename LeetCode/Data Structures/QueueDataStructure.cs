namespace LeetCode.Data_Structures
{
    public class QueueDataStructure
    {
        public void CrudOperations()
        {
            //FIFO : first in first out
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            //[0] --> 0
            //[1] --> 1
            //[2] --> 2
            foreach (int i in queue)
            {
            }

            for (int i = 0; i < 10; i++)
            {
                _ = queue.Dequeue();
                //--> al primo giro [0] --> 1
                //                  [1] --> 2
            }

            var isEmpty = !queue.TryPeek(out _);
        }
    }
}