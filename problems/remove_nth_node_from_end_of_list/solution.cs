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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null)
            return null;

        ListNode start = head;
        int lCnt = 1;
        while(start.next != null){
            lCnt++;
            start = start.next;
        }
        if(lCnt - (n - 1) <= 0)
            return null;
        
        start = head;
        int cnt = 1;
        ListNode prev = null;
        
        while(true){
            if(cnt == lCnt - (n - 1)){
                break;
            }
            else if(head.next == null)
                return null;
            prev = head;
            head = head.next;
            cnt++;
        }

        if(prev != null && prev.next != null){
            prev.next = prev.next.next;
            return start;
        }
        else if(prev == null && lCnt > 1)
            return start.next;

        return null;
    }
}