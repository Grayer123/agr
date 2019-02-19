/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    bool isPalindrome(ListNode* head) {
        //TC:O(n); SC:O(1)
        if(!head){
            return true;
        }
        ListNode* mid = findMiddle(head);
        ListNode* tmp = mid->next;
        mid->next = nullptr; //disconnect
        ListNode* newHead = reverseList(tmp);
        while(newHead){
            if(newHead->val != head->val){
                return false;
            }
            newHead = newHead->next;
            head = head->next;
        }
        return true;
    }
private:
    ListNode* findMiddle(ListNode* head){
        if(!head){
            return nullptr;
        }
        ListNode* slow = head;
        ListNode* fast = head->next;
        while(fast && fast->next){
            slow = slow->next;
            fast = fast->next->next;
        }
        return slow;
    }
    
    ListNode* reverseList(ListNode* head){
        if(!head){
            return nullptr;
        }
        ListNode* prev = nullptr;
        while(head){
            ListNode* tmp = head->next;
            head->next = prev;
            prev = head;
            head = tmp;
        }
        return prev;
    }
};