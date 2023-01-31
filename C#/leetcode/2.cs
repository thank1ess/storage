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
        ListNode list = new ListNode(),
        copy = list;
        byte extra = 0;
        
        do {
            int val1 = l1 != null ? l1.val : 0,
            val2 = l2 != null ? l2.val : 0;
            byte res = (byte) (val1 + val2 + extra);
            extra = (byte) (res / 10);
            
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
            
            copy.next = new ListNode(res % 10);
            copy = copy.next;
        } while(l1 != null || l2 != null);
        
        if (extra > 0) {
            copy.next = new ListNode(extra);
        }
        return list.next;
    }
}