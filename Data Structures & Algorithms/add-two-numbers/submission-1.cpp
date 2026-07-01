/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */

class Solution {
    int getNum(ListNode* head) {
        if(head == NULL) return 0;
        return head->val;
    }
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        int carry  = 0; 
        ListNode *dummy = new ListNode();
        ListNode *curr = dummy;
        while(l1 || l2 || carry > 0) {
            int val1 = getNum(l1);
            int val2 = getNum(l2);
            int sum  = val1 + val2 + carry;
            curr -> next = new ListNode(sum%10);
            carry = sum/10;
            if(l1) l1 = l1 -> next;
            if(l2) l2 = l2 -> next;
            curr = curr -> next;
        }
        return dummy -> next;
    }
};
