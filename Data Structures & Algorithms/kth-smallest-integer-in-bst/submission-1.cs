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
    int res = int.MaxValue;
    int cnt = 0;
    int kth = 1;
    private void dfs(TreeNode root)
    {
        if(root == null) {
            return;
        }
        dfs(root.left);
        cnt++;
        if(cnt == kth && res == int.MaxValue) {
            res = root.val;
            return;
        }
        dfs(root.right);
    }
    public int KthSmallest(TreeNode root, int k) {
        kth = k;
        dfs(root);
        return res;
    }
}
