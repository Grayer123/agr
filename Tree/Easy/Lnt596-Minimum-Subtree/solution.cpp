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
     * @param root: the root of binary tree
     * @return: the root of the minimum subtree
     */
    TreeNode * findSubtree(TreeNode * root) {
        // divide and conquer
        // tc:O(n); sc:O(h)
        if(root == nullptr) {
            return root;
        }
        TreeNode* minNode = nullptr;
        int minSum = INT_MAX;
        findMinSubtree(root, minNode, minSum);
        return minNode;
        
    }
private:
    int findMinSubtree(TreeNode* node, TreeNode*& minNode, int& minSum) {
        if(!node) {
            return 0;
        }
        int sum = node->val + findMinSubtree(node->left, minNode, minSum) + findMinSubtree(node->right, minNode, minSum);
        if(sum < minSum) {
            minNode = node;
            minSum = sum;
        }
        return sum;
    }
};