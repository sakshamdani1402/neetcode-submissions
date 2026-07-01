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
    private ListNode Merge(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode();
        ListNode curr = dummy;
        while(l1 != null && l2 != null) {
            if(l1.val < l2.val) {
                curr.next = l1;
                l1 = l1.next;
            }
            else{ 
                curr.next = l2;
                l2 = l2.next;
            }
            curr = curr.next;
        }
        curr.next = l1 == null ? l2 : l1;
        return dummy.next;
    }
    public ListNode MergeKLists(ListNode[] lists) {
        int n = lists.Length;
        if(n <= 0) return null;
        if(n == 1) return lists[0];
        ListNode sentinel = lists[0];
        for(int i = 1; i < n; i++) {
            sentinel = Merge(sentinel, lists[i]);
        }
        return sentinel;
    }
}
