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
    public string Tree2str(TreeNode root) {
        var str = "";
        if(root != null){
            str += root.val;
            if(root.left != null)
                str += "(" + Tree2str(root.left) + ")";
            else if(root.right != null)
                str += "()";
            
            if(root.right != null)
                str += "(" + Tree2str(root.right) + ")";
        }
        return str;
    }


}