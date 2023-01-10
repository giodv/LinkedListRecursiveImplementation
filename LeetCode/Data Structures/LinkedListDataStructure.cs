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

            private LinkedList(int element, LinkedList next)
            {
                this.Element = element;
                this.Next = next;
            }

            public void AddFirst(int element)
            {
                this.Next = new LinkedList(this.Element, this);
                this.Element = element;
            }

            public LinkedList AddLast(int element)
            {
                return AddLast(element, this);
            }

            private LinkedList AddLast(int element, LinkedList list)
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

            private LinkedList RemoveLast(LinkedList list)
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

            private LinkedList AddAt(int element, int index, LinkedList? list)
            {
                if (list == null && index > 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (index == 0)
                {
                    AddFirst(element);
                }

                list.Next = AddAt(element, --index, list.Next);
                return list;
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

            public LinkedList Merge(LinkedList? list1, LinkedList? list2)
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
        }
    }
}