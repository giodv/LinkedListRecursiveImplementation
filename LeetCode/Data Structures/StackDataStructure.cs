using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Data_Structures
{
    public class StackDataStructure
    {
        //PILA: LAST in FIRST out.
        public void CrudOperationStack()
        {
            Stack<int> stack = new();
            for (var i = 0; i < 10; i++)
            {
                stack.Push(i); //COMPLEXITY: O(1)
            }

            /*
             * [0] 9 --> in prima posizione c'è l'ultimo.
             * [9] 0
             */

            foreach (var el in stack)
            {
                //STACK implements IEnumerable
            }

            int[] array2 = new int[stack.Count * 2];
            stack.CopyTo(array2, stack.Count); //copy into array2 stack values starting from the middle.

            for (var i = 0; i < 10; i++)
            {
                stack.Pop(); //COMPLEXITY: O(1)
            }

            //PEEK RETURNS last element added without removing it.
            var isEmpty = !stack.TryPeek(out _); //COMPLEXITY: O(1)

        }
    }
}
