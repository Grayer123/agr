/**
 * Definition of TreeNode:
 * class TreeNode {
 * public:
 *     int val;
 *     TreeNode *left, *right;
 *     TreeNode(int val) {
 *         this->val = val;
 *         this->left = this->right = NULL;
 *     }
 * }
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    /**
     * @param root the root of binary tree
     * @return a lists of linked list
     */
    vector<ListNode*> binaryTreeToLists(TreeNode* root) {
        // bfs + level order traversal
        // tc:O(n); sc:O(n)
        if(!root) {
            return {};
        }
        vector<ListNode*> res;
        queue<TreeNode*> queue;
        queue.push(root);
        while(queue.size() > 0) {
            int levelSize = queue.size();
            ListNode* dummy = new ListNode(-1);
            ListNode* cur = dummy;
            for(int i = 0; i < levelSize; i++) {
                TreeNode* node = queue.front();
                queue.pop();
                cur->next = new ListNode(node->val);
                cur = cur->next;
                if(node->left) {
                    queue.push(node->left);
                }
                if(node->right) {
                    queue.push(node->right);
                }
            }
            res.push_back(dummy->next);
        }
        return res;
    }
};