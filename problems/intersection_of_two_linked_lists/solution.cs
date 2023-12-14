/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if(headA == headB)
            return headA;
        else if(headA == null || headB == null)
            return null;
        
        HashSet<ListNode> nList = new HashSet<ListNode>();
        
        nList.Add(headA);
        nList.Add(headB);
        
        while(headA.next != null || headB.next != null ){
            
            if(headA.next != null){
                
                if(nList.Contains(headA.next))
                    return headA.next;
                nList.Add(headA.next);
                headA = headA.next;

            }
            if(headB.next != null){
                
                if(nList.Contains(headB.next))
                    return headB.next;
                nList.Add(headB.next);
                headB = headB.next;
            }
        }
        return null;
        
    }
}