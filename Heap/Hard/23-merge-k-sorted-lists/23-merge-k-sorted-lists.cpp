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
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

class CompareNode {
public:
    bool operator()(ListNode* node1, ListNode* node2) { // minHeap comparer
        return node1->val >= node2->val;
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
        priority_queue<ListNode*, vector<ListNode*>, CompareNode> minHeap;
        for(auto node : lists) { // add all first nodes to minHeap
            if(node) { // filter out nullptr
                minHeap.push(node);
            }      
        }
        ListNode* head = new ListNode(-1);
        ListNode* cur = head;
        while(minHeap.size() > 0) {
            ListNode* node = minHeap.top();
            minHeap.pop();
            if(node->next) {
                minHeap.push(node->next);
            }
            node->next = nullptr; // disconnect
            cur->next = node;
            cur = node;
        }
        return head->next;
    }
};
