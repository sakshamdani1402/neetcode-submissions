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
    int cnt = 0;
    int res = Integer.MAX_VALUE;
    private void  inorder(TreeNode root, int k) {
        if(root == null) {
            return;
        }
        inorder(root.left, k);
        cnt++;
        if(cnt == k && res == Integer.MAX_VALUE) {
            res = root.val;
            return;
        }
        inorder(root.right, k);
    }
    public int kthSmallest(TreeNode root, int k) {
        inorder(root, k);
        return res;
    }
}
