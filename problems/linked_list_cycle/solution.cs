/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        
        if(head == null)
            return false;
        
        //List<ListNode> nList = new List<ListNode>();
        HashSet<ListNode> nList = new HashSet<ListNode>();
        while(head.next != null){
            ListNode tmp = head;
            if(nList.Contains(head))
                return true;
            nList.Add(head);
            head = head.next;
        }
        return false;
    }
}