/*
 * @lc app=leetcode id=23 lang=csharp
 *
 * [23] Merge k Sorted Lists
 *
 * https://leetcode.com/problems/merge-k-sorted-lists/description/
 *
 * algorithms
 * Hard (33.82%)
 * Total Accepted:    370K
 * Total Submissions: 1.1M
 * Testcase Example:  '[[1,4,5],[1,3,4],[2,6]]'
 *
 * Merge k sorted linked lists and return it as one sorted list. Analyze and
 * describe its complexity.
 * 
 * Example:
 * 
 * 
 * Input:
 * [
 * 1->4->5,
 * 1->3->4,
 * 2->6
 * ]
 * Output: 1->1->2->3->4->4->5->6
 * 
 * 
 */


/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */

// method 1 to define the comparer
class CompareNode { //construct the compare class that priority queue needs
public:
    bool operator()(ListNode* l1, ListNode* l2) { // minHeap comparer
        return l1->val >= l2->val;
    }
};

class Solution {
public:
    ListNode* mergeKLists(vector<ListNode*>& lists) {
        // minHeap
        // tc:O(nlogk); sc:O(n)
        if(lists.size() == 0) { // corner case
            return nullptr;
        }
        // method 2 to define the comparer
        auto comp = [](ListNode* l1, ListNode* l2) -> bool {
            return l1->val >= l2->val;
        };
        // priority_queue<ListNode*, vector<ListNode*>, CompareNode> minHeap;  // method 1
        priority_queue<ListNode*, vector<ListNode*>, decltype(comp)> minHeap(comp); // method 2
        ListNode* dummy = new ListNode(-1);
        ListNode* cur = dummy;
        for(auto node : lists) { // initialize: add all first nodes to minHeap
            if(node) { // filter out nullptr
                minHeap.push(node);
            }    
        }
        while(minHeap.size() > 0) {
            ListNode* node = minHeap.top();
            minHeap.pop();
            if(node->next) {
                minHeap.push(node->next);
            }
            node->next = nullptr; // disconnect
            cur->next = node;
            cur = cur->next;
        }
        return dummy->next;
    }
};