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
    ListNode* oddEvenList(ListNode* head) {
        //dummy node
        //TC:O(n); SC:O(1)
        if(!head){
            return nullptr;
        }
        ListNode dummy_odd(-1);
        ListNode* curOdd = &dummy_odd;
        ListNode dummy_even(-1);
        ListNode* curEven = &dummy_even;
        int cnt = 0;
        while(head){
            ++cnt;
            if(cnt & 0x01){
                curOdd->next = head;
                curOdd = head;
            }
            else{
                curEven->next = head;
                curEven = head;
            }
            head = head->next;
        }
        curEven->next = nullptr; //disconnect to avoid loop
        curOdd->next = dummy_even.next;
        return dummy_odd.next;
    }
};