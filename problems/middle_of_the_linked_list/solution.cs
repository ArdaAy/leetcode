/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        
        int cnt = 0;
        ListNode tmp = head;
        while(tmp != null){
            cnt++;
            tmp = tmp.next;
        }
        int mid = cnt / 2;
        
        tmp = head;
        for(var i = 0; i < mid; i++)
            tmp = tmp.next;
        return tmp;
    }
}