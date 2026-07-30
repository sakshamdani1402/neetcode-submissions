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
    bool isBalanced = true;
    int calc(TreeNode root) {
        if(root is null) {
            return 0;
        }
        int left = calc(root.left);
        int right = calc(root.right);

        if(Math.Abs(right - left) > 1) {
            isBalanced = false;
            return 0;
        }
        return 1 + Math.Max(left, right);
    }
    public bool IsBalanced(TreeNode root) {
        if(root is null) {
            return true;
        }
        calc(root);
        return isBalanced;
    }
}
