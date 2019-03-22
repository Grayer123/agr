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

class ResultType {
public:
    int curSum, numNodes;
    ResultType(int _sum, int _size): curSum(_sum), numNodes(_size) {}
};

class Solution {
public:
    /**
     * @param root: the root of binary tree
     * @return: the root of the maximum average of subtree
     */
    TreeNode * findSubtree2(TreeNode * root) {
        // divide and conquer + Result Type
        // tc:O(n); sc:O(h)
        if(!root) {
            return root;
        }
        TreeNode* maxNode = nullptr;
        double maxAvg = INT_MIN;
        FindMaxTreeNode(root, maxAvg, maxNode);
        return maxNode;
    }

private:
    ResultType FindMaxTreeNode(TreeNode* node, double& maxAvg, TreeNode*& maxNode) {
        if(!node) {
            return ResultType(0, 0);
        }
        ResultType left = FindMaxTreeNode(node->left, maxAvg, maxNode);
        ResultType right = FindMaxTreeNode(node->right, maxAvg, maxNode);
        int sum = node->val + left.curSum + right.curSum;
        int num = left.numNodes + right.numNodes + 1;
        double avg = (double)sum / (double)num;
        if(avg > maxAvg) {
            maxAvg = avg;
            maxNode = node;
        }
        return ResultType(sum, num);
    }
};