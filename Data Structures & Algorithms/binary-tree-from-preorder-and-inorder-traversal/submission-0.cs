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
    Dictionary<int, int> hash = new();
    int index = 0;
    private TreeNode Build(int[] preorder, int left, int right) {
        if(left > right) {
            return null;
        }
        int rootVal = preorder[index];
        TreeNode root = new(rootVal);
        index++;
        int inorderIndex = hash.GetValueOrDefault(rootVal);
        root.left = Build(preorder, left, inorderIndex - 1);
        root.right = Build(preorder, inorderIndex + 1, right);
        return root;
    }

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for(int i = 0; i < inorder.Length; i++) {
            hash.Add(inorder[i], i);
        }
        return Build(preorder, 0, inorder.Length - 1);
    }
}
