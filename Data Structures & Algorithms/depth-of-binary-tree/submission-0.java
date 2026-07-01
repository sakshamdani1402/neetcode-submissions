/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

class Solution {
    public int depth = 0;
    public int find(TreeNode root, int depth){
        if(root == null) {
            return 0;
        }
        int leftDepth = Math.max(depth, find(root.left, depth + 1));
        int rightDepth = Math.max(depth, find(root.right, depth + 1));
        return Math.max(leftDepth, rightDepth);
    }
    public int maxDepth(TreeNode root) {
       if(root == null) {
            return 0;
       }
 
       return       find(root, 1);
    }
}
