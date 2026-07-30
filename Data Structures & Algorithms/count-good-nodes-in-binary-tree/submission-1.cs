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
    int count = 0;
    public int GoodNodes(TreeNode root) {
        if(root is null) {
            return 0;
        }
        count = 1;
        dfs(root.left, root.val);
        dfs(root.right, root.val);
        return count;
    }

    private void dfs(TreeNode root, int maxVal)
    {
        if(root is null) {
            return;
        }
        if(root.val >= maxVal) {
            count++;
        }
        int maxForNext = Math.Max(maxVal, root.val);
       dfs(root.left, maxForNext);
       dfs(root.right, maxForNext);
    }
}
