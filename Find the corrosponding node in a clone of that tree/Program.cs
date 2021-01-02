using System;

namespace Find_a_Corresponding_Node_of_a_Binary_Tree_in_a_Clone_of_That_Tree
{
    class Program
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        static void Main(string[] args)
        {
            TreeNode original = new TreeNode(7);
            original.left = new TreeNode(4);
            original.right = new TreeNode(3);
            original.right.left = new TreeNode(6);
            original.right.right = new TreeNode(19);

            TreeNode cloned = new TreeNode(7);
            cloned.left = new TreeNode(4);
            cloned.right = new TreeNode(3);
            cloned.right.left = new TreeNode(6);
            cloned.right.right = new TreeNode(19);

            var target = new TreeNode(3);
            Console.WriteLine(GetTargetCopy(original, cloned, target)?.val);
        }

        static TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if (original == null || cloned == null) return null;

            if (original.val == target.val) return cloned;

            var left = GetTargetCopy(original.left, cloned.left, target);
            if (left != null) return left;

            return GetTargetCopy(original.right, cloned.right, target);
        }
    }
}
