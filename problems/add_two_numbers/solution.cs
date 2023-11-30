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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int total = 0;
        ListNode node = new ListNode();
        ListNode nodeTmp = node;
        bool isFirst = true;

        while (l1 != null || l2 != null)
        {
            if (l1 != null)
            {
                total += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                total += l2.val;
                l2 = l2.next;
            }
            
            
            if (isFirst)
            {
                nodeTmp.val = Convert.ToInt32(total % 10);
                isFirst = false;
            }
            else
            {
                ListNode altNode = new ListNode();
                altNode.val = Convert.ToInt32(total % 10);
                nodeTmp.next = altNode;
                nodeTmp = altNode;
            }
            total = total / 10;
            

        }
        while(total > 0)
        {
            ListNode altNode = new ListNode();
            altNode.val = Convert.ToInt32(total % 10);
            nodeTmp.next = altNode;
            nodeTmp = altNode;
            total = total / 10;
        }
        
        return node;
    }
}