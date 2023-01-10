using LeetCode.Exercises.Easy;
using LeetCode.Exercises.Random;

namespace LeetCodeTests
{
    public class MergeTwoListsTests
    {
        private OrderedListNode _sut;

        public MergeTwoListsTests()
        {
            _sut = new OrderedListNode();
        }

        [Fact]
        public void Test1()
        {
            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            var result = _sut.MergeTwoLists(list1, list2);
        }
    }
}