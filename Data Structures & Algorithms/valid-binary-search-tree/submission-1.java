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
    private boolean isValid = true;
    private boolean dfs(TreeNode root, int leftBound, int rightBound){
        if(root == null) {
            return true;
        }
       if(root.val <= leftBound || root.val >= rightBound) return false;
       return dfs(root.left, leftBound, root.val) && dfs(root.right, root.val, rightBound);
    }

    public boolean isValidBST(TreeNode root) {
        if(root == null) {
            return true;
        }
        return dfs(root, Integer.MIN_VALUE, Integer.MAX_VALUE);
    }
}
