namespace LeetCode.Exercises.Bloomberg.Easy
{
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p?.val != q?.val) return false;
            if (p?.val == q?.val && p?.left == null && p?.right == null && q?.left == null && q?.right == null) return true;
            return IsSameTree(p?.left, q?.left) && IsSameTree(p?.right, q?.right);
        }
    }
}
