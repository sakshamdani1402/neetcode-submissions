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
    int Find(TreeNode root, ref int dia)
    {
        if(root is null)
        {
            return 0;
        }
        int left = Find(root.left, ref dia);
        int right =  Find(root.right,ref dia);
        dia = Math.Max(dia, left + right);
        return 1 + Math.Max(left, right);
    }
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root is null) {
            return 0;
        }
        int diameter = 0;
        Find(root, ref diameter);
        return diameter;
    }
}
