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
    public TreeNode Move(TreeNode root)
    {
        if(root is null) {
            return null;
        }
        TreeNode node = root.left;
        root.left = Move(root.right);
        root.right = Move(node);
        return root;
    }
    public TreeNode InvertTree(TreeNode root) {
        if(root is null) {
            return null;
        }
        return Move(root);
    }
}
