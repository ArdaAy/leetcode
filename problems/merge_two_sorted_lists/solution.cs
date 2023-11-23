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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null && list2 == null)
            return null;
        List<int> iList = new List<int>();

        while (list1 != null)
        {
            iList.Add(list1.val);
            list1 = list1.next;
        }

        while (list2 != null)
        {
            iList.Add(list2.val);
            list2 = list2.next;
        }

        iList.Sort();
        ListNode node = new ListNode(iList[0], null);
        ListNode sendNode = node;

        for (var i = 1; i < iList.Count; i++)
        {
            ListNode tmpNode = new ListNode(iList[i], null);
            node.next = tmpNode;
            node = tmpNode;
        }

        return sendNode;
    }
}