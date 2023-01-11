using FluentAssertions;
using static LeetCode.Data_Structures.LinkedListDataStructure;

namespace LeetCodeTests.DataStructures
{
    public class LinkedListTester
    {
        [Fact]
        public void Test1()
        {
            var sut = new LinkedList(1);
            sut.AddFirst(0);
            sut.Next!.Element.Should().Be(1);
            sut.Element.Should().Be(0);
        }

        [Fact]
        public void Test2()
        {
            var sut = new LinkedList(1);
            var list = sut.RemoveFirst();
            list.Should().Be(null);
        }

        [Fact]
        public void Test3()
        {
            var sut = new LinkedList(1);
            sut.AddLast(2);
            sut.Next!.Element.Should().Be(2);
            sut.AddLast(3);
            sut.Next!.Next!.Element.Should().Be(3);
        }

        [Fact]
        public void Test4()
        {
            var sut = new LinkedList(1);
            sut.AddLast(2);
            sut.AddLast(3);
            sut.RemoveLast();
            sut.Next!.Next.Should().Be(null);
        }

        [Fact]
        public void Test5()
        {
            var sut = new LinkedList(1);
            sut.AddLast(2);
            sut.AddLast(3);
            sut.AddAt(-1, 0);
            sut.Next!.Element.Should().Be(1);
            sut.Element.Should().Be(-1, "-1, 1, 2, 3");
        }

        [Fact]
        public void Test6()
        {
            var sut = new LinkedList(1);
            sut.AddLast(2);
            sut.AddLast(3);
            sut.AddAt(-1, 1);
            sut.Next!.Element.Should().Be(-1);
            sut.Element.Should().Be(1, "1, -1, 2, 3");
        }

        [Fact]
        public void Test7()
        {
            var sut = new LinkedList(1);
            var list = sut.AddLast(2);
            list.AddLast(3);
            var listRemoved = list.RemoveAt(0);
            listRemoved.Element.Should().Be(2, "2, 3");
            listRemoved.Next!.Element.Should().Be(3, "2, 3");
            listRemoved.Next.Next.Should().Be(null);
        }

        [Fact]
        public void Test8()
        {
            var sut = new LinkedList(1);
            sut.AddLast(3);
            sut.AddLast(5);
            sut.AddLast(7);

            var sut1 = new LinkedList(2);
            sut1.AddLast(4);
            sut1.AddLast(6);
            sut1.AddLast(8);

            var mergedList = sut.Merge(sut, sut1);
            mergedList.Element.Should().Be(1);
        }

        [Fact]
        public void Test9()
        {
            var sut = new LinkedList(1);
            sut.AddLast(2);

            var sut1 = new LinkedList(5);

            var mergedList = sut.Merge(sut, sut1);
            mergedList.Next!.Next!.Element.Should().Be(5);
        }

        [Fact]
        public void Test10()
        {
            var sut = new LinkedList(5);

            var sut1 = new LinkedList(1);
            sut1.AddLast(2);

            var mergedList = sut.Merge(sut, sut1);
            mergedList.Next!.Next!.Element.Should().Be(5);
        }

        [Fact]
        public void Test11()
        {

            var sut1 = new LinkedList(1);
            sut1.AddLast(2);
            sut1.AddLast(3);

            var length = sut1.GetLength();
            length.Should().Be(3);
        }

        [Fact]
        public void Test12()
        {

            var sut1 = new LinkedList(1);
            sut1.AddLast(2);
            sut1.AddLast(3);
            var reversed = sut1.Reverse();
            reversed.Element.Should().Be(3);
            reversed.Next!.Element.Should().Be(2);
            reversed.Next!.Next!.Element.Should().Be(1);
        }
    }
}