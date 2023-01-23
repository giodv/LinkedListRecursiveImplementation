using FluentAssertions;
using LeetCode.Exercises.Bloomberg.Easy;

namespace LeetCodeTests.Bloomberg.Easy
{
    public class TreeNodeTests
    {
        [Fact]
        public void Test1()
        {
            var sut = new TreeNode();
            var isSame = sut.IsSameTree(new TreeNode(1), new TreeNode(1));
            isSame.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var sut = new TreeNode();
            var isSame = sut.IsSameTree(new TreeNode(1), new TreeNode(1, new TreeNode(2)));
            isSame.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var sut = new TreeNode();
            var isSame = sut.IsSameTree(new TreeNode(1, new TreeNode(2)), new TreeNode(1, new TreeNode(2)));
            isSame.Should().BeTrue();
        }
    }
}