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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> iList = new List<int>();
        if(root != null){
            if(root.left != null)
                iList = iList.Concat(InorderTraversal(root.left)).ToList();
        
            iList.Add(root.val);
        
            if(root.right != null)
                iList = iList.Concat(InorderTraversal(root.right)).ToList();
        }
        return iList;
    }
}