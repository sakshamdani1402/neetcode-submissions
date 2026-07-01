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
    private int count = 0;
    private void dfs(TreeNode root, int max) {
        if(root == null) {
            return;
        }
        if(root.val >= max) {
            count ++;
        }
        int maxForNext = root.val > max ? root.val : max;
        dfs(root.left, maxForNext);
        dfs(root.right, maxForNext);
    }
    public int goodNodes(TreeNode root) {
        if(root == null) {
            return 0;
        }
        count ++;
        dfs(root.left, root.val);
        dfs(root.right, root.val);
        return count;
    }
}
