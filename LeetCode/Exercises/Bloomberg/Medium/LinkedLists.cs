using LeetCode.Exercises.Random;

namespace LeetCode.Exercises.Bloomberg.Medium;

public class LinkedLists
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2, int carry = 0)
    {
        if (l1 == null && l2 != null)
        {
            var value = l2.val + carry;
            (carry, value) = GetValueAndCarry(value);
            return new ListNode(value, AddTwoNumbers(l1, l2.next, carry));
        }

        if (l1 != null && l2 == null)
        {
            var value = l1.val + carry;
            (carry, value) = GetValueAndCarry(value);
            return new ListNode(value, AddTwoNumbers(l1.next, l2, carry));
        }

        if (l1 != null && l2 != null)
        {
            var value = l1.val + l2.val + carry;
            (carry, value) = GetValueAndCarry(value);
            return new ListNode(value, AddTwoNumbers(l1.next, l2.next, carry));
        }

        if (carry != 0)
        {
            return new ListNode(carry);
        }


        return null;

        (int carry, int value) GetValueAndCarry(int value)
        {
            if (value > 9)
            {
                //has carry!
                value = int.Parse(value.ToString().Last().ToString());
                carry = 1;
            }
            else
            {
                carry = 0;
            }
            return (carry, value);
        }
    }


}