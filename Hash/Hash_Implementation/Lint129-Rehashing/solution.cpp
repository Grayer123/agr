/**
 * Definition of ListNode
 * class ListNode {
 * public:
 *     int val;
 *     ListNode *next;
 *     ListNode(int val) {
 *         this->val = val;
 *         this->next = NULL;
 *     }
 * }
 */
class Solution {
public:
    /**
     * @param hashSet: A list of The first node of linked list
     * @return: A list of The first node of linked list which have twice size
     */    
    vector<ListNode*> rehashing(vector<ListNode*> hashSet) {
        // rehashing
        // tc:O(n); sc:O(1)
        if(hashSet.size() == 0) {
            return {};
        }
        int oldSize = hashSet.size();
        int newSize = oldSize * 2;
        vector<ListNode*> newHashSet = vector<ListNode*>(newSize, nullptr);
        for(auto node : hashSet) {
            while(node) {
                int index = ((node->val % newSize) + newSize) % newSize;  // node->val could be negative number
                ListNode* newNode = new ListNode(node->val);
                if(!newHashSet[index]) {
                    newHashSet[index] = newNode;
                }
                else{
                    ListNode* cur = newHashSet[index];
                    while(cur->next) {
                        cur = cur->next;
                    }
                    cur->next = newNode;
                }
                node = node->next;
            }
        }
        return newHashSet;
    }
};
