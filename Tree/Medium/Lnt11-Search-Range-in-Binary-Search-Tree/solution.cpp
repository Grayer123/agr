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
 */

class Solution {
public:
    /**
     * @param root: param root: The root of the binary search tree
     * @param k1: An integer
     * @param k2: An integer
     * @return: return: Return all keys that k1<=key<=k2 in ascending order
     */
    vector<int> searchRange(TreeNode * root, int k1, int k2) {
        // bst; recursive traversal
        // tc:O(n); sc:O(h)
        if(!root) {
            return {};
        }
        vector<int> res;
        searchTree(root, k1, k2, res);
        return res;
    }
private:
    void searchTree(TreeNode* node, int k1, int k2, vector<int>& res) {
        if(!node) {
            return;
        }
        if(node->val > k2) {
            searchTree(node->left, k1, k2, res);
        }
        else if(node->val < k1) {
            searchTree(node->right, k1, k2, res);
        }
        else{ // k1 <= node->val <= k2
            res.push_back(node->val);
            searchTree(node->left, k1, node->val, res);
            searchTree(node->right, node->val, k2, res);
        }
    }
};