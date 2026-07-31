/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsValidBST(TreeNode root) {
        if(root == null) {
            return true;
        }
        return check(root, int.MinValue, int.MaxValue);
    }

    private bool check(TreeNode root, int lbound, int rbound)
    {
        if(root == null) {
            return true;
        }

        if(root.val <= lbound || root.val >= rbound) {
            return false;
        }

        return check(root.left, lbound, root.val) && check(root.right, root.val, rbound);
    }
}
