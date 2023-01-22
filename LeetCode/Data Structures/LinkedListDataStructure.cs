namespace LeetCode.Data_Structures
{
    /// <summary>
    /// Linked list has the reference to the next element. 
    /// </summary>
    public class LinkedListDataStructure
    {
        public class LinkedList
        {
            public int Element;
            public LinkedList? Next;

            public LinkedList(int element)
            {
                this.Element = element;
            }

            private LinkedList(int element, LinkedList? next)
            {
                this.Element = element;
                this.Next = next;
            }

            public void AddFirst(int element)
            {
                AddFirst(element, this);
            }

            public void AddFirst(int element, LinkedList list)
            {
                list.Next = new LinkedList(list.Element, list.Next);
                list.Element = element;
            }

            public LinkedList? AddLast(int element)
            {
                return AddLast(element, this);
            }

            private LinkedList? AddLast(int element, LinkedList? list)
            {
                if (list.Next == null)
                {
                    var listElement = new LinkedList(element);
                    list.Next = listElement;
                    return list;
                }

                return new LinkedList(this.Element, AddLast(element, list.Next));
            }

            public LinkedList RemoveFirst()
            {
                var head = this?.Next;
                this.Next = head?.Next;
                return head;
            }

            public void RemoveLast()
            {
                RemoveLast(this);
            }

            private LinkedList? RemoveLast(LinkedList? list)
            {
                if (list.Next != null && list.Next.Next == null)
                {
                    list.Next = null;
                    return list;
                }

                return new LinkedList(this.Element, RemoveLast(list.Next!));
            }

            /// <summary>
            /// Adds one element in the specified index.
            /// </summary>
            /// <param name="element"></param>
            /// <param name="index"></param>
            public void AddAt(int element, int index)
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "index can't be negative.");
                }

                AddAt(element, index, this);
            }

            private void AddAt(int element, int index, LinkedList? list, bool added = false)
            {
                if (list == null && index > 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (index == 1 && list.Next == null)
                {
                    AddLast(element);
                    added = true;
                }

                if (index == 0)
                {
                    AddFirst(element, list);
                    added = true;
                }

                if (index > 0 && !added)
                {
                    AddAt(element, --index, list.Next, added);
                }
            }

            public LinkedList RemoveAt(int index)
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "index can't be negative.");
                }

                return RemoveAt(index, this);
            }

            public LinkedList RemoveAt(int index, LinkedList? list)
            {
                if (index == 0)
                {
                    return RemoveFirst();
                }

                if (list == null && index > 0)
                {
                    throw new IndexOutOfRangeException();
                }

                list.Next = RemoveAt(--index, list.Next);
                return list;
            }

            public LinkedList? Merge(LinkedList? list1, LinkedList? list2)
            {
                if (list1 == null)
                    return list2;

                if (list2 == null)
                    return list1;

                if (list1.Element <= list2.Element &&
                    (list1.Next == null || (list1.Next != null && list1.Next.Element >= list2.Element)))
                {
                    return new LinkedList(list1.Element,
                        new LinkedList(list2.Element, Merge(list1?.Next, list2?.Next)));
                }
                else if (list1.Element <= list2.Element &&
                         ((list1.Next == null || (list1.Next != null && list1.Next.Element < list2.Element))))
                {
                    return new LinkedList(list1.Element, Merge(list1?.Next, list2));
                }

                if (list2.Element <= list1.Element &&
                    (list2.Next == null || (list2.Next != null && list2.Next.Element >= list1.Element)))
                {
                    return new LinkedList(list2.Element,
                        new LinkedList(list1.Element, Merge(list1?.Next, list2?.Next)));
                }
                else
                {
                    return new LinkedList(list2.Element, Merge(list1, list2?.Next));
                }
            }

            public LinkedList Reverse()
            {
                if (this.Next != null)
                {
                    var length = GetLength();
                    return Reverse(length, this);
                }

                return this;
            }

            private LinkedList Reverse(int length, LinkedList? linkedList)
            {
                if (length > 0 && linkedList != null)
                {
                    var head = linkedList.Element;
                    linkedList.AddAt(head, length);
                    linkedList = linkedList.RemoveFirst();
                    return Reverse(length - 1, linkedList);
                }

                return linkedList;
            }

            public int GetLength()
            {
                if (this.Next == null)
                {
                    return 1;
                }

                return GetLength(1, this);
            }

            private int GetLength(int counter, LinkedList list)
            {
                if (list.Next == null)
                {
                    return counter;
                }

                return GetLength(counter + 1, list.Next);
            }

            public static LinkedList? AddTwoNumbers(LinkedList l1, LinkedList l2)
            {
                return AddTwoNumbers(l1, l2, 0);
            }

            private static LinkedList? AddTwoNumbers(
                LinkedList? l1,
                LinkedList? l2,
                int carry = 0)
            {
                // ENDS ONLY WHEN CARRY = 0 and l1 == null and l2 == null
                if (carry != 0 && l1 == null && l2 == null)
                {
                    return new LinkedList(carry);
                }

                var sum = (l1?.Element ?? 0) + (l2?.Element ?? 0) + carry;
                var lastDigit = int.Parse(sum.ToString()[^1].ToString());
                var newCarry = sum >= 10 ? int.Parse(sum.ToString()[0..2].ToString()) : 0;

                if (l1 == null && l2 != null)
                {
                    l2.Element = lastDigit;
                    return new LinkedList(l2.Element, AddTwoNumbers(l1, l2.Next, newCarry));
                }

                if (l2 == null && l1 != null)
                {
                    l1.Element = lastDigit;
                    return new LinkedList(l2.Element, AddTwoNumbers(l1.Next, l2, newCarry));
                }

                if (carry != 0 && l1 == null && l2 == null)
                {
                    return new LinkedList(newCarry);
                }

                return new LinkedList(lastDigit,
                    AddTwoNumbers(l1?.Next, l2?.Next, carry));
            }
        }
    }
}