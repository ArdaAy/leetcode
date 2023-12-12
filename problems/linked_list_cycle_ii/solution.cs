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
    public ListNode DetectCycle(ListNode head) {
        if(head == null)
            return null;
        
        HashSet<ListNode> nList = new HashSet<ListNode>();
        while(head.next != null){
            ListNode tmp = head;
            if(nList.Contains(head))
                return head;
            nList.Add(head);
            head = head.next;
        }
        return null;
    }
}