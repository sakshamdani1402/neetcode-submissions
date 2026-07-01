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
    private boolean areSame = true;
    private void dfs(TreeNode p, TreeNode q) {
        if(p == null && q == null) {
            return;
        }
        boolean isNodeNull = p != null && q == null || p == null && q != null;
        if(isNodeNull) {
            areSame = false;
            return;
        }
        boolean areValuesDiff = p.val != q.val;
        if(areValuesDiff) {
            areSame = false;
            return;
        }
        dfs(p.left, q.left);
        dfs(p.right, q.right);
    }
    public boolean isSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null) {
            return true;
        }
        dfs(p,q);
        return areSame;
    }
}
